using System;
using System.Collections.Generic;
using System.Text;

namespace _02._BridgePattern.Interfaces
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
