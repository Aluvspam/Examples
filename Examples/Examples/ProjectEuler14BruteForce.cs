using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class ProjectEuler14BruteForce
    {
        public List<int> countlist;

        public int returnCount(int m)
        {
            int x = 1;
            long n = m;
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    x++;
                }
                else
                {
                    n = n * 3 + 1;
                    x++;
                }
            }

            return x;
        }


        public void swoop(int n)
        {
            for (int i = 2; i < n; i++)
            {
                countlist.Add(returnCount(i));
                Console.WriteLine("#" + i + " chainof -> " + countlist[i]);
            }
        }

        public void findIndexHighestCount()
        {
            int c = 0;
            for (int i = 0; i < countlist.Count; i++)
            {
                if (c < countlist[i])
                {
                    c = countlist[i];
                }
            }

            Console.WriteLine("Chain count of " + c + " for the nr " + countlist.IndexOf(c));
        }

        public ProjectEuler14BruteForce()
        {
            countlist = new List<int>();
            countlist.Add(0);
            countlist.Add(1);

        }


    }
}
