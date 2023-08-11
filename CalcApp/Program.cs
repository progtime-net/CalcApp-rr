internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class CalcInput : ICalculatorInput
{
    string[] ICalculatorInput.ParseInput(string input)
    {
        return input.Split();
    }

    float ICalculatorInput.ReturnOperate(string input, float a, float b)
    {
        if (input == "+")
        {
            Plus plus = new Plus();
            return plus.Operation(a, b);
        }
        else
        {
            Minus minus = new Minus();
            return minus.Operation(a, b);
        }
    }
}

class Plus : ICalculator
{
    public float Operation(float a, float b)
    {
        return a + b;
    }
}

class Minus : ICalculator
{
    public float Operation(float a, float b)
    {
        return a - b;
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