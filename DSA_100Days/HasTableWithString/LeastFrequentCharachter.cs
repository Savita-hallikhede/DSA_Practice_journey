using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    //Find the least frequent character
    internal class LeastFrequentCharachter
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
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

            char leastFrequentChar = '0';
            int Frequency = int.MaxValue;

            foreach (DictionaryEntry item in ht)
            {
                if((int)item.Value < Frequency)
                {
                    Frequency = (int)item.Value;
                    leastFrequentChar = (char)item.Key;
                }
            }

            Console.WriteLine("least frequent charechter is : " + leastFrequentChar);
            Console.WriteLine(" Frequency  is : " + Frequency);
        }
    }
}
