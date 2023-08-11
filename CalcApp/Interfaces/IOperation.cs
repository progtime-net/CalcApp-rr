using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp.Interfaces
{
    public interface ICalculate
    {
        static string? operation;
        float Calculate(float value1, float value2);
    }
}
