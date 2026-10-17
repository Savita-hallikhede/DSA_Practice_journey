using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    internal class CountFrequency
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,2,3,1,2,4
            };

            Hashtable ht = new Hashtable();//(1,2) (2,3) (3,1) (4,1)

            foreach (int num in list)
            {
                if(ht.ContainsKey(num))
                {
                    ht[num] = (int)ht[num] + 1;
                    // ht[2] = ht[2] + 1;
                    //ht[2] = 1
                }
                else
                {
                    ht.Add(num, 1);
                }
            }
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
           
           
           
        }
        
    }
}
