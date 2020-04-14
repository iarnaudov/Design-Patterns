using _02._BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._BridgePattern.Models.Messages
{
    public class ErrorMessage : Message
    {
        public override void Send()
        {
            this.MessageSender.SendMessage("Error mesasge: \n" + this.Subject, this.Body);
        }
    }
}
