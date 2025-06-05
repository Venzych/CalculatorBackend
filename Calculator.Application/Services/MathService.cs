using Calculator.Core.Abstractions;

namespace Calculator.Application.Services
{
    public class MathService : IMathService
    {
        public double Add(double x, double y)
        {
            var result = x + y;
            return result;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
                throw new Exception("The second number cannot be zero.");

            var result = x / y;
            return result;
        }

        public double HardExpression(string expression)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(expression, null);
                var number = Convert.ToDouble(result);
                return number;
            }
            catch
            {
                throw new Exception("Invalid expression.");
            }
        }

        public double Multiply(double x, double y)
        {
            var result = x * y;
            return result;
        }

        public double Pow(double _base, double exponent)
        {
            var result = Math.Pow(_base, exponent);
            return result;
        }

        public double Root(double value, double degree)
        {
            if (degree == 0)
                throw new Exception("Degree cannot be zero.");

            var result = Math.Pow(value, 1.0 / degree);
            return result;

        }

        public double Subtract(double x, double y)
        {
            var result = x - y;
            return result;
        }
    }
}
