using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class CriadorDeGuerreiro
    {
        protected Guerreiro _guerreiro;

        public Guerreiro ObterGuerreiro()
        {
            return _guerreiro;
        }

        public abstract void ComEspada();
        public abstract void ComArmadura();
        public abstract void ComArco();
    }
}
