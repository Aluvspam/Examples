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
            new NoStrategy.World();
            var w = new Solid_Examples.AndreiR.World();
            Console.ReadLine();
            //Andrei's txt created
            //Cristi's txt created 
            // Denisa txt
            //Andrei2 test 
            var v = new ProblemCurs6();
            Console.WriteLine(v.ToString());
            Console.ReadLine();
        }
    }
}
