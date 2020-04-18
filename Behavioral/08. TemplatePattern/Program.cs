using System;

namespace _08._TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Basketball();
            game.Play();
            Console.WriteLine();
            game = new Football();
            game.Play();
        }
    }
}
