using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class DivisionMethod : Method
    {
        /// <summary>
        /// 除法
        /// </summary>
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("0不可以作为除数!");
            else
                result = NumberA / NumberB;
            return result;
        }
    }
}
