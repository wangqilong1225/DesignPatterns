using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class AddMethod: Method
    {
        /// <summary>
        /// 加法
        /// </summary>
        public override double GetResult() {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
}
