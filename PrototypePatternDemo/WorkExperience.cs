using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternDemo
{
    public class WorkExperience
    {
        public string WorkDate { get; set; }
        public string CompanyName { get; set; }
        public Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
