using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Zero-Sum Pair
    internal class ZeroSum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 7, 11, 15 };
            int target = 0;

            Hashtable ht = new Hashtable();

            foreach (int i in arr)
            {
                int needed = 0 - i;

                if(ht.ContainsKey(needed))
                {
                    Console.WriteLine(needed + " + " + i + " = " + "= 0");
                    break;
                }
                else
                {
                    ht.Add(i, 1);
                }
            }
            
        }
    }
}
