using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Texto texto = new Texto();
                texto.escreverTexto("Primeira linha do texto\n");
                texto.escreverTexto("Segunda linha do texto\n");
                texto.escreverTexto("Terceira linha do texto\n");
                texto.mostrarTexto();
                texto.desfazerEscrita();
                texto.mostrarTexto();
                texto.desfazerEscrita();
                texto.mostrarTexto();
                texto.desfazerEscrita();
                texto.mostrarTexto();
                texto.desfazerEscrita();
                texto.mostrarTexto();
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
