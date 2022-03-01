using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Shapes
{
    internal class Square : IShape, IColour
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Colours Colour { get; set; }
        public Square(int Height, int Width, Colours Colour)
        {
            this.Height = Height;
            this.Width = Width;
            this.Colour = Colour;
        }

        public string Area()
        {
            return $"Area of Square: {Width * Height}";
        }

        override
        public string ToString()
        {
            return $"Square is {Height}l and {Width}w with a Colour of {Colour}";
        }
    }
}
