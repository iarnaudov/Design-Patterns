using _07._ProxyPattern.Interfaces;
using System;

namespace _07._ProxyPattern.Models
{
    public class RealImage : Image
    {

        private string fileName;

        public RealImage(String fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }


        public void Display()
        {
            Console.WriteLine("Displaying " + fileName);
        }

        private void loadFromDisk(String fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }
}
