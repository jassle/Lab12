using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff()
        {
            School = "";
            Pay = 0;
        }
        public Staff(string n, string a, string s, double p) : base(n, a)
        {
            School = s;
            Pay = p;
        }
        public override string ToString() => base.ToString() + " " + School + " " + Pay;
       
    }
}
