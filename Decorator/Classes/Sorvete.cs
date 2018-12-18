using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    sealed class Sorvete : ISorvete
    {
        //State
        public double Preco
        {
            get
            {
                return 1.50;
            }
        }
    }
}
