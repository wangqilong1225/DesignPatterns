using System;
using static PeaceGameSimpleFactory.ModeFactory;

namespace PeaceGameSimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来吃鸡啊...");
            Console.WriteLine("请选择地图\n 1:海岛模式 \n 2.雨林模式 \n 3.沙漠模式 \n 4.雪地模式");
            int num = Convert.ToInt32(Console.ReadLine());
            ICombatMode combatMode = null;
            switch (num)
            {
                case 1:
                    combatMode = ModeFactory.GetMode(ModeNames.IsLand);
                    break;
                case 2:
                    combatMode = ModeFactory.GetMode(ModeNames.RainForest);
                    break;
                case 3:
                    combatMode = ModeFactory.GetMode(ModeNames.Desert);
                    break;
                case 4:
                    combatMode = ModeFactory.GetMode(ModeNames.Snow);
                    break;
                default:
                    throw new Exception("不存在该模式....");
            }
            combatMode.SayMode();
            Console.ReadKey();
        }
    }
}
