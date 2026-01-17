namespace BookHouse.Domain.ConstConfig;

/// <summary>
///     Application symbols, constants and mathematical values
///     <br />應用程式符號、常數與數學值
/// </summary>
public static class GlobalConstants
{
    #region Unit Conversion

    /// <summary>
    ///     Ratio between inches and centimeters
    ///     <br />英寸與公分的轉換比率
    /// </summary>
    public const double RatioBetweenInchAndCM = 2.54;

    public const double RatioBetweenLbAndGram = 453.59237;

    #endregion

    #region Display Symbols

    /// <summary>
    ///     Symbol for inches
    ///     <br />英寸符號
    /// </summary>
    public const string Inch = "\"";


    /// <summary>
    ///     Symbol for pounds
    ///     <br />磅符號
    /// </summary>
    public const string LibraPondo = "lb";

    /// <summary>
    ///     Symbol for centimeters
    ///     <br />公分符號
    /// </summary>
    public const string CM = "cm";

    /// <summary>
    ///     Symbol for grams
    ///     <br />克符號
    /// </summary>
    public const string Gram = "g";

    /// <summary>
    ///     Symbol for millimeters
    ///     <br />毫米符號
    /// </summary>
    public const string LengthMM = "mm";

    /// <summary>
    ///     Multiplication symbol
    ///     <br />乘號符號
    /// </summary>
    public const string MultiplySymbol = "×";

    /// <summary>
    ///     Degree symbol
    ///     <br />度數符號
    /// </summary>
    public const string DegreeSymbol = "°";

    /// <summary>
    ///     Percentage symbol
    ///     <br />百分比符號
    /// </summary>
    public const string PercentSymbol = "%";

    /// <summary>
    ///     Currency symbol (USD)
    ///     <br />貨幣符號（美金）
    /// </summary>
    public const string DollarSymbol = "$";

    /// <summary>
    ///     Plus/minus symbol
    ///     <br />正負號符號
    /// </summary>
    public const string PlusMinusSymbol = "±";

    public const string HyphenSymbol = "-";

    #endregion

    #region Text Constants

    /// <summary>
    ///     Text for unknown unit
    ///     <br />未知單位文字
    /// </summary>
    public const string UNK = "Unknown";

    /// <summary>
    ///     Text for not available
    ///     <br />不可用文字
    /// </summary>
    public const string NotAvailableText = "N/A";


    /// <summary>
    ///     Text for anonymous or unspecified
    ///     <br />佚名,匿名或未指定文字
    /// </summary>
    public const string Anonymous = "Anon";

    #endregion

    #region Common Fractions

    /// <summary>
    ///     Common fractions used in publishing industry
    ///     <br />出版業常用分數
    /// </summary>
    public static readonly IReadOnlyDictionary<double, string> CommonFractions =
        new Dictionary<double, string>
        {
            { 0.125, "1/8" },
            { 0.25, "1/4" },
            { 0.375, "3/8" },
            { 0.5, "1/2" },
            { 0.625, "5/8" },
            { 0.75, "3/4" },
            { 0.875, "7/8" }
        };

    #endregion


    #region Language Codes

    /// <summary>
    ///     Regional language codes for publishing localization
    ///     <br />出版本地化的地區語言代碼
    /// </summary>
    public static readonly IReadOnlyDictionary<string, string> RegionalLanguageCodes =
        new Dictionary<string, string>
        {
            // English variants
            { "en-US", "English (United States)" },
            { "en-GB", "English (United Kingdom)" },
            { "en-AU", "English (Australia)" },
            { "en-CA", "English (Canada)" },
            { "en-NZ", "English (New Zealand)" },

            // Chinese variants
            { "zh-CN", "简体中文 (中国)" },
            { "zh-TW", "繁體中文 (臺灣)" },
            { "zh-HK", "繁體中文 (香港)" },
            { "zh-SG", "简体中文 (新加坡)" },

            // Japanese
            { "ja-JP", "日本語 (日本)" },

            // Korean
            { "ko-KR", "한국어 (대한민국)" },

            // French variants
            { "fr-FR", "Français (France)" },

            // German variants
            { "de-DE", "Deutsch (Deutschland)" },

            // Spanish variants
            { "es-ES", "Español (España)" },
            { "es-MX", "Español (México)" },

            // Portuguese variants
            { "pt-BR", "Português (Brasil)" },
            { "pt-PT", "Português (Portugal)" },

            // Italian
            { "it-IT", "Italiano (Italia)" },

            // Russian
            { "ru-RU", "Русский (Россия)" },

            // Arabic variants
            { "ar-SA", "العربية (السعودية)" },

            // Dutch
            { "nl-NL", "Nederlands (Nederland)" },
            { "nl-BE", "Nederlands (België)" },

            // Swedish
            { "sv-SE", "Svenska (Sverige)" },

            // Danish
            { "da-DK", "Dansk (Danmark)" },

            // Greek
            { "el-GR", "Ελληνικά (Ελλάδα)" },

            // Latin (historical/academic)
            { "la-VA", "Latina (Vaticanum)" }
        };

    #endregion
}