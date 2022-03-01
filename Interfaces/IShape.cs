using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public string Area();
    }
}
