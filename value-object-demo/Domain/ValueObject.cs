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
}
