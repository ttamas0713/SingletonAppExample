using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonAppExample
{
    class Singleton
    {
        private static Singleton instance;
        public static int instanceCounter { get; private set; } = 0;
        private Singleton()
        {
            instanceCounter++;
        }
        public static Singleton createSingleton()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
