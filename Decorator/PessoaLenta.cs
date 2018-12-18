using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class PessoaLenta : IPessoa
    {
        //Component : IComponent
        IPessoa p;


        public PessoaLenta(IPessoa p)
        {
            this.p = p;
        }


        //Operation
        public String Andar()
        {
            return new StringBuilder(p.Andar())
                .Append(" ")
                .Append("devagar")
                .ToString();
        }
    }
}
