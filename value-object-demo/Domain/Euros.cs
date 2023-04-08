namespace value_object_demo.Domain
{
    public class Euros : TinyType<decimal>
    {
        public Euros(decimal value) : base(value)
        {
        }
    }
}
