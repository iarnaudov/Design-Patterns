using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Prototype
{
    /// <summary>
    /// A 'Circle' class 
    /// </summary>
    class Circle : Prototype
    {
        // Constructor
        public Circle(string color) : base(color) {}

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
