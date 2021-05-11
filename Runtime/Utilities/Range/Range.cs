namespace UtilitiesGeneral.Utilities.Range
{
    public class Range<T> : IRange<T>
    {
        public T From { get; set; }
        public T To { get; set; }

        public Range(T from, T to)
        {
            From = from;
            To = to;
        }
    }
}
