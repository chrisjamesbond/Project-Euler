using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summation_of_Primes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumPrimesToN(2000000));
            Console.Read();
        }

        public static double SumPrimesToN(double n)
        {
            double SumOfPrimes = 0;
            for (double i = 3; i < n; i += 2)
            {
                if (IsPrime(i))
                    SumOfPrimes+= i;
            }

            return SumOfPrimes + 2;
        }

        public static bool IsPrime(double n)
        {
            if (n <= 1 || n == 9)
                return false;

            if (n == 2)
                return true;

            if (n % 2 == 0)
                return false;

            for (double i = 3; i * i <= n; i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
