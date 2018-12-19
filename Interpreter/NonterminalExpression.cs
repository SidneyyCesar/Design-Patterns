﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    public class NonterminalExpression : IExpression
    {
        public IExpression Expression1 { get; set; }

        public IExpression Expression2 { get; set; }

        public void Interpret(Context context)
        {
            Console.WriteLine("Nonterminal for {0}.", context.Name);
            Expression1.Interpret(context);
            Expression2.Interpret(context);
        }
    }
}
