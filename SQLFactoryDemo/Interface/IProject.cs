using System;
using System.Collections.Generic;
using System.Text;
using SQLFactoryDemo.Entitys;

namespace SQLFactoryDemo.Interface
{
    public interface IProject
    {
        void Insert(Project project);
        Project GetProject(int id);
    }
}
