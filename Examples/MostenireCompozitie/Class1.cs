using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostenireCompozitie
{
    class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test :)");

            ClasaDeBaza a = new ClasaDeBaza();
            a.showi();

            Console.WriteLine(" Test c baza ");

            ClasaDerivataMostenire b = new ClasaDerivataMostenire();
            b.showi();

            Console.WriteLine(" Test c Mostenire ");

            ClasaDerivataCompozitie c = new ClasaDerivataCompozitie();
            c.showi();

            Console.WriteLine(" Test c Compozitie ");
        }
    }
}
