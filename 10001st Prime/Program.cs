using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001st_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNthPrime(10001));
            Console.Read();   
        }

        public static double FindNthPrime(double n)
        {
            double PrimeCount = 0; 
            double i = 0;
            while (PrimeCount <= n)
            {
                i++;
                if (IsPrime(i))
                    PrimeCount++;
                    
            }

            return i;
        }

        public static bool IsPrime(double n)
        {
            for (double i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}
