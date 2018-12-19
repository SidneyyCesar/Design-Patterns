using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class FiestaPrototype: CarroPrototype
    {
        protected FiestaPrototype(FiestaPrototype fiestaPrototype)
        {
            this.valorCompra = fiestaPrototype.getValorCompra();
        }

        public FiestaPrototype()
        {
            valorCompra = 0.0;
        }

        public override String exibirInfo()
        {
            return "Modelo: Fiesta\nMontadora: Ford\n" + "Valor: R$" + getValorCompra();
        }

        public override CarroPrototype clonar()
        {
            return new FiestaPrototype(this);
        }
    }
}
