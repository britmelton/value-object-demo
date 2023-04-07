using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_object_demo.Domain
{
    public class Sku : ValueObject
    {
        public Sku(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
