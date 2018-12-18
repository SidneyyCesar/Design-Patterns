using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PlugueP1 : IPadrao1
    {
        public String Nome { get; set; }

        public PlugueP1()
        {
            Nome = "PlugueP1";
        }

        public void testar()
        {
            Console.WriteLine("{0} funcionando.", Nome);
        }
    }
}
