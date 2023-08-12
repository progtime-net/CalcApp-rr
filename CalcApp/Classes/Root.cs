using CalcApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp.Classes
{
    class Root : ICalculator
    {
        public float Operation(float a, float b)
        {
            return (float)Math.Pow(a, 1 / b);
        }
    }
}
