using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using value_object_demo.Domain;

namespace value_object_demo
{
    public class SkuSpec
    {
        public class WhenEvaluatingEquality : ValueObjectSpec.WhenEvaluatingEquality
        {
            public override ValueObject Create()
            {
                return new Sku("abc123");
            }

            public override ValueObject CreateOther()
            {
                return new Sku("abc124");
            }
        }
    }
}
