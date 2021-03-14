using System;
using System.Collections.Generic;
using System.Text;

namespace Anexinet
{
    public static class Anagram
    {
        public static bool AreAnagrams(string wordWhereCheck, string wordToCheck)
        {
            return CheckAnagram(wordWhereCheck.ToUpper(), wordToCheck.ToUpper())
                    || CheckAnagram(wordToCheck.ToUpper(), wordWhereCheck.ToUpper());
        }

        public static bool CheckAnagram(string wordWhereCheck, string wordToCheck)
        {
            char[] whereCheck = wordWhereCheck.ToCharArray();
            char[] toCheck = wordToCheck.ToCharArray();

            Array.Sort(whereCheck);
            Array.Sort(toCheck);

            Dictionary<string, int> whereCharCount = CharCount(whereCheck);
            Dictionary<string, int> toCharCount = CharCount(toCheck);

            bool containsChars = true;
            foreach (KeyValuePair<string, int> entry in toCharCount)
            {
                if (whereCharCount.ContainsKey(entry.Key))
                {
                    if (toCharCount[entry.Key] > whereCharCount[entry.Key])
                    {
                        containsChars = false;
                        break;
                    }
                } else
                {
                    containsChars = false;
                    break;
                }
            }

            return containsChars;
        }

        public static Dictionary<string, int> CharCount(char[] charList)
        {
            Dictionary<string, int> charDictionary = new Dictionary<string, int>();

            if (charList.Length > 0)
            {
                char current = ' ';
                foreach(char c in charList)
                {
                    if (current != c)
                    {
                        charDictionary.Add(c.ToString(), 1);
                        current = c;
                    }
                    else
                    {
                        charDictionary[c.ToString()]++;
                    }
                }
            }

            return charDictionary;
        }
    }
}
