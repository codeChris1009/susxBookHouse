namespace BookHouse.Domain.Enum;

/// <summary>
///     Book Format Type Enumeration,
///     <br />after <see cref="Paperback" /> is digital products,
///     <br />書籍格式類型列舉, <see cref="Paperback" /> 之後為數位產品
/// </summary>
public enum BookFormatType
{
    Unknown = 0,

    /// <summary>
    ///     Hardcover Book Format
    ///     <br />精裝書格式
    /// </summary>
    Hardcover = 1,

    /// <summary>
    ///     Paperback Book Format
    ///     <br />平裝書格式
    /// </summary>
    Paperback = 2,

    // Below are digital electronic products
    // 以下為數位電子化產品
    EBook = 3,
    AudioBook = 4
}