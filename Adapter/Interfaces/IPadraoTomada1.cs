using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IPadraoTomada1 : IPadrao1
    {
        void Conectar(IPadrao1 _Plugue);

        void Desconectar();

    }
}
