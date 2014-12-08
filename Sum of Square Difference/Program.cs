using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 100;

            double SumOfSquares = SumSquares(n);
            double SquareOfSum = SquareSum(n);

            Console.WriteLine(SquareOfSum - SumOfSquares);
            Console.Read();


        }

        public static double SumSquares(double n)
        {
            double SumOfSquares = 0;
            for (int i = 1; i <= n; i++)
            {
                SumOfSquares += i * i;
            }

            return SumOfSquares;
        }

        public static double SquareSum(double n)
        {
            double Sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Sum += i;
            }

            return Sum * Sum;
        }
    }
}
