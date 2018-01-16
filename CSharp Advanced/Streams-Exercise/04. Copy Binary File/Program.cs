/*
Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. 
You are not allowed to use the File class or similar helper classes.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream filestreamIN = new FileStream(@"..\..\image.png", FileMode.Open);
            FileStream filestreamOUT = new FileStream(@"..\..\ImageCopy.png", FileMode.Create);

            using (filestreamIN)
            {
                using (filestreamOUT)
                {
                    while (filestreamIN.Position < filestreamIN.Length)
                    {
                        filestreamOUT.WriteByte((byte)filestreamIN.ReadByte());
                    }
                }
            }
        }
    }
}
