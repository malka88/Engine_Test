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

        public abstract double GetHeatingVelocity(double M, double V);
        public abstract double GetCoolingVelocity(double T_environment, double T_engine);
    }
}
