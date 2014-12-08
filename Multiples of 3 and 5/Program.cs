using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Multiples of 3 and 5
//Problem 1
//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("The sum of all the multiples of 3 or 5 below {0} is {1}", args[0], MethodOne(Int32.Parse(args[0]))));

            Stopwatch MethodTimer = new Stopwatch();
            

            MethodTimer.Start();
            MethodOne(Int32.Parse(args[0]));
            MethodTimer.Stop();

            Console.WriteLine("Method one took {0} milliseconds", MethodTimer.Elapsed.Milliseconds);

            MethodTimer.Reset();
            MethodTimer.Start();
            MethodTwo(Int32.Parse(args[0]));
            MethodTimer.Stop();
            Console.WriteLine("Method one took {0} milliseconds", MethodTimer.Elapsed.Milliseconds);

            Console.Read();
        }

        public static Int64 MethodOne(int n)
        {
            Int64 SumOfMultiples = 0;

            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    SumOfMultiples += i;
            }

            return SumOfMultiples;   
        }

        public static Int64 MethodTwo(int n)
        {
            Int64 SumOfMultiples = 0;

            for (int i = 0; i < n; i+=3)
                SumOfMultiples += i;
            for (int i = 0; i < n; i += 5)
                SumOfMultiples += i;
            for (int i = 0; i < n; i += 15)
                SumOfMultiples -= i;

            return SumOfMultiples;  
        }
    }
}
