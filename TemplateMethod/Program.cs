using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Sourdough sourdough = new Sourdough();
                sourdough.Make();

                TwelveGrain twelveGrain = new TwelveGrain();
                twelveGrain.Make();

                WholeWheat wholeWheat = new WholeWheat();
                wholeWheat.Make();
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
