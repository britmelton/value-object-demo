namespace value_object_demo.Domain;

public abstract class ValueObject
{
    public override bool Equals(object? other)
    {
        return GetEqualityComponents()
            .SequenceEqual(((ValueObject)other)
                .GetEqualityComponents());
    }

    public abstract IEnumerable<object> GetEqualityComponents();

    public static bool operator == (ValueObject left, ValueObject right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ValueObject left, ValueObject right)
    {
        return !(left == right);
    }
}
