using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Two Sum — find two elements whose sum equals target

    internal class ToSum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 7, 11, 15 };
            int target = 9;

            Hashtable ht = new Hashtable();

            foreach(int i in arr)
            {
                int needed = target - i;
                if (ht.Contains(needed))
                {
                    Console.WriteLine(needed + "+" + i + "=" + target);
                }
                else
                {
                    ht.Add(i,1);
                }
            }
        }
    }
}
