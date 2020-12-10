using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceGameSimpleFactory
{
    /// <summary>
    /// 海岛模式
    /// </summary>
    public class Island : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来到海岛地图，加油特种兵...");
        }
    }
}
