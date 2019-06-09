using System;

namespace _03.Builder
{
    /// <summary>
    /// Separate the construction of a complex object from its representation so that the same construction process can create different representations
    /// </summary>
    class StartUp
    {
        static void Main(string[] args)
        {
            var myHamburger = new HamburgerBuilder()
                .AddBread()
                .AddMeal()
                .AddCheese()
                .AddTomato()
                .AddSalad()
                .AddMayonnaise()
                .Build();
            Console.WriteLine($"My hamburger: {myHamburger}");

            var myWifeHamburger = new HamburgerBuilder()
                .AddBread()
                .AddSalad()
                .Build();
            Console.WriteLine($"My wife's hamburger: {myWifeHamburger}");
        }
    }
}
