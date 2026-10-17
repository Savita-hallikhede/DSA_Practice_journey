using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //finding the symmetric difference of two arrays.
    internal class FindSymmetricDiffrence
    {
        public static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList()
            {
                1,2,3,4,5
            };
            ArrayList list2 = new ArrayList()
            {
                1,2,6,7,8
            };

            Hashtable ht = new Hashtable();

            foreach (int i in list1)
            {
                ht[i] = 1;
            }

            foreach (int i in list2)
            {
                if (ht.ContainsKey(i))
                {
                    ht[i] = 2;
                }
                else
                {
                    ht[i] = 1;
                }
            }

            foreach (int item1 in list1)
            {
                if((int)ht[item1] == 1)
                {
                    Console.WriteLine(item1);
                }
            }

            foreach (int item2 in list2)
            {
                if (!list1.Contains(item2))
                {
                    Console.WriteLine(item2);
                }
            }


        }
    }
}
