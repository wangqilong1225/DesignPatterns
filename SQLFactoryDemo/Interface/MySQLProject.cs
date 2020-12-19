﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Entitys;

namespace SQLFactoryDemo.Interface
{
    public class MySQLProject : IProject
    {
        public Project GetProject(int id)
        {
            Console.WriteLine("从MySQL中获取一条Project数据，Id为{0}", id);
            Project project = new Project
            {
                Id = id,
                Name = ""
            };
            return project;
        }

        public void Insert(Project project)
        {
            Console.WriteLine("在MySQL中增加一条Project数据，Id为{0}，Name为{1}", project.Id, project.Name);
        }
    }
}
