using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Entitys;

namespace SQLFactoryDemo.Interface
{
    public class MySQLUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("从MySQL中获取一条User数据，Id为{0}", id);
            User user = new User
            {
                Id = id,
                Name = ""
            };
            return user;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在MySQL中增加一条User数据，Id为{0}，Name为{1}", user.Id, user.Name);
        }
    }
}
