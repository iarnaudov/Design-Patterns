using _07._ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._ProxyPattern.Models
{
    public class ProxyImage : Image
    {

        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
