using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    internal class Anagram
    {
        public static void Main(string[] args)
        {
            string str1 = "listen";
            string str2 = "silent";

            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();



            foreach (char ch in str1)
            {
                if (ht1.ContainsKey(ch))
                {
                    ht1[ch] = (int)ht1[ch] + 1;
                }
                else
                {
                    ht1.Add(ch, 1);
                }
            }

            foreach (char ch in str2)
            {
                if (ht2.ContainsKey(ch))
                {
                    ht2[ch] = (int)ht2[ch] + 1;
                }
                else
                {
                    ht2.Add(ch, 1);
                }
            }

            bool isAnagram = true;
            if (ht1.Count != ht2.Count)
            {
                isAnagram = false;
            }
            else
            {
                foreach (DictionaryEntry item in ht1)
                {
                    if (!ht2.ContainsKey(item.Key) || (int)ht2[item.Key] != (int)item.Value)
                    {
                        isAnagram = false;
                        break;
                    }
                }
            }

            if (isAnagram)
            {
                Console.WriteLine(str1 + " and " + str2 + " are anagrams.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not anagrams.");

            }
        }
    }
}
