using System;

namespace SingletonAppExample
{
    /// <summary>
    /// This program is an example of singleton pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.createSingleton();
            Singleton singleton2 = Singleton.createSingleton();

            Console.WriteLine(Singleton.instanceCounter);
            Console.ReadKey();
        }
    }
}
