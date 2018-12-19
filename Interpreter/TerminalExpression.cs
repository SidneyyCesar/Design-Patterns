using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Terminal for {0}.", context.Name);
        }
    }
}
