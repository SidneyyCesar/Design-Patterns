using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class TextoMemento
    {
        protected String estadoTexto;

        public TextoMemento(String texto)
        {
            estadoTexto = texto;
        }

        public String getTextoSalvo()
        {
            return estadoTexto;
        }
    }
}
