using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student()
        {
            Program = "";
            Year = 0;
            Fee = 0;
        }
        public Student(string n, string a, string p, int y, double f) : base(n, a)
        {
            Program = p;
            Year = y;
            Fee = f;
        }
        public override string ToString() => base.ToString()+ " " + Program + " " + Year + " " + Fee; 
    }
}
