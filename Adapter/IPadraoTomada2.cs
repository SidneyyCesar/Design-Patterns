﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IPadraoTomada2 : IPadrao2
    {
        void Plugar(IPadrao2 _Plugue);
        void Desplugar();
    }
}
