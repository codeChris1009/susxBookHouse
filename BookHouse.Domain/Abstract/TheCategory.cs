namespace BookHouse.Domain.Abstract;

/// <summary>
///     Abstract representation of a Category entity,
///     <br />包含分類的基本資訊與相關實體
/// </summary>
public abstract class TheCategory
{
    /// <summary>
    ///     Unique Identifier Key for the Category,
    ///     <br />source of the classification standard, BISAC, Thema, etc.
    ///     <br />分類的唯一識別碼, 分類標準的來源, BISAC, Thema, 等等
    /// </summary>
    protected abstract string CategoryKey { get; }

    /// <summary>
    ///     Name of the Category Source Standard Code, FIC000000
    ///     <br /> 分類標準下的代碼, FIC000000
    /// </summary>
    protected abstract string Code { get; }


    /// <summary>
    ///     Name of the Category Description under the Source Standard,
    ///     <br /> 分類標準下的語意描述, Fiction, Non-Fiction, etc.
    /// </summary>
    protected abstract string Name { get; }


    protected abstract string Description { get; }
}