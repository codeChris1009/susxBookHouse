namespace BookHouse.Domain.Enum;

/// <summary>
///     Book Category Type Enumeration,
///     <br />書籍分類類型列舉
/// </summary>
public enum BookCategoryType
{
    Unknown = 0,

    /// <summary>
    ///     Classification by type, such as poetry, prose,
    ///     <br />novel, drama ... etc.
    ///     <br /> 按照體裁分類, 如詩, 散文, 小說, 戲劇等分類方式
    /// </summary>
    Type = 0,

    /// <summary>
    ///     Classification by genre, such as fiction, non-fiction,
    ///     <br />mystery, romance, fantasy, biography, history ... etc.
    ///     <br /> 按照風格分類, 如小說, 非小說, 神秘, 愛情, 奇幻, 傳記, 歷史...等
    /// </summary>
    Genre = 1,

    /// <summary>
    ///     Classification by topic, such as science, technology,
    ///     <br />programming health, business, self-help ... etc.
    ///     <br /> 按照主題分類, 如科學, 技術, 程式設計, 健康, 商業, 自助...等
    /// </summary>
    Topic = 2,

    /// <summary>
    ///     Classification by region, such as American literature,
    ///     <br />British literature, French literature, Japanese literature, Greek literature... etc.
    ///     <br /> 按照地理區域分類, 如美國文學, 英國文學, 法國文學, 日本文學, 希臘文學... 等等
    /// </summary>
    Region = 3,

    /// <summary>
    ///     Classification by intended audience, such as children,
    ///     <br />young adult, adult ... etc.
    ///     <br /> 按照目標讀者分類, 如兒童, 青少年, 成人...等
    /// </summary>
    Audience = 4,


    /// <summary>
    ///     Classification by specific tags or keywords, such as "bestseller",
    ///     <br />"award-winning", "classic", "new release",
    ///     <br /> especially custom tags used for seasonal marketing or timely promotional campaigns,
    ///     <br />such as "Christmas", "election reading", etc.
    ///     <br />按照特定標籤或關鍵字分類, 如 "暢銷書", "獲獎作品", "經典", "新書發行",
    ///     <br />尤指自訂標籤, 如用於節日行銷或時事促銷活動, 如 "聖誕節", "大選研讀" 等等
    /// </summary>
    Tag = 5
}