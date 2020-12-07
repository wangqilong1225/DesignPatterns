using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public class Method
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
