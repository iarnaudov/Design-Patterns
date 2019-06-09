using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Prototype
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    abstract class Prototype
    {
        private string color;

        // Constructor
        public Prototype(string color)
        {
            this.color = color;
        }

        // Gets Name
        public string Color
        {
            get { return color; }
        }

        public abstract Prototype Clone();
    }
}
