using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Cannot instance this as an Object
// Only inheritenance

namespace Interfaces
{
    internal interface IPerson
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    
    }
}
