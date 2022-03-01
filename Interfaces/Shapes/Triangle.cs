using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Shapes
{
    public class Triangle : IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Triangle(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public string Area()
        {
            return $"Answer: ${(Width * Height) / 2}";
        }
    }
}
