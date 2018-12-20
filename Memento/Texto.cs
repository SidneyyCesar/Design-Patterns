using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Texto
    {
        protected String texto;
        TextoCareTaker caretaker;

        public Texto()
        {
            caretaker = new TextoCareTaker();
            texto = "";
        }

        public void escreverTexto(String novoTexto)
        {
            caretaker.adicionarMemento(new TextoMemento(texto));
            texto += novoTexto;
        }

        public void desfazerEscrita()
        {
            texto = caretaker.getUltimoEstadoSalvo().getTextoSalvo();
        }

        public void mostrarTexto()
        {
            Console.WriteLine(texto);
        }
    }
}
