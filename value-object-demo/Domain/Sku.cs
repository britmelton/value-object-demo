using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace value_object_demo.Domain
{
    public class Sku : TinyType<string>
    {
        public Sku(string value) : base(value)
        {
        }
    }
}
