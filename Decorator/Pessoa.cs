using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    sealed class Pessoa : IPessoa
    {
        //component
        public String Andar()
        {
            return "andei";
        }
    }
}
