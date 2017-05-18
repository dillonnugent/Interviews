using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    class StringRoutines
    {
        static void Main(string[] args)
        {
            String test = removeChars("Battle of the Vowels: Hawaii vs. Gronzy", "aeiou");
            Console.WriteLine(test);
            Console.ReadLine();
        }

        static String removeChars(String str, String remove)
        {
            char[] s = str.ToCharArray();
            char[] r = remove.ToCharArray();
            int src, dst = 0;

            // flags automatically initialized to false, size of 128 assumens ASCII
            Boolean[] flags = new Boolean[128];

            // Set flags for characters to be removed
            for(src = 0; src < r.Length; ++src)
            {
                flags[r[src]] = true;
            }

            // Now loop through all the characters, copying only if they aren't flagged
            for(src = 0; src < s.Length; ++src)
            {
                if(!flags [s[src]])
                {
                    s[dst++] = s[src];
                }
            }

            return new String(s, 0, dst);
        }
    }
}
