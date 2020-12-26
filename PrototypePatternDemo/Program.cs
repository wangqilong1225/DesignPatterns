using System;

namespace PrototypePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume1 = new Resume("张三");
            resume1.SetPersonInfo("男",26);

            //公司：温州皮革厂经历
            resume1.SetWorkExperience("2017-01-01","温州皮革厂");

            //公司：金华皮革厂经历
            Resume resume2 = (Resume)resume1.Clone();
            resume2.SetPersonInfo("男", 27);
            resume2.SetWorkExperience("2018-01-01", "金华皮革厂");

            //公司：江南皮革厂经历
            Resume resume3 = (Resume)resume1.Clone();
            resume3.SetPersonInfo("男", 28);
            resume3.SetWorkExperience("2019-01-01", "江南皮革厂");

            resume1.Show();
            resume2.Show();
            resume3.Show();
            Console.ReadKey();
        }
    }
}
