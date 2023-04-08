using System.Runtime.CompilerServices;

namespace value_object_demo.Domain
{
    public class Usd : TinyType<decimal>
    {
        private const decimal ToEuros = 0.91m;
        public Usd(decimal value) : base(value)
        {
        }

        public static implicit operator Euros(Usd source) => new Euros(source.Value*ToEuros);
        //overloaded casting operator -- going to cast provided type(Usd source) to target type (Euros)
    }
}
