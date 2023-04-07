using System.Drawing;
using System.Runtime.InteropServices;
using FluentAssertions;

namespace value_object_demo
{
    public class ValueObjectSpec
    {
        public abstract class WhenEvaluatingEquality
        {
            public abstract ValueObject Create();

            [Fact]
            public void WithSameReference_ThenReturnTrue()
            {
                var valueObject1 = Create();
                var valueObject2 = valueObject1;

                valueObject2.Should().BeSameAs(valueObject1);
            }

            [Fact]
            public void WithSameValues_ThenReturnTrue()
            {
                var valueObject1 = Create();
                var valueObject2 = Create();

                valueObject2.Should().Be(valueObject1);
                valueObject2.Should().NotBeSameAs(valueObject1);
            }
        }
    }

    public abstract class ValueObject
    {
        public override bool Equals(object? other)
        {
            return GetEqualityComponents()
                .SequenceEqual(((ValueObject) other)
                    .GetEqualityComponents());
        }

        public abstract IEnumerable<object> GetEqualityComponents();
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
        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }

        public RgbColor(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Red;
            yield return Green;
            yield return Blue;
        }
    }
}