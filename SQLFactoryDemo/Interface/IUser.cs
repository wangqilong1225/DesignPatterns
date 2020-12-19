using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Entitys;

namespace SQLFactoryDemo.Interface
{
    public interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
