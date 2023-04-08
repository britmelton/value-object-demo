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
    }
}
