using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectEuler14 x = new ProjectEuler14();
            x.swoop(1000001);
            x.findIndexHighestCount();
            ProjectEuler14BruteForce v = new ProjectEuler14BruteForce();
            //v.swoop(1000001);
            //v.findIndexHighestCount();
            Console.ReadLine();
        }
    }
}
