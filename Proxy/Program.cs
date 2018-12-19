using System;
using System.Collections.Generic;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPessoa> pessoas = new List<IPessoa>();

            try
            {
                pessoas.Add(new ProxyPessoa("A"));
                pessoas.Add(new ProxyPessoa("B"));
                pessoas.Add(new ProxyPessoa("C"));

                Console.Write(pessoas[0].getId());

                Console.WriteLine("Nome: " + pessoas[0].getNome()); // busca do banco de dados
                Console.WriteLine("Nome: " + pessoas[1].getNome()); // busca do banco de dados
                Console.WriteLine("Nome: " + pessoas[0].getNome()); // já buscou esta pessoa... apenas retorna do cache...

                // A terceira pessoa nunca será consultada no banco de dados (melhor performance - lazy loading)
                Console.WriteLine("Id da 3ª - " + pessoas[2].getId());//pode imprimir o ID do objeto, e o proxy nao será inicializado.
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
