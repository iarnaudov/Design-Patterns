using System;
using System.Collections.Generic;
using System.Text;

namespace _08._TemplatePattern
{
    public class Football : Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Football game initialized! Start playing.");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Football game started! Enjoy the game.");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Football game finished!");
        }
    }
}
