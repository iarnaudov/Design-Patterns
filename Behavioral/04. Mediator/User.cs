using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Mediator
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            this.Name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}
