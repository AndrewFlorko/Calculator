using System;

namespace CalculatorLib
{
    public class Calculator
    {
        private int _base;
        public Calculator(int b)
        {
            _base = b;
        }

        public int Add(int a, int b)
		{
            return a + b;
		}

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Mul(int a, int b)
        {
            return a * a;
        }
    }
}
