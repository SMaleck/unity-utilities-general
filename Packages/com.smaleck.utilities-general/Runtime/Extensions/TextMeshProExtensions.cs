using UnityEngine;

namespace UtilitiesGeneral.Extensions
{
    public static class TextMeshProExtensions
    {
        public const string ColorTagClose = "</color>";

        public static string ColorTagOpen(string hexColor)
        {
            return $"<color=#{hexColor}>";
        }

        public static string Italic(this string value)
        {
            return $"<i>{value}</i>";
        }

        public static string Bold(this string value)
        {
            return $"<i>{value}</i>";
        }

        public static string Colorize(this string value, Color color)
        {
            var colorString = ColorUtility.ToHtmlStringRGBA(color);
            return $"{ColorTagOpen(colorString)}{value}{ColorTagClose}";
        }

        public static string Colorize(this string value, string hexColor)
        {
            return $"{ColorTagOpen(hexColor)}{value}{ColorTagClose}";
        }
    }
}
