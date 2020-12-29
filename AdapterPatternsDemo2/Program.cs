using System;

namespace AdapterPatternsDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("准备投屏...");
            VGA vga = new InterfaceAdapter();
            vga.RequireConnectDisplay();

            Console.ReadKey();
        }
    }
}
