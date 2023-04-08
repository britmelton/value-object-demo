using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using value_object_demo.Domain;

namespace value_object_demo
{
    public class DollarsSpec
    {
        public class WhenEvaluatingEquality : ValueObjectSpec.WhenEvaluatingEquality
        {
            public override ValueObject Create()
            {
                return new Dollars(3.00m);
            }

            public override ValueObject CreateOther()
            {
                return new Dollars(5.00m);
            }
        }
    }
}
