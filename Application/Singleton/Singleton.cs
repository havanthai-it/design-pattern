using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static object _syncLock = new object();

        protected Singleton()
        {
            Console.WriteLine($"Singleton's constructor executed!");
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock(_syncLock)
                {
                    // Double check instance
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }

    class SingletonProgram
    {
        public static void Run()
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Singleton s3 = Singleton.GetInstance();

            if (s1 == s2 && s2 == s3)
            {
                Console.WriteLine($"Three instances s1, s2, s3 is the same!");
            }
        }
    }
}
