using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HashTableWithArrayList
{
    //Find the union of two arrays using Hashtable
    internal class Union
    {
        public static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList()
            {
                1,2,3,4,5,6
            };
            ArrayList arr2 = new ArrayList()
            {
                4,5,6,7,8,9
            };

            Hashtable ht = new Hashtable();
            foreach (int i in arr1)
            {
                ht.Add(i, 1);
            }
            foreach (int i in arr2)
            {
                if(!ht.ContainsKey(i) )
                {

                    ht.Add(i, 1);
                }
              
            }

            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

        }
    }
}
