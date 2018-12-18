using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var instance1 = Singleton.Instance;
                var instance2 = Singleton.Instance;

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
