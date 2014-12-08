using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 n = Int64.Parse(args[0]);
            for (Int64 i = 3; i * i < n; i += 2)
                if (n % i == 0 && IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            Console.ReadKey();
        }

        public static bool IsPrime(Int64 n)
        {
            if (n % 2 == 0)
                return false;

            for (Int64 i = 3; i * i < n; i+=2)
                if (n % i == 0)
                    return false;

            return true;
        }
    }
}
