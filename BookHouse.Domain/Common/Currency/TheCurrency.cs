namespace BookHouse.Domain.Common.Currency;

/// <summary>
///     Abstract representation of a Currency entity
/// </summary>
public abstract class TheCurrency
{
    protected abstract string CodeISO { get; }
    protected abstract string NumISO { get; }

    /// <summary>
    ///     The number of digits after the decimal separator.
    ///     <br />小數點後的位數
    /// </summary>
    protected abstract short DPlace { get; }
}