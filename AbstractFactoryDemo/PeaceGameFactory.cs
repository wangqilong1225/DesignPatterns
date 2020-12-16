using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// 和平精英工厂类
    /// </summary>
    public class PeaceGameFactory
    {
        public ICombatMode GetIsLand() {
            return new PGIsland();
        }

        public ICombatMode GetRainForest()
        {
            return new PGRainForest();
        }

        public ICombatMode GetDesert()
        {
            return new PGDesert();
        }

        public ICombatMode GetSnow()
        {
            return new PGSnow();
        }
    }
}
