using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class CarroPrototype
    {
        protected double valorCompra;

        public abstract String exibirInfo();

        public abstract CarroPrototype clonar();

        public double getValorCompra()
        {
            return valorCompra;
        }

        public void setValorCompra(double valorCompra)
        {
            this.valorCompra = valorCompra;
        }
    }
}
