internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Add : ICalculator
{
    public float Operation(float a, float b)
    {
        return a + b;
    }
}

class Div : ICalculator
{
    public float Operation(float a, float b)
    {
        return a / b;
    }
}

class Percent : ICalculator
{
    public float Operation(float a, float b)
    {
        return a % b;
    }
}

class Degree : ICalculator
{
    public float Operation(float a, float b)
    {
        if (b == 1)
            return a;
        return a * Operation(a, b - 1);
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