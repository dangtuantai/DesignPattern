// Example pipeline design pattern
using DesignPatternExample.Pipeline;
using DesignPatternExample.Pipeline.PlusNumber.Input;
using DesignPatternExample.Pipeline.PlusNumber.Output;
using DesignPatternExample.Pipeline.PlusNumber.Stages;

var baseInput = new PlusNumberInput() { Number1 = 1, Number2 = 2 };
IPipeLine<PlusNumberInput, int> pipeLine = new PipeLine<PlusNumberInput, ValidateNumberOutput>(input => new ValidateNumberStage().Process(input))
    .AddNextStage(input => new PlusNumberStage().Process(input));

Console.WriteLine(pipeLine.Process(baseInput));