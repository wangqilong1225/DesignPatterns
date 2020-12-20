using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using SQLFactoryDemo.Interface;

namespace SQLFactoryDemo.Factory
{
    public class DataAcess
    {
        //数据库
        static string db = "SQLServer";
        //程序集名称
        static string AssemblyName = "SQLFactoryDemo";

        //User
        public static IUser GetUser()
        {
            //类名称
            string ClassName = "SQLFactoryDemo.Interface." + db + "User";
            IUser user = (IUser)Assembly.Load(AssemblyName).CreateInstance(ClassName);
            return user;
        }

        //Project
        public static IUser GetProject()
        {
            //类名称
            string ClassName = "SQLFactoryDemo.Interface." + db + "Project";
            IUser user = (IUser)Assembly.Load(AssemblyName).CreateInstance(ClassName);
            return user;
        }
    }
}
