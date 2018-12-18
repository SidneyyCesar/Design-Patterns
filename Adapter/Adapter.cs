using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class PlugueP1Adapter : IPadrao1
    {
        IPadrao2 plugueP2;

        public PlugueP1Adapter(IPadrao2 _PlugueP2)
        {
            plugueP2 = _PlugueP2;
        }

        public string Nome
        {
            get
            {
                return plugueP2.Descricao;
            }
            set
            {
                plugueP2.Descricao = value;
            }
        }

        public void testar()
        {
            plugueP2.Run();
        }
    }

    public class PlugueP2Adapter : IPadrao2
    {
        IPadrao1 plugueP1;

        public PlugueP2Adapter(IPadrao1 _PlugueP1)
        {
            plugueP1 = _PlugueP1;
        }

        public string Descricao
        {
            get
            {
                return plugueP1.Nome;
            }
            set
            {
                plugueP1.Nome = value;
            }
        }

        public void Run()
        {
            plugueP1.testar();
        }
    }
}
