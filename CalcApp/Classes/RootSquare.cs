using CalcApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp.Classes
{

    class RootSquare : ICalculatorOne
    {
        public float Operation(float a)
        {
            return (float)Math.Sqrt(a);
        }
    }
}
