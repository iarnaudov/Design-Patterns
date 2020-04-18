using System;

namespace _05._Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            StateHistory stateHistory = new StateHistory();
            Originator originator = new Originator();

            originator.SetState("State #1");
            originator.SetState("State #2");
            stateHistory.Add(originator.SaveStateToMemento());

            originator.SetState("State #3");

            Console.WriteLine(originator.GetState());
            Console.WriteLine(stateHistory.Get(0).GetState());
        }
    }
}
