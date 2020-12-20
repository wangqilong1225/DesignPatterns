using System;
using System.Reflection;
using SQLFactoryDemo.Entitys;
using SQLFactoryDemo.Factory;
using SQLFactoryDemo.Interface;

namespace SQLFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 抽象工厂
            //string db = "SQLServer";
            //IFactory factory = null;
            //switch (db)
            //{
            //    case "SQLServer":
            //        factory = new SQLServerFactory();
            //        break;
            //    case "MySQL":
            //        factory = new MySQLFactory();
            //        break;
            //    default:
            //        throw new Exception("暂不兼容其他数据库!");
            //} 
            #endregion

            #region 抽象工厂+简单工厂
            //string db = "SQLServer";
            //IFactory factory = DataFactory.GetDataDBFactory(db); 
            #endregion
            //IUser user = factory.CreatUser();

            //反射
            IUser user = DataAcess.GetUser();
            user.Insert(new User
            {
                Id = 1,
                Name = ""
            });
            user.GetUser(1);
            Console.ReadKey();
        }
    }
}
