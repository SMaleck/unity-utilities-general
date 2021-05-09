using System;
using System.Linq;

namespace UtilitiesGeneral.Extensions
{
    public static class EnumExtensions
    {
        public static T Next<T>(this T current) where T : Enum
        {
            var enumValues = EnumIterator<T>.Iterator.ToArray();
            var index = enumValues.IndexOf(current);

            var nextIndex = System.Math.Min(enumValues.Length - 1, index + 1);

            return enumValues[nextIndex];
        }

        public static T Previous<T>(this T current) where T : Enum
        {
            var enumValues = EnumIterator<T>.Iterator.ToArray();
            var index = enumValues.IndexOf(current);

            var previousIndex = System.Math.Max(index - 1, 0);

            return enumValues[previousIndex];
        }

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
