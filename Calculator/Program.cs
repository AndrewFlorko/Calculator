using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
          
            var calculator = new CalculatorLib.Calculator(10);
            Console.WriteLine("Введите число а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма равна ");
            Console.WriteLine(calculator.Add(a,b));
        }
    }
}
