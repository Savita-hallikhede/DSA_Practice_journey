using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    //Find the most frequent character
    internal class MostFrequentCharacter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            Hashtable ht = new Hashtable(); 

            foreach(char ch in str)
            {
                if(ht.ContainsKey(ch))
                {
                    ht[ch] = (int)ht[ch] + 1;
                }
                else
                {
                    ht.Add(ch, 1);
                }
            }

            char mostFrequentCharechter = '0';
            int mostFrequency = 0;

            foreach (DictionaryEntry item in ht)
            {
                if ((int)item.Value > mostFrequency)
                {
                    mostFrequency = (int)item.Value;
                    mostFrequentCharechter = (char)item.Key;
                }

            }

            Console.WriteLine("Most Frequent Charachter is:" + mostFrequentCharechter);
            Console.WriteLine("frequency is:" + mostFrequency);

        }
    }
}
