using System;

namespace Engine_Test
{
    public class EngineIC : Engines
    {
        //Обозначиваем свойства публичными
        //Но set приватным
        //Для того чтобы не добавлять множество методов для получения содержимого полей
        //Но задать или изменить свойства нельзя в основной программе
        public double I { get; private set; }
        public double[] M { get; private set; }
        public double[] V { get; private set; }
        public double Tp { get; private set; }
        public double Hm { get; private set; }
        public double Hv { get; private set; }
        public double C { get; private set; }

        public EngineIC(double I, double[] M, double[] V, double Tp, double Hm, double Hv, double C, string title) : base(title)
        {
            this.I = I;
            this.M = M;
            this.V = V;
            this.Tp = Tp;
            this.Hm = Hm;
            this.Hv = Hv;
            this.C = C;
        }

        public double GetEngineAcceleration(double M)
        {
            double acceleration = M / I;

            return acceleration;
        }

        public override double GetHeatingVelocity(double M, double V)
        {
            double Vn = M * Hm * Math.Pow(V, 2) * Hv;

            return Vn;
        }

        public override double GetCoolingVelocity(double T_environment, double T_engine)
        {
            double Vc = C * (T_environment - T_engine);

            return Vc;
        }
    }
}
