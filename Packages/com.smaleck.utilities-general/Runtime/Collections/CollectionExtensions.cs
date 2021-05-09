using System;
using System.Collections.Generic;
using System.Linq;

namespace UtilitiesGeneral.Collections
{
    public static class CollectionExtensions
    {
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
                action(item);
            }
        }

        public static void For<T>(this IEnumerable<T> enumerable, Action<T, int> action)
        {
            var count = enumerable.Count();
            for (var i = 0; i < count; i++)
            {
                action(enumerable.ElementAt(i), i);
            }
        }
    }
}
