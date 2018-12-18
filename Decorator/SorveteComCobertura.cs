using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class SorveteComCobertura : ISorvete
    {
        //Component : IComponent
        ISorvete s;


        public SorveteComCobertura(ISorvete s)
        {
            this.s = s;
        }


        //State
        public double Preco
        {
            get
            {
                return this.s.Preco + 0.50;
            }
        }
    }
}
