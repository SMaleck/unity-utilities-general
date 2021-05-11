using UnityEngine;

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
            return value % 2 != 0;
        }

        /// <summary>
        /// Expresses the relation between a value and a max as a percentage. E.g. 100 / 200 -> 50%
        /// </summary>
        public static double ToPercentageOf(this double value, double max)
        {
            return (value / max) * 100;
        }

        /// <summary>
        /// Expresses a factor as an percentage. E.g. 0.5d -> 50%
        /// </summary>
        public static double ToPercentage(this double value)
        {
            return value * 100;
        }

        public static double ToNegativePercentage(this double value)
        {
            return (1 - value) * 100;
        }

        public static double ToAdditivePercentage(this double value)
        {
            return (value - 1) * 100;
        }
        
        /// <summary>
        /// Returns the representation of this float in relative percentage relative to the max value given (between 0 and 1)
        /// </summary>
        public static float ToRelativeTo(this float value, float max)
        {
            return (value / max);
        }

        /// <summary>
        /// Returns the representation of this float in relative percentage relative to the max value given (between 0 and 1)
        /// </summary>
        public static double ToRelativeTo(this double value, double max)
        {
            return (value / max);
        }

        /// <summary>
        /// Returns value * Time.deltaTime
        /// </summary>
        public static float ToTimeAdjusted(this float value)
        {
            return value * Time.deltaTime;
        }
    }
}
