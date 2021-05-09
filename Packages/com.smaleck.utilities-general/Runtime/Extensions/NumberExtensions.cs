namespace UtilitiesGeneral.Extensions
{
    public static class NumberExtensions
    {
        public static double Clamp(this double value, double min, double max)
        {
            value = System.Math.Min(max, value);
            value = System.Math.Max(min, value);

            return value;
        }

        public static int Clamp(this int value, int min, int max)
        {
            value = System.Math.Min(max, value);
            value = System.Math.Max(min, value);

            return value;
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this int value)
        {
            return value % 2 == 1;
        }

        public static double AsPercentage(this double value)
        {
            return value * 100;
        }

        public static double AsNegativePercentage(this double value)
        {
            return (1 - value) * 100;
        }

        public static double AsAdditivePercentage(this double value)
        {
            return (value - 1) * 100;
        }
    }
}
