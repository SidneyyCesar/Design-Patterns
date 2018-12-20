using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class UsuarioA : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email Recebido pelo usuário A");
        }
    }

    public class UsuarioB : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email Recebido pelo usuario B");
        }
    }

    public class UsuarioC : IObserver
    {
        public void ReceberEmail()
        {
            Console.WriteLine("Email Recebido pelo usuario C");
        }
    }
}
