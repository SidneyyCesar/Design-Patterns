using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }
}
