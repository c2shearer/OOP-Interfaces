using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Shapes
{
    public class Square : IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Square(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public string Area()
        {
            return $"Answer: ${Width * Height}";
        }
    }
}
