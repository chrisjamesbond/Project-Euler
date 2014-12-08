﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:

//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MethodOne(Int32.Parse(args[0])));
            Console.Read();
        }

        public static Int64 MethodOne(int n)
        {
            Int64 SumOfEvenFibonacciNumbers = 0;
            List<int> FibonacciSequence = new List<int>();
            FibonacciSequence.Add(1);
            FibonacciSequence.Add(1);
            for (int i = 0; FibonacciSequence[i] <= n; i++)
            {
                FibonacciSequence.Add(FibonacciSequence[FibonacciSequence.Count - 1] + FibonacciSequence[FibonacciSequence.Count - 2]);
            }

            foreach (int FibonacciNumber in FibonacciSequence)
                if (FibonacciNumber % 2 == 0)
                    SumOfEvenFibonacciNumbers += FibonacciNumber;

            return SumOfEvenFibonacciNumbers;
        }
    }
}
