namespace Engine_Test
{
    static class LinearFunctionCalculation
    {
        public static double LinearFunction(double x1, double y1, double x2, double y2, double x)
        {
            double y = ((y2 - y1) * (x - x1) / (x2 - x1)) + y1;

            return y;
        }
    }
}
