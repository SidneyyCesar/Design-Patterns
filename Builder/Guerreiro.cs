using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class Guerreiro
    {
        public string Espada { get; protected set; }
        public string Armadura { get; protected set; }
        public string Arco { get; protected set; }

        public abstract void EscolherEspada(string espada);
        public abstract void ColocarArmadura(string armadura);
        public abstract void EscolherArco(string arco);
    }
}
