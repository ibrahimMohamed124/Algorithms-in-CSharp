class SequencesTests : Test
{
    public override void RunTest()
    {
        int range = 18;

        // Fibonacci Sequence
        Console.WriteLine($"The result of {range} is "+Sequences.FibonacciSequence(range));
    }
}
