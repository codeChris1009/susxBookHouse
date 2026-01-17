namespace BookHouse.Domain.Interface;

/// <summary>
///     Interface representing ISBN-related functionalities and properties,
///     <br />與ISBN相關的功能與屬性介面
/// </summary>
public interface ITheISBN
{
    public string GetRawISBN { get; set; }
    public string GetFormattedISBN { get; set; }
    public int GetISBNLength { get; set; }
    public int GetGroupIdentifier { get; set; }
    public int GetPublisherIdentifier { get; set; }
    public bool IsValidISBN { get; set; }
}