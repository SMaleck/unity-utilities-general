using System;
using System.Collections.Generic;
using System.Linq;

namespace UtilitiesGeneral.Extensions
{
    public static class EnumIterator<T> where T : Enum
    {
        private static IEnumerable<T> _enumerable;

        public static IEnumerable<T> Iterator => _enumerable ?? (_enumerable = Enum.GetValues(typeof(T)).Cast<T>());
        public static int Length => Enum.GetNames(typeof(T)).Length;

        public static IEnumerable<T> IteratorExcept(params T[] exclude)
        {
            return Iterator
                .Where(e => !exclude.Contains(e));
        }

        public static void ForEach(Action<T> action)
        {
            Iterator.ForEach(action);
        }
    }
}
