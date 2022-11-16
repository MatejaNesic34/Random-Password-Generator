using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlja_Raketa
{
    

    internal class Program
    {
        public static int Min(int a, int b, int c, int d)
        {
            int[] pom = new int[4] { a, b, c, d };
            int min = pom[0];
            for (int i = 0; i < 4; i++)
            {
                if (pom[i] < min)
                {
                    min = pom[i];
                }
            }
            return min;
        }

        public static int Max(int a, int b, int c, int d)
        {
            int[] pom = new int[4] { a, b, c, d };
            int Max = pom[0];
            for (int i = 0; i < 4; i++)
            {
                if (pom[i] > Max)
                {
                    Max = pom[i];
                }
            }
            return Max;
        }

        public static int Klackavost(int a, int b, int c, int d)
        {
            return Max(a, b, c, d) - Min(a, b, c, d);
        }

        public static bool Provera1(int a, int b, int c, int d)
        {
            return Klackavost(a + 1, b + 1, c, d) < Klackavost(a, b, c, d);
        }

        public static bool Provera2(int a, int b, int c, int d)
        {
            return Klackavost(a, b + 1, c, d + 1) < Klackavost(a, b, c, d);
        }

        public static bool Provera3(int a, int b, int c, int d)
        {
            return Klackavost(a, b, c + 1, d + 1) < Klackavost(a, b, c, d);
        }

        public static bool Provera4(int a, int b, int c, int d)
        {
            return Klackavost(a + 1, b, c + 1, d) < Klackavost(a, b, c, d);
        }

        public static bool JeProvera1(int a, int b, int c, int d)
        {
            return Klackavost(a + 1, b + 1, c, d) == Klackavost(a, b, c, d);
        }

        public static bool JeProvera2(int a, int b, int c, int d)
        {
            return Klackavost(a, b + 1, c, d + 1) == Klackavost(a, b, c, d);
        }

        public static bool JeProvera3(int a, int b, int c, int d)
        {
            return Klackavost(a, b, c + 1, d + 1) == Klackavost(a, b, c, d);
        }

        public static bool JeProvera4(int a, int b, int c, int d)
        {
            return Klackavost(a + 1, b, c + 1, d) == Klackavost(a, b, c, d);
        }

        public static int Nastavi(int a, int b, int c, int d) // a b, b d, d c, c a
        {
            int nastavi = 0;
            if (Provera1(a, b, c, d))
            {
                nastavi = 1;
            }
            else if (Provera2(a, b, c, d))
            {
                nastavi = 2;
            }
            else if (Provera3(a, b, c, d))
            {
                nastavi = 3;
            }
            else if (Provera4(a, b, c, d))
            {
                nastavi = 4;
            }
            else
            {
                if (JeProvera1(a, b, c, d))
                {
                    if (Provera1(a + 1, b + 1, c, d))
                    {
                        nastavi = 1;
                    }
                    else if (Provera2(a + 1, b + 1, c, d))
                    {
                        nastavi = 1;
                    }
                    else if (Provera3(a + 1, b + 1, c, d))
                    {
                        nastavi = 1;
                    }
                    else if (Provera4(a + 1, b + 1, c, d))
                    {
                        nastavi = 1;
                    }
                    else
                    {
                        nastavi = 0;
                    }
                }
                else if (JeProvera2(a, b, c, d))
                {
                    if (Provera1(a, b + 1, c, d + 1))
                    {
                        nastavi = 2;
                    }
                    else if (Provera2(a, b + 1, c, d + 1))
                    {
                        nastavi = 2;
                    }
                    else if (Provera3(a, b + 1, c, d + 1))
                    {
                        nastavi = 2;
                    }
                    else if (Provera4(a, b + 1, c, d + 1))
                    {
                        nastavi = 2;
                    }
                    else
                    {
                        nastavi = 0;
                    }
                }
                else if (JeProvera3(a, b, c, d))
                {
                    if (Provera1(a, b, c + 1, d + 1))
                    {
                        nastavi = 3;
                    }
                    else if (Provera2(a, b, c + 1, d + 1))
                    {
                        nastavi = 3;
                    }
                    else if (Provera3(a, b, c + 1, d + 1))
                    {
                        nastavi = 3;
                    }
                    else if (Provera4(a, b, c + 1, d + 1))
                    {
                        nastavi = 3;
                    }
                    else
                    {
                        nastavi = 0;
                    }
                }
                else if (JeProvera4(a, b, c, d))
                {
                    if (Provera1(a + 1, b, c + 1, d))
                    {
                        nastavi = 4;
                    }
                    else if (Provera2(a + 1, b, c + 1, d))
                    {
                        nastavi = 4;
                    }
                    else if (Provera3(a + 1, b, c + 1, d ))
                    {
                        nastavi = 4;
                    }
                    else if (Provera4(a + 1, b, c + 1, d ))
                    {
                        nastavi = 4;
                    }
                    else
                    {
                        nastavi = 0;
                    }
                }
            }
            return nastavi;
        }

        public static bool BoolNastavi(int a, int b, int c, int d)
        {
            return Nastavi(a, b, c, d) != 0;
        }


        static void Main(string[] args)
        {
            int a, b, c, d; // a b
                            // c d
            string unos1 = Console.ReadLine();
            string unos2 = Console.ReadLine();
            string[] pom;

            pom = unos1.Split(' ');
            a = int.Parse(pom[0]);
            b = int.Parse(pom[1]);

            pom = unos2.Split(' ');
            c = int.Parse(pom[0]);
            d = int.Parse(pom[1]);

            do
            {
                if (Nastavi(a, b, c, d) == 1)
                {
                    a++;
                    b++;
                }
                else if (Nastavi(a, b, c, d) == 2)
                {
                    b++;
                    d++;
                }
                else if (Nastavi(a, b, c, d) == 3)
                {
                    d++;
                    c++;
                }
                else if (Nastavi(a, b, c, d) == 4)
                {
                    c++;
                    a++;
                }

            } while (BoolNastavi(a, b, c, d));

            Console.WriteLine(Klackavost(a, b, c, d));

            Console.ReadLine();
        }
    }
}
