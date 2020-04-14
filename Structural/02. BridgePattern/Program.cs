using _02._BridgePattern.Interfaces;
using _02._BridgePattern.Models;
using _02._BridgePattern.Models.Messages;
using System;

namespace _02._BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender emailSender = new EmailSender();
            IMessageSender databaseSender = new DatabaseSender();
            IMessageSender notificationSender = new NotificationSender();

            Message message = new ErrorMessage();
            message.Subject = "Test Message";
            message.Body = "Hi, This is a Test Message";
            message.MessageSender = emailSender;
            message.Send();

            Console.WriteLine("-------------------------------------");

            message.MessageSender = databaseSender;
            message.Send();

            Console.WriteLine("-------------------------------------");

            Message warning = new WarningMessage();
            warning.Subject = "Test Message";
            warning.Body = "Hi, This is a Test Message";
            warning.MessageSender = notificationSender;
            warning.Send();

            Console.WriteLine("-------------------------------------");
        }
    }
}
