using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.App
{
    public interface ICalculatorService
    {
        int Add(int x, int y);

        int Div(int x, int y);

        int Mul(int x, int y);

        int Sub(int x, int y);
    }
}
