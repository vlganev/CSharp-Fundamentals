using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            // 01. Stealer
            //string result = spy.StealFieldInfo(typeof(Hacker).FullName, "username", "password");
            // 02. High Quality Mistakes
            //string result = spy.AnalyzeAcessModifiers(typeof(Hacker).FullName);
            // 03. Mission Private Impossible
            //string result = spy.RevealPrivateMethods(typeof(Hacker).FullName);
            // 04. Collector
            string result = spy.CollectGettersAndSetters(typeof(Hacker).FullName);
            Console.WriteLine(result);
        }
    }
}
