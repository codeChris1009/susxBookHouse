namespace BookHouse.Domain.Common.Book;

/// <summary>
///     Represents the digital attributes of a book or publication,
///     ///   <br />表示書籍或出版物的數位屬性
/// </summary>
public class BookDigitals(double fileSizeMB,
                          string format)
{
    /// <summary>
    ///     File size in megabytes (MB)
    ///     <br />檔案大小（以兆位元組為單位）
    /// </summary>
    public double FileSizeMB { get; } = fileSizeMB;

    /// <summary>
    ///     Digital format, file extension (e.g., .pdf, .epub, .mobi)
    ///     <br />數位格式, 副檔名（例如，.pdf, .epub, .mobi）
    /// </summary>
    public string FormatExtension { get; } = format;
}