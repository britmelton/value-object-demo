using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
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

        public class WhenCreating
        {
            [Theory]
            [InlineData("abc123")]
            [InlineData("wdg458")]
            public void WithValidValue_ThenSkuIsReturned(string value)
            {
                var sku = new Sku(value);

                sku.Should().NotBeNull();
                sku.Value.Should().Be(value);

            }
        }
    }
}
