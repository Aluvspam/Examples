using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class ProjectEuler14
    {
        public List<int> countlist;
        bool checkList(int x, int m)
        {
            if (m < countlist.Count())
            {
                x += countlist[m];
                return true;
            }

            return false;
        }
        public int count(int nm)
        {
            long n = nm;
            int x = 0;



            while (!checkList(x, (int)n))
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                x++;
            }

            return x;
        }

        public void swoop(int n)
        {
            for (int i = 2; i < n; i++)
            {
                countlist.Add(count(i));
                //Console.WriteLine("#" + i + " chainof -> " + countlist[i]);
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

        public ProjectEuler14()
        {
            countlist = new List<int>();
            countlist.Add(0);
            countlist.Add(1);

        }


    }
}
