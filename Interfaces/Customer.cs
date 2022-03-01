using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Customer : IPerson
    {
        public string Fname { get; set; }
        public string Lname { get; set; }   

        public Customer(string Fname, string Lname)
        {
            this.Fname = Fname;
            this.Lname = Lname;
        }
    }
}
