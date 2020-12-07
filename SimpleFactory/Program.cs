using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Method method = CalculatorFactory.GetMethod("+");
            method.NumberA = 0.5;
            method.NumberB = 0.3;
            double result = method.GetResult();
            Console.WriteLine("Result:{0}", result);
            Console.ReadKey();
        }
    }
}
