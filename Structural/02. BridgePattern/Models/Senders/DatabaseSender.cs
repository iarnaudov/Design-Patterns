using _02._BridgePattern.Interfaces;
using System;

namespace _02._BridgePattern.Models
{
    public class DatabaseSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("DatabaseSender: \n{0}\n{1}\n", subject, body);
        }
    }
}
