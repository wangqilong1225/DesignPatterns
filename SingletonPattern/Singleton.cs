using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    public class Singleton
    {
        //私有化构造方法，避免外部创建
        private Singleton()
        {
            long lResult = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                lResult++;
            }
            Thread.Sleep(1000);
            Console.WriteLine("{0}被构造一次", this.GetType().Name);
        }

        private static Singleton _Singleton = null;
        private static object Singleton_Lock = new object();

        //饱汉模式：只要使用这个类就会构造创建
        static Singleton()
        {
            _Singleton = new Singleton();
            Console.WriteLine("类首次被加载实例化");
        }

        //懒汉模式：只有调用了方法才去构造创建
        public static Singleton CreateInstance()
        {
            //判断是否已经存在Singleton实例
            if (_Singleton == null)
            {
                //防止多线程创建实例，加锁
                lock (Singleton_Lock)
                {
                    Console.WriteLine("等待锁之后，释放锁");
                    //保证锁中不能重复创建
                    if (_Singleton == null)
                    {
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }

        //原型模式：解决对象重复创建的问题
        //通过MemberwiseClone来clone新对象，避免重复创建
        public static Singleton CreateInstancePrototype()
        {
            Singleton singleton = (Singleton)_Singleton.MemberwiseClone();
            return singleton;
        }
    }
}
