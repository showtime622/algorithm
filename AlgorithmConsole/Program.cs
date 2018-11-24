using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    class Program
    {
        public int count = 0;
        static void Main(string[] args)
        {
            //TreeTraverse.traverseAllFiles(@"C:\Python34");
            UniqueEmailAddress.NumUniqueEmails(new string[] {"test.email+alex@leetcode.com", "test.e.mail+bob.cathy@leetcode.com", "testemail+david@lee.tcode.com" });
            string x1 = "test.mail+111";
            x1 = x1.Replace(".", "");
            string xx = TreeTraverse.getSpecificFile(@"C:\Python34", "crlf.py");

            Console.WriteLine("Hello World!");
            Console.WriteLine("Total file count " + TreeTraverse.count.ToString());
            Console.ReadKey();
        }
    }
}
