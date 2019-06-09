using System;

namespace _04._Prototype
{
    /// <summary>
    /// Creates new objects by copying this prototype.
    /// </summary>
    class StartUp
    {
        static void Main(string[] args)
        {
            // Create instance and clones it
            Circle p1 = new Circle("Red");
            Circle c1 = (Circle)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Color);
        }
    }
}
