using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Exercito
    {
        public void ConstruirGuerreiro(CriadorDeGuerreiro criadorDeGuerreiro)
        {
            criadorDeGuerreiro.ComArco();
            criadorDeGuerreiro.ComArmadura();
            criadorDeGuerreiro.ComEspada();
        }
    }
}
