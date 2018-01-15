using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"..\..\sourcefile.txt";
            string destinationFile = @"..\..\destfile.txt";
            using (StreamReader reader = new StreamReader(sourceFile))
            {
                using (var writer = new StreamWriter(destinationFile))
                {
                    long lineNumber = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {                       
                        writer.WriteLine($"Line {lineNumber}: {line}");
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
