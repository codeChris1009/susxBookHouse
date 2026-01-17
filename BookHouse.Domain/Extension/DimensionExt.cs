namespace BookHouse.Domain.Extension;

/// <summary>
///     Dimension Conversion Utilities with Polymorphic Support
///     <br />支援多型的尺寸轉換工具
/// </summary>
public static class DimensionExt
{
    extension(BookDimensions bookDimensions)
    {
        /// <summary>
        ///     Convert from inches to centimeters
        ///     <br />從英寸轉換為公分
        /// </summary>
        public BookDimensions ToMetric()
        {
            return bookDimensions.Type == DimensionUnitType.Metric
                       ? bookDimensions
                       : new BookDimensions
                           (
                            bookDimensions.Width.InchToCM(),
                            bookDimensions.Height.InchToCM(),
                            bookDimensions.Thickness.InchToCM(),
                            bookDimensions.Weight.LbToGram(),
                            DimensionUnitType.Metric
                           );
        }

        /// <summary>
        ///     Convert from centimeters to inches
        ///     <br />從公分轉換為英寸
        /// </summary>
        public BookDimensions ToImperial()
        {
            return bookDimensions.Type == DimensionUnitType.Inch
                       ? bookDimensions
                       : new BookDimensions
                           (
                            bookDimensions.Width.CMToInch(),
                            bookDimensions.Height.CMToInch(),
                            bookDimensions.Thickness.CMToInch(),
                            bookDimensions.Weight.GramToLb(),
                            DimensionUnitType.Inch
                           );
        }

        /// <summary>
        ///     Convert to display string based on unit type
        ///     <br />根據單位類型轉換為顯示字串, 須確保dimensions已正確設定單位類型
        /// </summary>
        public string ToDisplayDimensions()
        {
            return bookDimensions.Type switch
            {
                DimensionUnitType.Inch   => ToImperialDisplayTemplate(bookDimensions),
                DimensionUnitType.Metric => ToMetricDisplayTemplate(bookDimensions),
                _                        => $"{UNK}"
            };
        }
    }


    /// <summary>
    ///     Convert decimal to common fraction format used in publishing
    ///     <br />將小數轉換為出版業常用的分數格式
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static string ToFractionInInches(double value)
    {
        int whole = (int)value;
        double fraction = value - whole;

        if (Math.Abs(fraction) < 0.01)
            return whole.ToString();

        KeyValuePair<double, string> closest = CommonFractions
           .MinBy(kvp => Math.Abs(kvp.Key - fraction));

        string res = whole > 0
                         ? $"{whole}{HyphenSymbol}{closest.Value}"
                         : closest.Value;

        return res;
    }

    /// <summary>
    ///     Generate display string for inch dimensions using fraction format
    ///     <br />生成英寸尺寸的顯示字串（使用分數格式）
    /// </summary>
    /// <param name="bookDimensions">The dimensions to format</param>
    /// <returns>Formatted dimension string</returns>
    private static string ToImperialDisplayTemplate(BookDimensions bookDimensions)
    {
        return $"{ToFractionInInches(bookDimensions.Width)}{Inch}" +
               $" {MultiplySymbol} " +
               $"{ToFractionInInches(bookDimensions.Height)}{Inch}" +
               $" {MultiplySymbol} " +
               $"{ToFractionInInches(bookDimensions.Thickness)}{Inch}" +
               $" {MultiplySymbol} " +
               $"{bookDimensions.Weight}{LibraPondo}";
    }

    /// <summary>
    ///     Generate display string for metric dimensions using decimal format
    ///     <br />生成公制尺寸的顯示字串（使用小數格式）
    /// </summary>
    /// <param name="bookDimensions">The dimensions to format</param>
    /// <returns>Formatted dimension string</returns>
    private static string ToMetricDisplayTemplate(BookDimensions bookDimensions)
    {
        return $"{bookDimensions.Width:F1}{CM}" +
               $" {MultiplySymbol} " +
               $"{bookDimensions.Height:F1}{CM}" +
               $" {MultiplySymbol} " +
               $"{bookDimensions.Thickness:F1}{CM}" +
               $" {MultiplySymbol} " +
               $"{bookDimensions.Weight}{Gram}";
    }
}