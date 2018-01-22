using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart(new char[] { '0' });
            int multiplier = int.Parse(Console.ReadLine());

            if (number == "0" || multiplier == 0 || number == "")
            {
                Console.WriteLine(0);
                return;
            }
            int sum = 0;
            int numberInMind = 0;
            int remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(number[i].ToString()) * multiplier + numberInMind;
                numberInMind = sum / 10;
                remainder = sum % 10;
                result.Append(remainder);
                if (i == 0 && numberInMind != 0)
                {
                    result.Append(numberInMind);
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[result.Length - 1 - i]);
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}
