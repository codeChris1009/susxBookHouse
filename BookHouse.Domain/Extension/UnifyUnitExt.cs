namespace BookHouse.Domain.Extension;

/// <summary>
///     Unify Extension Methods
///     <br /> 統一單位共用基準的擴充方法
/// </summary>
public static class UnifyUnitExt
{
    /// <param name="value">數值</param>
    extension(double value)
    {
        public double InchToCM()
        {
            if (double.IsNaN(value))
                return value;

            return value * RatioBetweenInchAndCM;
        }

        public double CMToInch()
        {
            if (double.IsNaN(value))
                return value;
            return value / RatioBetweenInchAndCM;
        }

        public double LbToGram()
        {
            if (double.IsNaN(value))
                return value;

            return value * RatioBetweenLbAndGram;
        }

        public double GramToLb()
        {
            if (double.IsNaN(value))
                return value;

            return value / RatioBetweenLbAndGram;
        }
    }
}