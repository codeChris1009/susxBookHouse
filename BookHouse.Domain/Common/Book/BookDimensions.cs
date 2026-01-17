namespace BookHouse.Domain.Common.Book;

/// <summary>
///     Represents the physical dimensions of a book or publication,
///     <br />表示書籍或出版物的物理尺寸
/// </summary>
public class BookDimensions(double width,
                            double height,
                            double thickness,
                            double weight,
                            DimensionUnitType type = DimensionUnitType.Unknown)
{
    public double Width { get; } = width;
    public double Height { get; } = height;
    public double Thickness { get; } = thickness;

    public double Weight { get; } = weight;

    public DimensionUnitType Type { get; } = type;
}