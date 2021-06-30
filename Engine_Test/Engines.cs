namespace Engine_Test
{
    public abstract class Engines
    {
        private readonly string _title;

        public Engines(string title)
        {
            _title = title;
        }

        public string GetTitle()
        {
            return _title;
        }

        public abstract double GetHeatingVelocity(double M, double Hm, double V, double Hv);
        public abstract double GetCoolingVelocity(double C, double T_environment, double T_engine);
    }
}
