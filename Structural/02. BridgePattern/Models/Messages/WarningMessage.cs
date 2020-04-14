using _02._BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._BridgePattern.Models.Messages
{
    public class WarningMessage : Message
    {
        public override void Send()
        {
            this.MessageSender.SendMessage("Warning mesasge: \n" + this.Subject, this.Body);
        }
    }
}
