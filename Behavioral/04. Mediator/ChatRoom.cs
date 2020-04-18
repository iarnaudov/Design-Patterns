using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Mediator
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(DateTime.Now.ToString() + " [" + user.Name + "] : " + message);
        }
    }
}
