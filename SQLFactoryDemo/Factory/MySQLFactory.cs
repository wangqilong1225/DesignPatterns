using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Interface;

namespace SQLFactoryDemo.Factory
{
    public class MySQLFactory : IFactory
    {
        public IProject CreateProject()
        {
            return new MySQLProject();
        }

        public IUser CreatUser()
        {
            return new MySQLUser();
        }
    }
}
