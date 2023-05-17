namespace DesignPatternExample.Pipeline
{
    /// <summary>
    ///  Process of pipeline
    /// </summary>
    /// <typeparam name="Input"></typeparam>
    /// <typeparam name="Output"></typeparam>
    public interface IProcess<Input, Output>
    {
        public Output Process(Input input);
    }
}
