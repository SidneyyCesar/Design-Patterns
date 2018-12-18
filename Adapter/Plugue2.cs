using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PlugueP2 : IPadrao2
    {
        public String Descricao { get; set; }

        public PlugueP2()
        {
            Descricao = "PlugueP2";
        }

        public void Run()
        {
            Console.WriteLine("{0} funcionando.", Descricao);
        }
    }
}
