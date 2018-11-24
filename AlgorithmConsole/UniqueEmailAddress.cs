using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    public class UniqueEmailAddress
    {


        /// <summary>
        /// Every email consists of a local name and a domain name, separated by @ sign.
        /// for example, in alice@leetcode.com, alice is the local name, and leetcode.com is the 
        /// domain name
        /// Besides lowercase letters, these emails may contain '.'s or '+' s.
        /// </summary>
        /// <param name="emails"></param>
        /// <returns></returns>
        public static int NumUniqueEmails(string[] emails)
        {
            if(emails.Length == 0)
            {
                return -1;
            }
            List<string> list = new List<string>();
            
            //the email address should have @ sign by default
            for(int i = 0; i < emails.Length; i++)
            {
                string[] array = emails[i].Split(new char[] { '@' });

                string localName = array[0];
                string domainName = array[1];

                if(localName.Contains("."))
                {
                    localName = localName.Replace(".", "");
                }

                if(localName.Contains("+"))
                {
                    localName = localName.Substring(0, localName.IndexOf("+"));
                }

                if(!list.Contains(localName + "@" + domainName))
                {
                    list.Add(localName + "@" + domainName);
                }

            }

            return list.Count;
        }

    }
}
