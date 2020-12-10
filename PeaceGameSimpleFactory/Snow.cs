using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceGameSimpleFactory
{
    //雪地模式
    public class Snow : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来到雪地地图，加油特种兵...");
        }
    }
}
