using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Product_in_a_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int AdjacentNumbers = 13;
            String BigNumber = ParseFileForNumber();
            double LargestProduct = 0;

            for(int i = 0; i < BigNumber.Length - AdjacentNumbers; i++)
            {
                double ProductOfSeries = 1;
                for (int j = i; j < i + AdjacentNumbers; j++)
                {
                    ProductOfSeries *= Double.Parse(BigNumber[j].ToString());
                }

                if (ProductOfSeries > LargestProduct)
                    LargestProduct = ProductOfSeries;
            }

            Console.Write(LargestProduct);
            Console.Read();
        }

        public static string ParseFileForNumber()
        {
            StreamReader Reader = new StreamReader("input.txt");
            String BigNumberInAString = "";
            while (true)
            {
                String CurrentLine = Reader.ReadLine();
                if (!String.IsNullOrEmpty(CurrentLine))
                    BigNumberInAString += CurrentLine;
                else
                    break;
            }

            return BigNumberInAString;
        }
    }
}
