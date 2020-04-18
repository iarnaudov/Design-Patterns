using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Memento
{
    public class StateHistory
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }
    }
}
