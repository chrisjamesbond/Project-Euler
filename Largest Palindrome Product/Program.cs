using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

//Find the largest palindrome made from the product of two 3-digit numbers.

namespace Largest_Palindrome_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 999;
            int LargestPalindrome = 0; ;

            for (int i = 100; i <= n; i++)
            {
                for (int j = 100; j <= n; j++)
                {
                    int PotentialPalindrome = i * j;
                    if (IsPalindrome(PotentialPalindrome) && PotentialPalindrome > LargestPalindrome)
                        LargestPalindrome = PotentialPalindrome;
                }
            }

            Console.WriteLine("The largest palindrome found was " + LargestPalindrome);
            Console.ReadKey();
        }

        public static bool IsPalindrome(Int32 n)
        {
            String CheckForPalindrome = n.ToString();
            for (int i = 0; i < CheckForPalindrome.Length / 2; i++)
            {
                if (!CheckForPalindrome[i].Equals(CheckForPalindrome[(CheckForPalindrome.Length - 1) - i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
