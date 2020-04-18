using System;
using System.Collections.Generic;
using System.Text;

namespace _08._TemplatePattern
{
    public class Basketball : Game
    {
        public override void Initialize()
        {
            Console.WriteLine("Basketball game initialized! Start playing.");
        }

        public override void StartPlay()
        {
            Console.WriteLine("Basketball game started! Enjoy the game.");
        }

        public override void EndPlay()
        {
            Console.WriteLine("Basketball game finished!");
        }
    }
}
