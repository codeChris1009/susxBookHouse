namespace BookHouse.Domain.Abstract;

/// <summary>
///     Abstract representation of a Social Media Link entity
///     <br />包含社交媒體連結的基本資訊與相關實體
/// </summary>
public abstract class TheSocialMedia
{
    protected abstract string PlatformName { get; }

    protected abstract string Url { get; }
}