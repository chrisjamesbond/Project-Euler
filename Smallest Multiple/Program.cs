using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Multiple
{
    class Program
    {
        static void Main(string[] args)
       {
            bool Solved = false;
            int Index = 0;
            while (!Solved)
            {
                Index += 20;

                if (CheckMultiples(Index) == true)
                    break;
            }

            Console.WriteLine(Index);
            Console.ReadKey();
        }

        public static bool CheckMultiples(int n)
        {
            for (int i = 2; i <= 19; i++)
            {
                if (n % i != 0)
                    return false;
            }

            return true;
        }
    }
}
