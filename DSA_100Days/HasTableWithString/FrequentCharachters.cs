using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    //Find all least frequent characters
    internal class FrequentCharachters
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
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
            int leastFrequency = int.MaxValue;
            char leastFrequentCharachter = '0';

            foreach (DictionaryEntry item in ht)
            {
                if ((int)item.Value < leastFrequency)
                {
                    leastFrequency = (int)item.Value;

                }
            }

            foreach (DictionaryEntry item in ht)
            {
                if ((int)item.Value == leastFrequency)
                {
                    leastFrequentCharachter = (char)item.Key;
                    Console.WriteLine("Least Frequent charachters are:" + leastFrequentCharachter + " " + leastFrequency);
                }
            }

        }
    }
}
