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
            string db = "SQLServer";
            IFactory factory = null;
            switch (db)
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

            IUser user = factory.CreatUser();
            user.Insert(new User
            {
                Id = 1,
                Name = ""
            });
            user.GetUser(1);


            //反射
            //IUser user = (IUser)Assembly.Load("SQLFactoryDemo").CreateInstance("SQLFactoryDemo.Interface.SQLServerUser");
            //user.Insert(new User
            //{
            //    Id = 1,
            //    Name=""
            //}) ;
            //user.GetUser(1);
            Console.ReadKey();
        }
    }
}
