using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            BigInteger baseNumber = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            StringBuilder baseFinalNumber = new StringBuilder();
            while (number > 0)
            {
                BigInteger currDigit = number % baseNumber;
                baseFinalNumber.Append(currDigit);

                number = number / baseNumber;
            }
            var reversedBaseFinalNumber = new StringBuilder();
            for (int i = baseFinalNumber.Length - 1; i >= 0; i--)
            {
                reversedBaseFinalNumber.Append(baseFinalNumber[i]);
            }
            Console.WriteLine(reversedBaseFinalNumber.ToString());
        }
    }
}
