using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Prototype
{
    /// <summary>
    /// A 'Square' class 
    /// </summary>
    class Square : Prototype
    {
        // Constructor
        public Square(string color) : base(color) {}

        // Returns a shallow copy
        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
