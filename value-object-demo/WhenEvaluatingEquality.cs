using FluentAssertions;
using value_object_demo.Domain;

namespace value_object_demo
{
    public class ValueObjectSpec
    {
        public abstract class WhenEvaluatingEquality
        {
            public abstract ValueObject Create();
            public abstract ValueObject CreateOther();

            [Fact]
            public void WithSameReference_ThenReturnTrue()
            {
                var valueObject1 = Create();
                var valueObject2 = valueObject1;

                valueObject2.Should().BeSameAs(valueObject1);

                (valueObject1 == valueObject2).Should().BeTrue();
                (valueObject1 != valueObject2).Should().BeFalse();
            }

            [Fact]
            public void WithSameValues_ThenReturnTrue()
            {
                var valueObject1 = Create();
                var valueObject2 = Create();

                valueObject2.Should().Be(valueObject1);
                valueObject2.Should().NotBeSameAs(valueObject1);

                (valueObject1 == valueObject2).Should().BeTrue();
                (valueObject1 != valueObject2).Should().BeFalse();
            }

            [Fact]
            public void WithDifferentStructure_ThenReturnFalse()
            {
                var valueObject1 = Create();
                var valueObject2 = CreateOther();

                valueObject2.Should().NotBe(valueObject1);

            }
        }
    }
}