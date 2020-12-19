using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Interface;

namespace SQLFactoryDemo.Factory
{
    public class SQLServerFactory : IFactory
    {
        public IProject CreateProject()
        {
            return new SQLServerProject();
        }

        public IUser CreatUser()
        {
            return new SQLServerUser();
        }
    }
}
