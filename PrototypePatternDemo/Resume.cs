using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternDemo
{
    public class Resume
    {
        private string Name { get; set; }
        private string Sex { get; set; }
        private int Age { get; set; }
        private WorkExperience work;

        public Resume(string name) {
            this.Name = name;
            work = new WorkExperience();
        }

        public Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        //设置个人信息
        public void SetPersonInfo(string sex,int age) {
            this.Sex = sex;
            this.Age = age;
        }

        //设置工作经历
        public void SetWorkExperience(string date,string companyName) {
            work.WorkDate = date;
            work.CompanyName = companyName;
        }

        public void Show() {
            Console.WriteLine("姓名：{0}  性别：{1}  年龄：{2}",Name,Sex,Age);
            Console.WriteLine("工作经历：{0} {1}",work.WorkDate,work.CompanyName);
        }

        public Object Clone() {
            Resume resume = new Resume(this.work);
            resume.Name = this.Name;
            resume.Sex = this.Sex;
            resume.Age = this.Age;
            return resume;
        }
    }
}
