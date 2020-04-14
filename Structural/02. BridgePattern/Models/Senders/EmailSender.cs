using _02._BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._BridgePattern.Models
{
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Email\n{0}\n{1}\n", subject, body);
        }
    }
}
