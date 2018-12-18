using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FiestaPrototype prototipoFiesta = new FiestaPrototype();

                CarroPrototype palioNovo = prototipoFiesta.clonar();
                palioNovo.setValorCompra(27900.0);

                CarroPrototype palioUsado = prototipoFiesta.clonar();
                palioUsado.setValorCompra(21000.0);

                Console.WriteLine(palioNovo.exibirInfo());
                Console.WriteLine(palioUsado.exibirInfo());

            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
