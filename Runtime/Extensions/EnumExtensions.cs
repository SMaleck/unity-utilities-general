using System;
using System.Linq;
using UtilitiesGeneral.Utilities;

namespace UtilitiesGeneral.Extensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Returns the next value of an enum.
        /// Will return the current value, if it is already the last of the enum
        /// </summary>
        public static T Next<T>(this T current) where T : Enum
        {
            var enumValues = EnumIterator<T>.Iterator.ToArray();
            var index = enumValues.IndexOf(current);

            var nextIndex = System.Math.Min(enumValues.Length - 1, index + 1);

            return enumValues[nextIndex];
        }

        /// <summary>
        /// Return the previous value of an enum.
        /// Will return the current value, if it is already the first of the enum
        /// </summary>
        public static T Previous<T>(this T current) where T : Enum
        {
            var enumValues = EnumIterator<T>.Iterator.ToArray();
            var index = enumValues.IndexOf(current);

            var previousIndex = System.Math.Max(index - 1, 0);

            return enumValues[previousIndex];
        }

        /// <summary>
        /// Return the next value of an enum.
        /// Will wrap around and return the first value, if the current one is the last of the enum
        /// </summary>
        public static T NextWrap<T>(this T current) where T : Enum
        {
            var enumValues = EnumIterator<T>.Iterator.ToArray();
            var index = enumValues.IndexOf(current);

            var nextIndex = index + 1;
            var wrappedNextIndex = nextIndex < enumValues.Length
                ? nextIndex
                : 0;

            return enumValues[wrappedNextIndex];
        }

        /// <summary>
        /// Return the previous value of an enum.
        /// Will wrap around and return the last value, if the current one is the first of the enum
        /// </summary>
        public static T PreviousWrap<T>(this T current) where T : Enum
        {
            var enumValues = EnumIterator<T>.Iterator.ToArray();
            var index = enumValues.IndexOf(current);

            var previousIndex = index - 1;
            var wrappedPreviousIndex = previousIndex >= 0
                ? previousIndex
                : enumValues.Length - 1;

            return enumValues[wrappedPreviousIndex];
        }
    }
}
