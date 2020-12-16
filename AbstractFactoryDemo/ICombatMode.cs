using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDemo
{
    /// <summary>
    /// 场景接口
    /// </summary>
    public interface ICombatMode
    {
        abstract void SayMode();
    }
}
