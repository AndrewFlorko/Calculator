using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            var calculator = new CalculatorLib.Calculator(10);
            Console.WriteLine(calculator.Add(a,b));
        }
    }
}
