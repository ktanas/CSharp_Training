using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    public class RegexOperations
    {
        public static void testMatching(string str, string regex)
        {
            MatchCollection mc = Regex.Matches(str, regex);

            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
    }
}
