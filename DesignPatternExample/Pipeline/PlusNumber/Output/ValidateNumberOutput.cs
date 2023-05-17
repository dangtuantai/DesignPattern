using DesignPatternExample.Pipeline.PlusNumber.Input;

namespace DesignPatternExample.Pipeline.PlusNumber.Output
{
    public class ValidateNumberOutput
    {
        public bool IsValid { get; set; } = false;
        public PlusNumberInput Output { get; set; } = default!;
    }
}
