using CalcApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp.Classes
{
    class Square : ICalculatorOne
    {
        public float Operation(float a)
        {
            return (float)Math.Pow(a, 2);
        }
    }
}
