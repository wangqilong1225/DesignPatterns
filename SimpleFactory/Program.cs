using System;
using System.Configuration;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = ConfigurationManager.AppSettings["MethodConfig"];
            Method method = CalculatorFactory.GetMethod(type);
            method.NumberA = 0.5;
            method.NumberB = 0.3;
            double result = method.GetResult();
            Console.WriteLine("Result:{0}", result);
            Console.ReadKey();
        }
    }
}
