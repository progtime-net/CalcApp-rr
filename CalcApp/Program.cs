using System.Data;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}

<<<<<<< HEAD
class RootSquare : ICalculatorOne
{
    public float Operation(float a)
    {
        return (float)Math.Sqrt(a);
    }
}
class Square : ICalculatorOne
{
    public float Operation(float a)
    {
        return (float)Math.Pow(a, 2);
    }
}
=======
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

>>>>>>> 1f98ffc984a9ba2dcea271a482c43874c03f087e
interface ICalculatorInput
{
    string[] ParseInput(string input);

    float ReturnOperate(string input, float a, float b);
}

interface ICalculator
{
    float Operation(float a, float b);
}
 interface ICalculatorOne
{
    float Operation(float a);
}