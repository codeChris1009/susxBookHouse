namespace BookHouse.Domain.Abstract;

/// <summary>
///     Abstract representation of a Book entity,
///     <br />包含書籍的基本資訊與相關實體
/// </summary>
public abstract class TheBook
{
    /// <summary>
    ///     International Standard Book Number (ISBN)
    ///     <br />國際標準書號 (ISBN)，用於全球唯一識別書籍
    /// </summary>
    protected abstract TheISBN ISBN { get; }

    /// <summary>
    ///     The unique identifier of a book,
    ///     <br />used for internal tracking and management.
    ///     <br />書籍的唯一識別碼，用於內部追蹤與管理
    /// </summary>
    protected abstract string IdCode { get; }

    /// <summary>
    ///     Book Name Show on Cover
    /// </summary>
    protected abstract string Title { get; }

    /// <summary>
    ///     Book Subtitle Show on Cover
    /// </summary>
    protected abstract string Subtitle { get; }

    /// <summary>
    ///     Language of the Book
    /// </summary>
    protected abstract string Language { get; }

    /// <summary>
    ///     Number of Pages in the Book
    /// </summary>
    protected abstract int Pages { get; }

    /// <summary>
    ///     Book Description or Summary
    /// </summary>
    protected abstract string Description { get; }

    /// <summary>
    ///     Series Number if the Book is part of a Series
    ///     <br />For non-series, the value is 0.
    ///     <br />如果書籍是系列的一部分，則表示該書在系列中的編號
    ///     <br /> 非系列則為 0
    /// </summary>
    protected abstract int SeriesNumber { get; }


    #region Related Entities

    /// <summary>
    ///     List of Contributors (Authors, Editors, Illustrators, etc.)
    ///     <br />貢獻者列表（作者、編輯、插畫家等）
    /// </summary>
    protected abstract IReadOnlyCollection<TheContributor> ContributorsInfo { get; }

    /// <summary>
    ///     Publication Specifications (Publisher, Publication Date, Edition, Format, etc.)
    ///     <br />出版規格（出版社、出版日期、版本、格式等）
    /// </summary>
    protected abstract ThePublicationInfo PublishSpec { get; }

    /// <summary>
    ///     Book Categories, Genres, Subjects, and Tags .etc.
    ///     <br /> 書籍相關分類 (類別、主題、標籤等)
    /// </summary>
    protected abstract IReadOnlyCollection<TheCategory> Categories { get; }

    #endregion
}