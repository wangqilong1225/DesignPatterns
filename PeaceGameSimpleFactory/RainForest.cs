using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceGameSimpleFactory
{
    /// <summary>
    /// 雨林模式
    /// </summary>
    public class RainForest : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来到雨林地图，加油特种兵...");
        }
    }
}
