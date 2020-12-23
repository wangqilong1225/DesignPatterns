using System;

namespace PrototypePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume1 = new Resume("张三");
            resume1.SetPersonInfo("男",26);
            resume1.SetWorkExperience("2017-01-01","BangBangBang");
            

            Resume resume2 = (Resume)resume1.Clone();
            resume2.SetWorkExperience("2018-01-01", "HaHaHa");

            Resume resume3 = (Resume)resume1.Clone();
            resume3.SetWorkExperience("2019-01-01", "LaLaLa");


            resume1.Show();
            resume2.Show();
            resume3.Show();

            Console.ReadKey();
        }
    }
}
