using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Observer.Observers
{
    public class ColorObserver : Observer
    {
        public ColorObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Subscribe(this);
        }

        public override void Update()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = this.Subject.GetState();
            Console.WriteLine("Updated to color: " + this.Subject.GetState().ToString());
            Console.ResetColor();
        }
    }
}
    