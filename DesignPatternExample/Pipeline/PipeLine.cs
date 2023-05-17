namespace DesignPatternExample.Pipeline
{
    /// <summary>
    /// Implement pipeline design pattern
    /// </summary>
    /// <typeparam name="Input"></typeparam>
    /// <typeparam name="Output"></typeparam>
    public class PipeLine<Input, Output> : IPipeLine<Input, Output>, IProcess<Input, Output>
    {
        /// <summary>
        /// Current stage handler
        /// </summary>
        Func<Input, Output> currentStage;
        public PipeLine(Func<Input, Output> nextStage)
        {
            currentStage = nextStage;
        }

        /// <summary>
        /// Add next step
        /// </summary>
        /// <typeparam name="CurrentStage"></typeparam>
        /// <param name="nextStage">next stage process (input next stage is output of current stage)</param>
        /// <returns></returns>
        public PipeLine<Input, CurrentStage> AddNextStage<CurrentStage>(Func<Output, CurrentStage> nextStage)
        {
            return new PipeLine<Input, CurrentStage>(input => nextStage(currentStage(input)));
        }

        /// <summary>
        /// Process pipeline
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public Output Process(Input input)
        {
            return currentStage(input);
        }
    }
}