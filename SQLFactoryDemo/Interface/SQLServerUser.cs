using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Entitys;

namespace SQLFactoryDemo.Interface
{
    public class SQLServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("从SQLServer中获取一条User数据，Id为{0}", id);
            User user = new User
            {
                Id = id,
                Name = ""
            };
            return user;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在SQLServer中增加一条User数据，Id为{0}，Name为{1}", user.Id, user.Name);
        }
    }
}
