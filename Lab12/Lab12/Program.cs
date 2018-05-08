using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Jason", "Detroit");
            //Console.WriteLine(p);
            Person s = new Student("Bob", "Troy", "C#", 2018, 2000);
            //Console.WriteLine(s);
            Person t = new Staff("Kamel", "Southfield", "Grand Circus", 25000);
            Console.WriteLine(t);
        }
    }
}
