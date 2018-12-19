using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class CriadorDeGuerreiroMedieval : CriadorDeGuerreiro
    {
        public CriadorDeGuerreiroMedieval()
        {
            _guerreiro = new GuerreiroMedieval();
        }

        public override void ComEspada()
        {
            _guerreiro.EscolherEspada("espada medieval");
        }

        public override void ComArmadura()
        {
            _guerreiro.ColocarArmadura("armadura medieval");
        }

        public override void ComArco()
        {
            _guerreiro.EscolherArco("arco medieval");
        }
    }
}
