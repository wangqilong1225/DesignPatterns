using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 乘法
    /// </summary>
    public class MultiplicationMethod : Method
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
