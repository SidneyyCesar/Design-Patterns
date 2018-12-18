using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Uso direto
                TomadaP1 Tomada1 = new TomadaP1();

                TomadaP2 Tomada2 = new TomadaP2();

                PlugueP1 PlugueP1 = new PlugueP1();

                PlugueP2 PlugueP2 = new PlugueP2();

                Tomada1.Conectar(PlugueP1);

                Tomada1.testar();

                Tomada1.Desconectar();

                Tomada1.testar();

                Tomada2.Plugar(PlugueP2);

                Tomada2.Run();

                Tomada2.Desplugar();

                Tomada2.Run();

                //Utilizando o adapter para ligar o plugue 2 as duas tomadas
                var plugueP1Adapter = new PlugueP1Adapter(PlugueP2);

                plugueP1Adapter.testar();

                var plugueP2Adapter = new PlugueP1Adapter(PlugueP2);

                plugueP2Adapter.testar();
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
