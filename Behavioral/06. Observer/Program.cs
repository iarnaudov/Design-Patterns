using _06._Observer.Observers;
using System;

namespace _06._Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            new ColorObserver(subject);

            subject.SetState(ConsoleColor.Red);
            subject.SetState(ConsoleColor.Blue);
            subject.SetState(ConsoleColor.DarkMagenta);
            subject.SetState(ConsoleColor.DarkGreen);
        }
    }
}
