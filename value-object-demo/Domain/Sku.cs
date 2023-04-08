
using System.Text.RegularExpressions;

namespace value_object_demo.Domain
{
    public class Sku : TinyType<string>
    {
        public Sku(string value) : base(value)
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z]{3}[0-9]{3}$"))
            {
                throw new ArgumentException("Sku must be 3 letters followed by 3 numbers", nameof(value));
            }
        }
    }
}
