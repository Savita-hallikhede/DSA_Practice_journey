using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    internal class WordFrequency
    {
        //Count frequency of each word in a sentence
        public static void Main(string[] args)
        {
            string str = "cat dog cat dog animals dog goat";
            string[] words = str.Split(' ');

            Hashtable ht = new Hashtable();

            foreach (string word in words)
            {
                if (ht.ContainsKey(word))
                {
                    ht[word] = (int)ht[word] + 1;
                }
                else
                {
                    ht.Add(word, 1);
                }
            }

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
