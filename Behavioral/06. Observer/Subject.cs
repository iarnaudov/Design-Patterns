using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private ConsoleColor state;

        public ConsoleColor GetState()
        {
            return state;
        }

        public void SetState(ConsoleColor state)
        {
            this.state = state;
            NotifyAllObservers();
        }

        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}
