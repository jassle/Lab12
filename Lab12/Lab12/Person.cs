using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person()
        {
            Name = "";
            Address = "";
        }
        public Person(string n,string a)
        {
            Name = n;
            Address = a;
        }

        public override string ToString() => Name + " " + Address;
    }
}
