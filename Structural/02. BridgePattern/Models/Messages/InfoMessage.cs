using _02._BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._BridgePattern.Models.Messages
{
    public class InfoMessage : Message
    {
        public override void Send()
        {
            this.MessageSender.SendMessage("Info mesasge: \n" + this.Subject, this.Body);
        }
    }
}
