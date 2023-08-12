using CalcApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp.Classes
{
    class Degree : ICalculator
    {
        public float Operation(float a, float b)
        {
            if (b == 1)
                return a;
            return a * Operation(a, b - 1);
        }
    }
}
