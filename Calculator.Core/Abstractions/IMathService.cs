using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Abstractions
{
    public interface IMathService
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
        double Pow(double _base, double exponent);
        double  Root(double value, double degree);
        double HardExpression(string expression);
        
    }
}
