using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string openTag = "<upcase>";
            string closedTag = "</upcase>";

            int startIndex = input.IndexOf(openTag);
            while (startIndex != -1)
            {
                int endIndex = input.IndexOf(closedTag);
                if (endIndex == -1)
                {
                    break;
                }
                string toBeReplaced = input.Substring(startIndex, endIndex + closedTag.Length - startIndex);
                var replaced = toBeReplaced.Replace(openTag, string.Empty).Replace(closedTag, string.Empty).ToUpper();

                input = input.Replace(toBeReplaced, replaced);

                startIndex = input.IndexOf(openTag);
            }
            Console.WriteLine(input);
        }
    }
}
