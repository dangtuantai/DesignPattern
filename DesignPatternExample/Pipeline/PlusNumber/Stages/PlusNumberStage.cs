using DesignPatternExample.Pipeline.PlusNumber.Output;

namespace DesignPatternExample.Pipeline.PlusNumber.Stages
{
    /// <summary>
    /// Validate plus number stage
    /// </summary>
    public class PlusNumberStage : IProcess<ValidateNumberOutput, int>
    {
        public int Process(ValidateNumberOutput input)
        {
            int output = 0;
            if (input.IsValid)
            {
                output = input.Output.Number1 + input.Output.Number2;
            }
            return output;
        }
    }
}
