namespace UtilitiesGeneral.Utilities.Range
{
    public class ReadOnlyRange<T> : IReadOnlyRange<T>
    {
        public T From { get; }
        public T To { get; }

        public ReadOnlyRange(T from, T to)
        {
            From = from;
            To = to;
        }
    }
}
