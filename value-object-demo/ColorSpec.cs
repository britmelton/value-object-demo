using value_object_demo.Domain;

namespace value_object_demo;

public class ColorSpec
{
    public class WhenEvaluatingEquality : ValueObjectSpec.WhenEvaluatingEquality
    {
        public override ValueObject Create()
        {
            return new RgbColor(255, 0, 0);
        }

        public override ValueObject CreateOther()
        {
            return new RgbColor(0, 0, 255);
        }
    }
}
