using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp.Interface
{
    interface ICalculatorInput
    {
        string[] ParseInput(string input);

        float ReturnOperate(string input, float a, float b);
    }
}
