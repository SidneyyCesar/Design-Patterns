using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class SorveteComImcremento : ISorvete
    {
        //Component : IComponent
        ISorvete s;


        public SorveteComImcremento(ISorvete s)
        {
            this.s = s;
        }


        //State
        public double Preco
        {
            get
            {
                return this.s.Preco + 0.75;
            }
        }
    }
}
