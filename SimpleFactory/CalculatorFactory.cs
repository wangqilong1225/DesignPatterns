using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class CalculatorFactory
    {
        /// <summary>
        /// 工厂类
        /// </summary>
        public static Method GetMethod(string type)
        {
            Method method = null;
            switch (type)
            {
                case "+":
                    method = new AddMethod();
                    break;
                case "-":
                    method = new SubtractionMethod();
                    break;
                case "*":
                    method = new MultiplicationMethod();
                    break;
                case "/":
                    method = new DivisionMethod();
                    break;
            }
            return method;
        }
    }
}
