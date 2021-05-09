namespace UtilitiesGeneral.Utilities.Range
{
    public interface IRange<T> : IReadOnlyRange<T>
    {
        new T From { get; set; }
        new T To { get; set; }
    }
}
