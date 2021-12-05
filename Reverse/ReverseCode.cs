using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class ReverseCode
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Code("Hello World"));
        }
        public static string Code(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result+=str[i];
            }
            return(result);
        }
    }
}
