using System;
using System.Collections.Generic;
using System.Text;

namespace SQLFactoryDemo.Interface
{
    public interface IFactory
    {
        IUser CreatUser();

        IProject CreateProject();
    }
}
