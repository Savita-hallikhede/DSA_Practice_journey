using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HasTableWithString
{
    //Count consonants using Hashtable
    internal class FindConstant
    {
        //Count consonants using Hashtable
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            Hashtable ht = new Hashtable();

            foreach(char ch in str)
            {
                if(ch!='a' && ch!='e'&& ch!='i' && ch!='o' && ch!='u')
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
            }

            foreach(DictionaryEntry item in  ht)
            {
                Console.WriteLine(item);
            }
        }
    }
}
