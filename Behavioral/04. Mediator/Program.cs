using System;

namespace _04._Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi! John!");
            john.SendMessage("Hello! Robert!");
        }
    }
}
