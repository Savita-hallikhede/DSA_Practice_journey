using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    internal class OwelsConsonants
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            Hashtable ht = new Hashtable();
            foreach (char ch in str)
            {
                if (ht.ContainsKey(ch))
                {
                    ht[ch] = (int)ht[ch] + 1;
                }
                else
                {
                    ht.Add(ch, 1);
                }
            }

            int vowelsCount = 0;
            int consonantsCount = 0;
            foreach (DictionaryEntry item in ht)
            {
                if ((char)item.Key == 'a' || (char)item.Key == 'e' || (char)item.Key == 'i' || (char)item.Key == 'o' || (char)item.Key == 'u')
                {
                    vowelsCount++;
                }
                else
                {
                    consonantsCount++;
                }
            }
            Console.WriteLine("vowels : " + vowelsCount);
            Console.WriteLine("Consonants : " + consonantsCount);

        }
    }
}
