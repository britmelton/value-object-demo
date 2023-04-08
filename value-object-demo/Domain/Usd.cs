using System.Runtime.CompilerServices;

namespace value_object_demo.Domain
{
    public class Usd : TinyType<decimal>
    {
        public Usd(decimal value) : base(value)
        {
        }
    }


}
