using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var exercito = new Exercito();

                CriadorDeGuerreiro criadorDeGuerreiro;
                Guerreiro guerreiro;

                // criando um guerreiro medieval
                criadorDeGuerreiro = new CriadorDeGuerreiroMedieval();
                exercito.ConstruirGuerreiro(criadorDeGuerreiro);
                guerreiro = criadorDeGuerreiro.ObterGuerreiro();
                Console.WriteLine("Guerreiro com as características: {0}, {1}, {2}", guerreiro.Arco, guerreiro.Armadura, guerreiro.Espada);

                // criando um guerreiro futurista
                criadorDeGuerreiro = new CriadorDeGuerreiroFuturista();
                exercito.ConstruirGuerreiro(criadorDeGuerreiro);
                guerreiro = criadorDeGuerreiro.ObterGuerreiro();
                Console.WriteLine("Guerreiro com as características: {0}, {1}, {2}", guerreiro.Arco, guerreiro.Armadura, guerreiro.Espada);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
