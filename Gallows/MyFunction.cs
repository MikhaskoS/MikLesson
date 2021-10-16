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

        public static bool IsGameOver(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '*') return false;


            }
            return true;
        }

        public static void Skeleton(int attept)
        {
            string s1=
@"--------------
      
      
      
     
    
      
     / \
    |   | 
==============
  ||     ||
     ";
            string s2 =
@"--------------
      
      
      
     
      |
      |  
     / \
    |   | 
==============
  ||     ||
     ";
            string s3 =
@"--------------
      
      
      
     
    \-|-/
      |  
     / \
    |   | 
==============
  ||     ||
     ";
            string s4 =
@"--------------
      
      
      
     ( )
    \-|-/
      |  
     / \
    |   | 
==============
  ||     ||
     ";
            string s5 =
@"--------------
      |
      |
      |
     ( )
    \-|-/
      |
     / \
    |   |   
     ";
            switch (attept)
            {
                case 1:
                    Console.WriteLine(s1);
                    break;
                case 2:
                    Console.WriteLine(s2);
                    break;
                case 3:
                    Console.WriteLine(s3);
                    break;
                case 4:
                    Console.WriteLine(s4);
                    break;
                case 5:
                    Console.WriteLine(s5);
                    break;
            }
        }

    }
}
