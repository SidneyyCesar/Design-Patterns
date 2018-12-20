using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface ISubject
    {
        void Registrar(IObserver observer);
        void Remover(IObserver observer);
        void EnviarEmail();
    }
}
