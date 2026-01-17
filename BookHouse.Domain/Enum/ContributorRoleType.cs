namespace BookHouse.Domain.Enum;

/// <summary>
///     Contributor Role Type Enumeration,
///     <br />Use [<see cref="FlagsAttribute" />>] Attribute
///     <br />貢獻者角色類型列舉, 使用 <see cref="FlagsAttribute" />> 屬性
/// </summary>
[Flags]
public enum ContributorRoleType
{
    Unknown = 0, // 0,  0b00000
    Reader = 1 << 0, // 1,  0b00001
    Author = 1 << 1, // 2,  0b00010
    Editor = 1 << 2, // 4,  0b00100

    /// <summary>
    ///     Illustrator of the Book
    ///     <br />插畫家
    /// </summary>
    Illustrator = 1 << 3, // 8,  0b01000

    /// <summary>
    ///     Translator of the Book
    ///     <br />翻譯者
    /// </summary>
    Translator = 1 << 4, // 16, 0b10000

    /// <summary>
    ///     Critic of the Book
    ///     <br />評論家
    /// </summary>
    Critic = 1 << 5 // 32, 0b100000
}