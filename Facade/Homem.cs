using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    //Classe Facede
    public static class Homem
    {
        //Sub sistema simulado 1
        static Carteira carteira = new Carteira();

        //Sub sistema simulado 2
        static Pessoa pessoa = new Pessoa();


        //Operation1
        public static void SacarDinheiro()
        {

            pessoa.Ir("caixa eletrônico");

            carteira.Abrir();

            carteira.PegarCartao("débito");

            pessoa.PassarCartao();

            pessoa.DigitarSenha();

            pessoa.PegarDinheiro();

            carteira.GuardarCartao();

            carteira.Guardar("bolso");

            pessoa.Ir("casa");
        }
    }
}
