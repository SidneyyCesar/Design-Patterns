using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IteratorExample example = new IteratorExample();

                foreach (string item in example)
                    Console.WriteLine(item);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
