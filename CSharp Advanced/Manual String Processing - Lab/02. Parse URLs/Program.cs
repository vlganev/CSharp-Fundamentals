using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_URLs
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = Console.ReadLine();

            string separator = "://";

            string[] urlTokens = url.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            if (urlTokens.Length != 2 || urlTokens[1].IndexOf('/') == -1)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            else
            {
                string protocol = urlTokens[0];
                int indexResourse = urlTokens[1].IndexOf('/');
                string server = urlTokens[1].Substring(0, indexResourse);
                string resources = urlTokens[1].Substring(indexResourse+1);
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resources}");
            }
        }
    }
}
