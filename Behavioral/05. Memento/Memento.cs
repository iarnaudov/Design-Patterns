using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Memento
{
    public class Memento
    {
        private string state;

        public Memento(string state)
        {
            this.state = state;
        }

        public string GetState()
        {
            return state;
        }
    }
}
