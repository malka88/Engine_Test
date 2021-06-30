using System;
using System.Threading;

namespace Engine_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int timer = 1;

            double Velocity = 0;
            double[] V = { 0, 75, 150, 200, 250, 300 };
            double[] M = { 20, 75, 100, 105, 75, 0 };

            double Moment;

            EngineIC engineIC = new(10, M, V, 110, 0.01, 0.0001, 0.1, "Test");

            Console.Write("Введите температуру окружающей среды (в градусах Цельсия): ");

            double T_environment = double.Parse(Console.ReadLine());
            double T_engine = T_environment;

            for (int i = 0; i < V.Length - 1; i++)
            {
                for (double j = V[i]; j < V[i + 1]; j++)
                {
                    Moment = LinearFunctionCalculation.LinearFunction(V[i], M[i], V[i + 1], M[i + 1], j);

                    double a = Moment / engineIC.I;

                    Velocity = a + Velocity;

                    double Vh = Moment * engineIC.Hm + Math.Pow(Velocity, 2) * engineIC.Hv;
                    double Vc = engineIC.C * (T_environment - T_engine);

                    T_engine = T_engine + Vh + Vc;

                    timer++;

                    if(timer % 5 == 1)
                    {
                        Console.WriteLine($"Скорость: " + Velocity);
                        Console.WriteLine($"Крутящий момент: " + Moment);
                        Console.WriteLine($"Температура двигателя: " + T_engine);
                        Console.WriteLine($"Прошло: " + timer + " секунд");

                        Thread.Sleep(1000);

                        Console.Clear();
                    }

                    if (T_engine >= engineIC.Tp)
                    {
                        Console.WriteLine($"Время до перегрева: " + timer);
                        return;
                    }   
                }
            }
        }
    }
}
