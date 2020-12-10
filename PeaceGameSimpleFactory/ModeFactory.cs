using System;
using System.Collections.Generic;
using System.Text;

namespace PeaceGameSimpleFactory
{
    /// <summary>
    /// 地图模式工厂
    /// </summary>
    public class ModeFactory
    {
        /// <summary>
        /// 获取地图模式
        /// </summary>
        /// <param name="type"></param>
        public static ICombatMode GetMode(ModeNames type)
        {
            ICombatMode CombatMode = null;
            switch (type)
            {
                case ModeNames.IsLand:
                    CombatMode = new Island();
                    break;
                case ModeNames.RainForest:
                    CombatMode = new RainForest();
                    break;
                case ModeNames.Desert:
                    CombatMode = new Desert();
                    break;
                case ModeNames.Snow:
                    CombatMode = new Snow();
                    break;
                default:
                    throw new Exception("不存在该模式...");
            }
            return CombatMode;
        }

        /// <summary>
        /// 枚举所有模式
        /// </summary>
        public enum ModeNames
        {
            IsLand, RainForest, Desert, Snow
        }
    }
}
