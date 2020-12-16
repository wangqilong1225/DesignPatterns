using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// 海岛模式
    /// </summary>
    public class PGIsland : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来到和平精英，这里是海岛地图，加油特种兵...");
        }
    }
}
