using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Equal Positive and Negative Elements
    internal class EqualPositiveNegative
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, -2, 3, -4, 5 };

            Hashtable ht = new Hashtable();

            int sum = 0;

            foreach (int i in arr)
            {
                if (i > 0)
                {
                    sum = sum + 1;
                }
                else if (i < 0) 
                {
                    sum = sum - 1;
                }

                if (sum == 0 || ht.ContainsKey(sum))
                {
                    Console.WriteLine("Equal Positive and Negative Subarray exists");
                    break;
                }
                else
                {
                    ht.Add(sum, 1);
                }
            }
        }
    }
}
