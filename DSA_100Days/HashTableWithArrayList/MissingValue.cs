using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.HashTableWithArrayList
{
    //Find the missing element using hashing

    internal class MissingValue
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,3,5,6
            };

            Hashtable ht = new Hashtable();

            foreach (int i in list)
            {
                ht[i] = true;
            }

            for(int i=0; i<=list.Count; i++)
            {
                if (!ht.Contains(i))
                {
                    Console.WriteLine("Missing Element:" + i);
                    break;
                }
            }
        }
    }
}
