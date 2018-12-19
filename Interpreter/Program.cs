using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Context context = new Context("Dot Net context");

                NonterminalExpression root = new NonterminalExpression();

                root.Expression1 = new TerminalExpression();
                root.Expression2 = new TerminalExpression();

                root.Interpret(context);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
