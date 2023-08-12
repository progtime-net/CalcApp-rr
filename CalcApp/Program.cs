using System.Data;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
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