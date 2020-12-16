using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// 雨林模式
    /// </summary>
    public class PGRainForest : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来到和平精英，这里是雨林地图，加油特种兵...");
        }
    }
}
