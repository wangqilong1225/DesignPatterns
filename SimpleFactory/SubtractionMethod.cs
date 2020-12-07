using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class SubtractionMethod : Method
    {
        /// <summary>
        /// 减法
        /// </summary>
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
}
