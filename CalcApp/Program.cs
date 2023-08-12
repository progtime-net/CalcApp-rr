internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Input : ICalculatorInput
{
    public string[] ParseInput(string input)
    {
        return input.Split(' ');
    }

    public float ReturnOperate(string input, float a, float b)
    {
        return 1;
    }
}

class Sub : ICalculator
{
    public float Operation(float a, float b)
    {
        return a - b;
    }
}

class Mult : ICalculator
{
    public float Operation(float a, float b)
    {
        return a * b;
    }
}

class Root : ICalculator
{
    public float Operation(float a, float b)
    {
        return (float)Math.Pow(a, 1/b);
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