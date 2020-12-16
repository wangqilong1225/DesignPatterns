using System;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            PeaceGameFactory pgFactory = new PeaceGameFactory();
            ICombatMode combatMode = pgFactory.GetRainForest();
            combatMode.SayMode();

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
