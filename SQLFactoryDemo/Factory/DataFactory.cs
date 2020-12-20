using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Interface;

namespace SQLFactoryDemo.Factory
{
    public class DataFactory
    {
        #region 简单工厂
        public static IFactory GetDataDBFactory(string DBName)
        {
            IFactory factory = null;
            switch (DBName)
            {
                case "SQLServer":
                    factory = new SQLServerFactory();
                    break;
                case "MySQL":
                    factory = new MySQLFactory();
                    break;
                default:
                    throw new Exception("暂不兼容其他数据库!");
            }
            return factory;
        } 
        #endregion
    }
}
