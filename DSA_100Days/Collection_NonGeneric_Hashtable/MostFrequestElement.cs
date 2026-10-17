using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Find the most frequent element
    internal class MostFrequestElement
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                66,66,65,65,65,7,7,7,7
            };

            Hashtable ht =  new Hashtable();

            for(int i=0; i<list.Count; i++)
            {
                if(ht.ContainsKey(list[i]))
                {
                    ht[list[i]] = (int)ht[list[i]]+1;
                }
                else
                {
                    ht.Add(list[i], 1);
                }
            }

            int MostFrequency = 0;//value
            int MostFrequentElement = 0;//key

           //foreach(var i in ht.Keys)
           //{
           //     Console.Write(i);
           //}
           // foreach (var i in ht.Values)
           // {
           //     Console.Write(i);
           // }

            foreach(DictionaryEntry item in  ht)
            {
                if((int)item.Value > MostFrequency)
                {
                    MostFrequency = (int)item.Value;
                    MostFrequentElement = (int)item.Key;
                }
            }

            Console.WriteLine($"Highest frequency of the element is = {MostFrequentElement} and their frequency is = {MostFrequency}");
        }
    }
}
