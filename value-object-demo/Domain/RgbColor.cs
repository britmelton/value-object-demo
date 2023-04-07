namespace value_object_demo.Domain;

public class RgbColor : ValueObject
{
    public byte Red { get; }
    public byte Green { get; }
    public byte Blue { get; }

    public RgbColor(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Red;
        yield return Green;
        yield return Blue;
    }
}
