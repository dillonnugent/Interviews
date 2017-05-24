using System;

namespace Interviews
{
    public class StringManipulation
    {
        /// <summary>
        /// Arrays - Removes one string from another in place
        /// </summary>
        /// <param name="str"></param>
        /// <param name="remove"></param>
        /// <returns></returns>
        public static String RemoveChars(String str, String remove)
        {
            if (str == null)
            {
                return "Exception: null or empty string";
            }

            char[] s = str.ToCharArray();
            char[] r = remove.ToCharArray();
            int src, dst = 0;

            // flags automatically initialized to false, size of 128 assumens ASCII
            Boolean[] flags = new Boolean[128];

            // Set flags for characters to be removed
            for (src = 0; src < r.Length; ++src)
            {
                flags[r[src]] = true;
            }

            // Now loop through all the characters, copying only if they aren't flagged
            for (src = 0; src < s.Length; ++src)
            {
                if (!flags[s[src]])
                {
                    s[dst++] = s[src];
                }
            }

            return new String(s, 0, dst);
        }

        public static int WordCount(String str)
        {
            if(str == null) {return 0;}
            str = str.Trim();
            int wordCount = 0, index =0;
            while (index < str.Length)
            {
                // check if the current character is part of a word
                while (index < str.Length && !char.IsWhiteSpace(str[index]))
                {
                    index++;
                }
                
                wordCount++;
                
                // skip whitespace until next word
                while (index < str.Length && char.IsWhiteSpace(str[index]))
                {
                    index++;
                }
            }
            return wordCount;
        }


    }
}