using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    //Find the first repeated character
    internal class FirstRepeatedCharachter
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
                    Console.WriteLine("First Reapeted charachter is:" + ch);
                    break;
                }
                else
                {
                    ht.Add(ch, 1);
                }
            }


        }
    }
}
