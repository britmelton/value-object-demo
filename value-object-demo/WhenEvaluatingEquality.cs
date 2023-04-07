using System.Drawing;
using System.Runtime.InteropServices;
using FluentAssertions;

namespace value_object_demo
{
    public class ValueObjectSpec
    {
        public abstract class WhenEvaluatingEquality
        {
            [Fact]
            public void WithSameReference_ThenReturnTrue()
            {
                var valueObject1 = Create();
                var valueObject2 = valueObject1;

                valueObject2.Should().BeSameAs(valueObject1);
            }

            public abstract ValueObject Create();
        }
    }

    public abstract class ValueObject
    {

    }

    public class ColorSpec
    {
        public class WhenEvaluatingEquality : ValueObjectSpec.WhenEvaluatingEquality
        {
            public override ValueObject Create()
            {
                return new RgbColor(255, 0, 0);
            }
        }
    }

    public class RgbColor : ValueObject
    {
        private byte Red { get; }
        private byte Green { get; }
        private byte Blue { get; }

        public RgbColor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}