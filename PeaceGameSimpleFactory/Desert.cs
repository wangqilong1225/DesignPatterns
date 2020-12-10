using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceGameSimpleFactory
{
    /// <summary>
    /// 沙漠模式
    /// </summary>
    public class Desert : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来沙漠地图，加油特种兵...");
        }
    }
}
