using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Zero-Sum Subarray
    internal class ZeroSumSubArray
    {
        public static void Main(string[] args)
        {
            int[] arr = { 4, 2, -6, 3, 5 };
            Hashtable ht = new Hashtable();
            int sum = 0;

            foreach (int i in arr)
            {
                sum = sum + i;
                if(sum==0 || ht.ContainsKey(sum))
                {
                    Console.WriteLine("Zero-sum Suarray exists");
                    break;
                }
                else
                {
                    ht.Add(sum, i);
                }
            }
        }
    }
}
