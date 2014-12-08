using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Pythagorean_Triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("product = " + FindSpecialPythagoreanTriplet(1000));
            Console.Read();
            
        }

        public static double FindSpecialPythagoreanTriplet(double n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = i + 1; j <= n - i; j++)
                {
                    for (int k = j + 1; k <= n - (j + i); k++)
                    {
                        if (CheckForRightTriangle(i,j,k) && (i + j + k) == n)
                        {
                            Console.WriteLine("a = " + i);
                            Console.WriteLine("b = " + j);
                            Console.WriteLine("c = " + k);
                            return i * j * k;
                        }
                    }
                }
            }

            return -1;
        }

        public static bool CheckForRightTriangle(double a, double b, double c)
        {
            double LenghOfSidesSquared = (a * a) + (b * b);
            double LengthOfHypotenuseSquared = c * c;

            if (LenghOfSidesSquared == LengthOfHypotenuseSquared)
                return true;

            return false;
        }
    }
}


