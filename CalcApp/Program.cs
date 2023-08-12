internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

interface ICalculatorInput
{
    string[] ParseInput(string input);

    float ReturnOperate(string input, float a, float b);
}

interface ICalculator
{
    float Operation(float a, float b);
}