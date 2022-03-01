using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Interfaces.Shapes
{
    internal class Triangle : IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Colours Colour { get; set; }

        public Triangle(int Height, int Width, Colours Colour)
        {
            this.Height = Height;
            this.Width = Width;
            this.Colour = Colour;
        }

        public string Area()
        {
            return $"Answer: {(Width * Height) / 2}";
        }

        override
        public string ToString()
        {
            return $"Triangle is {Height}l and {Width}w / 2 {Area()} with a Colour of {Colour}";
        }
    }
}
