using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    //雪地模式
    public class PGSnow : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来到和平精英，这里是雪地地图，加油特种兵...");
        }
    }
}
