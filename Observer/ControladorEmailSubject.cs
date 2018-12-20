using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class ControladorEmailSubject : ISubject
    {
        private readonly List<IObserver> _usuarios;

        public ControladorEmailSubject()
        {
            _usuarios = new List<IObserver>();
        }

        public void Registrar(IObserver observer)
        {
            _usuarios.Add(observer);
        }

        public void Remover(IObserver observer)
        {
            _usuarios.Remove(observer);
        }

        public void EnviarEmail()
        {
            foreach (var usuario in _usuarios)
            {
                usuario.ReceberEmail();
            }
        }
    }
}
