namespace value_object_demo.Domain;

public abstract class TinyType<T> : ValueObject where T : notnull //constraint so type for T cannot be null
{
    public T Value { get; }

    protected TinyType(T value)
    {
        Value = value;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
