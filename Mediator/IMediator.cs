using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public interface IMediator
    {
        void SendMessage(Colleague caller, string msg);
    }
}
