using System;
using System.Collections.Generic;
using System.Linq;

namespace UtilitiesGeneral.Extensions
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Adds a key-value pair to a Dictionary or replaces an existing key's value
        /// </summary>
        public static void AddOrReplace<TKey, TValue>(this IDictionary<TKey, TValue> dict, TKey key, TValue value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
            }
            else
            {
                dict.Add(key, value);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action.Invoke(item);
            }
        }

        /// <summary>
        /// Performs an action on each of a given enumerable's elements and passes the current index
        /// </summary>
        public static void For<T>(this IEnumerable<T> enumerable, Action<T, int> action)
        {
            var count = enumerable.Count();
            for (var i = 0; i < count; i++)
            {
                action.Invoke(enumerable.ElementAt(i), i);
            }
        }

        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            foreach (var element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static int IndexOf<T>(this IEnumerable<T> enumerable, T value)
        {
            return enumerable.IndexOf(value, null);
        }

        public static int IndexOf<T>(this IEnumerable<T> enumerable, T value, IEqualityComparer<T> comparer)
        {
            comparer = comparer ?? EqualityComparer<T>.Default;

            var found = enumerable
                .Select((a, i) => new { a, i })
                .FirstOrDefault(x => comparer.Equals(x.a, value));

            return found?.i ?? -1;
        }
    }
}
