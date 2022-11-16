using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakMarsovci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i = 0;
            string unos;
            Console.WriteLine("Unesite duzinu kolone Marsovaca");
            n = Convert.ToInt32(Console.ReadLine());
            int[] heights = new int[n];
            Console.WriteLine("Unesite visine svih Marsovaca");
            unos = Console.ReadLine();
            string[] visine = unos.Split(' ');
            for(i = 0; i< n; i++)
            {
                heights[i] = Convert.ToInt32(visine[i]);
            }            
            int brojac = 0;
            int max = 0;
            int min = 50;
            int maxInd = 0;
            int minInd = 0;
            for (i = 0; i < n; i++)
            {
                if (heights[i] < min)
                {
                    minInd = i;
                }
                if (heights[i] > max)
                {
                    maxInd = i;
                }
            }
            if (minInd < maxInd)
                brojac = (minInd + 1) * (n - maxInd);
            else
            {
                brojac = (maxInd + 1) * (n - minInd);
            }
                 
            Console.WriteLine(maxInd);
            Console.WriteLine(minInd);
            Console.WriteLine("Broj podnizova je {0}", brojac);
        }
    }
}
