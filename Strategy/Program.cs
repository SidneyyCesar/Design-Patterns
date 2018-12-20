using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Context context;

                context = new Context(new ConcreteStrategyA());
                context.ContextInterface();

                context = new Context(new ConcreteStrategyB());
                context.ContextInterface();

                context = new Context(new ConcreteStrategyC());
                context.ContextInterface();

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
