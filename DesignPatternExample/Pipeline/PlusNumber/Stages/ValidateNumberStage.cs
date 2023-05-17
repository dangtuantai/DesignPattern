using DesignPatternExample.Pipeline.PlusNumber.Input;
using DesignPatternExample.Pipeline.PlusNumber.Output;

namespace DesignPatternExample.Pipeline.PlusNumber.Stages
{
    /// <summary>
    /// Plus number stage
    /// </summary>
    public class ValidateNumberStage : IProcess<PlusNumberInput, ValidateNumberOutput>
    {
        public ValidateNumberOutput Process(PlusNumberInput input)
        {
            var output = new ValidateNumberOutput();
            if (input.Number1 > 0 && input.Number2 > 0)
            {
                output.IsValid = true;
                output.Output = input;
            }
            return output;
        }
    }
}
