using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezbanje
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos;
            Console.WriteLine("Unesite velicinu baste i broj pocetnih polja");
            unos = Console.ReadLine();
            int n, m;
            string[] pom = unos.Split(' ');
            n = Convert.ToInt32(pom[0]);
            m = Convert.ToInt32(pom[1]);
            int i, j, z;
            i = j = z = 0;
            int brPolja = 0;
            int[] n2 = new int[2 * n];
            for(i = 0; i < m; i++)
            {
                Console.WriteLine("Unesite koordinate pocetnog polja");
                string polje = Console.ReadLine();
                int xi, yi;
                string[] field = polje.Split(' ');
                xi = Convert.ToInt32(field[0]);
                n2[xi] = 1;
                yi = Convert.ToInt32(field[1]);
                n2[yi + n] = 1;
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (n2[i] == 1 || n2[j + n] == 1)
                        brPolja++;
                }

            }

            Console.WriteLine("Na kraju ce biti popunjeno {0} polja", brPolja);
        }
    }
}
