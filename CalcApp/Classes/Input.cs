using CalcApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp.Classes
{
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
}
