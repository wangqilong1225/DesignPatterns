using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式
    /// 使用环境：程序中某个对象只有一个实例
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TaskFactory taskFactory = new TaskFactory();
                List<Task> taskList = new List<Task>();
                for (int i = 0; i < 10; i++)
                {
                    taskList.Add(taskFactory.StartNew(() =>
                    {
                        Singleton singleton = Singleton.CreateInstance();
                    }));
                }
                Task.WaitAll(taskList.ToArray());
                Console.WriteLine("实例化结束");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
            }
            Console.ReadKey();
        }
    }
}
