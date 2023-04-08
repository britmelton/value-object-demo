using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_object_demo.Domain
{
    public class Dollars : ValueObject
    {
        //immutable type must have constructor 
        public Dollars(decimal value)
        {
            Value = value;
        }

        public decimal Value { get; }
        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
