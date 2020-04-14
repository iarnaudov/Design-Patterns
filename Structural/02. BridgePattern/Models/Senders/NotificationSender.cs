using _02._BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02._BridgePattern.Models
{
    public class NotificationSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Push Notification\n{0}\n{1}\n", subject, body);
        }
    }
}
