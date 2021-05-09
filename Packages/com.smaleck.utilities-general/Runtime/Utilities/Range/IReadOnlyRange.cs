namespace UtilitiesGeneral.Utilities.Range
{
    public interface IReadOnlyRange<out T>
    {
        T From { get; }
        T To { get; }
    }
}
