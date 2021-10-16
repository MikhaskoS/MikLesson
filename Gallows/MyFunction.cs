using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows
{
    public class MyFunction
    {
        public static bool CharInString(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch) return true;

            }
            return false;
        }

        public static string Replace(string word_original, string word_finding, char ch)
        {
            char[] result = word_finding.ToArray();

            for (int i = 0; i < word_original.Length; i++)
            {
                if (word_original[i] == ch)
                {
                    result[i] = ch;
                }
            }

            return new string(result);
        }
    }
}
