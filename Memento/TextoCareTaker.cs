using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class TextoCareTaker
    {
        protected List<TextoMemento> estados;

        public TextoCareTaker()
        {
            estados = new List<TextoMemento>();
        }

        public void adicionarMemento(TextoMemento memento)
        {
            estados.Add(memento);
        }

        public TextoMemento getUltimoEstadoSalvo()
        {
            if (estados.Count <= 0)
                return new TextoMemento("");

            int index = estados.Count - 1;

            TextoMemento estadoSalvo = estados[index];

            estados.Remove(estadoSalvo);

            return estadoSalvo;
        }
    }
}
