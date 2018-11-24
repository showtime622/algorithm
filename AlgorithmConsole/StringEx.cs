using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmConsole
{
    public static class StringEx
    {
        public static bool IsNullOrEmpty(this string source)
        {
            if(string.IsNullOrEmpty(source))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
