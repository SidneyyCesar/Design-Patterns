using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Exemplo 1
                PessoaAndar();

                //Exemplo 2
                Sorveteria();
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static void PessoaAndar()
        {
            Pessoa pessoa;
            pessoa = new Pessoa();


            Console.WriteLine("usando Pessoa:");
            Console.WriteLine(pessoa.Andar());


            Console.WriteLine();


            PessoaRapida pessoaRapida;
            pessoaRapida = new PessoaRapida(pessoa);


            Console.WriteLine("usando PessoaRapida:");
            Console.WriteLine(pessoaRapida.Andar());
            Console.WriteLine(pessoaRapida.Correr());


            Console.WriteLine();


            PessoaLenta pessoaLenta;
            pessoaLenta = new PessoaLenta(pessoa);


            Console.WriteLine("usando PessoaLenta:");
            Console.WriteLine(pessoaLenta.Andar());
        }

        private static void Sorveteria()
        {
            Sorvete s = new Sorvete();


            Console.WriteLine("Sorvete:");
            Console.WriteLine("{0:c}", s.Preco);


            Console.WriteLine();


            SorveteComCobertura c;
            c = new SorveteComCobertura(s);


            Console.WriteLine("Sorvete com cobertura:");
            Console.WriteLine("{0:c}", c.Preco);


            Console.WriteLine();


            SorveteComImcremento b;
            b = new SorveteComImcremento(s);

            Console.WriteLine("Sorvete com balinha:");
            Console.WriteLine("{0:c}", b.Preco);


            Console.WriteLine();


            SorveteComCobertura cb;
            cb = new SorveteComCobertura(b);


            Console.WriteLine("Sorvete com cobertura E balinha:");
            Console.WriteLine("{0:c}", cb.Preco);
        }
    }
}
