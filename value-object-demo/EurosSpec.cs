using value_object_demo.Domain;

namespace value_object_demo
{
    public class EurosSpec 
    {
        public class WhenEvaluatingEquality : ValueObjectSpec.WhenEvaluatingEquality
        {
            public override ValueObject Create() => new Euros(2.00m);

            public override ValueObject CreateOther() => new Euros(5.00m);
        }

        
    }
}
