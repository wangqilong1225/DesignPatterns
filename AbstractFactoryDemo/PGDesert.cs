using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// 沙漠模式
    /// </summary>
    public class PGDesert : ICombatMode
    {
        public void SayMode()
        {
            Console.WriteLine("欢迎来到和平精英，这里是沙漠地图，加油特种兵...");
        }
    }
}
