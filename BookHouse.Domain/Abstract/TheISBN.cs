namespace BookHouse.Domain.Abstract;

/// <summary>
///     Abstract representation of an ISBN entity,
///     <br />包含國際標準書號碼的基本資訊與相關實體
/// </summary>
public abstract class TheISBN
{
    /// <summary>
    ///     Original ISBN Code, No hyphens
    ///     <br /> 原始的國際標準書號碼, 無連字號
    /// </summary>
    protected abstract string ISBN { get; }

    /// <summary>
    ///     ISBN Code with length of 10 or 13 characters
    ///     <br /> 長度為10或13字元的國際標準書號碼
    /// </summary>
    protected abstract string Length10Or13 { get; }

    /// <summary>
    ///     Publisher Identifier, Unique number
    ///     <br /> 出版者識別碼, 出版社的唯一編號
    /// </summary>
    public abstract string PublisherCode { get; }


    /// <summary>
    ///     Title Identifier, Specific book number under the publisher
    ///     <br /> 出版品識別碼, 該出版社下的特定書籍編號
    /// </summary>
    public abstract string TitleIdentifier { get; }

    /// <summary>
    ///     Check Digit, the last character used for validation
    ///     <br /> 校驗碼, 最後一位，用於驗證碼
    /// </summary>
    public char CheckDigit => ISBN[^1];
}