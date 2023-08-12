using System.Data;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}

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