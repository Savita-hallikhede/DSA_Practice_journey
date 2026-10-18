using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    //Find the first non-repeated character
    internal class FirstNonRepeatedChar
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
                    ht[ch] = (int)ht[ch]+1;
                }
                else
                {
                    ht.Add(ch, 1);
                }
            }

            foreach (DictionaryEntry item in ht)
            {
                if((int)item.Value == 1)
                {
                    Console.WriteLine("First Non-repeated item is:" + item);
                }
            }


        }
    }
}
