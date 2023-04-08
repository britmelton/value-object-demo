using FluentAssertions;
using value_object_demo.Domain;

namespace value_object_demo
{
    public class UsdSpec
    {
        public class WhenEvaluatingEquality : ValueObjectSpec.WhenEvaluatingEquality
        {
            public override ValueObject Create()
            {
                return new Usd(3.00m);
            }

            public override ValueObject CreateOther()
            {
                return new Usd(5.00m);
            }
        }

        public class WhenConvertingToEuros
        {
            [Theory]
            [InlineData(1.00, 0.91)]
            [InlineData(45.62, 41.5142)]
            [InlineData(200.45, 182.4095 )]
            public void ThenEurosIsUsdxConversionRate(decimal usd, decimal expectedEuros)
            {
                var usDollars = new Usd(usd);
                Euros euros = usDollars;

                euros.Value.Should().Be(expectedEuros);

            }
        }
    }
}
