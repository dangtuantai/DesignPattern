namespace DesignPatternExample.Pipeline
{
    /// <summary>
    /// Pipeline design pattern
    /// </summary>
    /// <typeparam name="Input"></typeparam>
    /// <typeparam name="Output"></typeparam>
    public interface IPipeLine<Input, Output>
    {
        PipeLine<Input, K> AddNextStage<K>(Func<Output, K> currentStage);
        Output Process(Input input);
    }
}
