using System;

namespace Engine_Test
{
    //Пример расширения функционала путем добавления нового типа двигаиеля
    //Предположим что двигатель имеет также свойства нагрева и охлаждения
    public class GasEngine : Engines
    {
        //TODO: объявить поля класса
        public double param1 { get; private set; }

        public GasEngine(double param1, string title) : base(title)
        {
            //TODO: Инициализация полей класса
        }

        public override double GetCoolingVelocity(double C, double T_environment, double T_engine)
        {
            //TODO: Расчет скорости охлаждения
            throw new NotImplementedException();
        }

        public override double GetHeatingVelocity(double M, double Hm, double V, double Hv)
        {
            //TODO: Расчет скорости охлаждения
            throw new NotImplementedException();
        }
    }
}
