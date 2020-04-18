using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Observer
{
    public abstract class Observer
    {
        protected Subject Subject;
        public abstract void Update();
    }
}
