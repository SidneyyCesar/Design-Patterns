using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Context context = new Context(new StateA());


                context.Request();
                context.Request();
                context.Request();
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
