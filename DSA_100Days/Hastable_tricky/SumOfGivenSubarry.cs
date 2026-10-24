using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    internal class SumOfGivenSubarry
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 4, -2, 5, 1 };
            int target = 7;
            Hashtable ht = new Hashtable();
            int sum = 0;
            ht[0] = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                int needed = sum - target;
                if (ht.ContainsKey(needed))
                {
                    int start = (int)ht[needed] + 1;
                    Console.WriteLine();
                    for (int j = start; j <= i; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }
                }
                if (!ht.ContainsKey(sum))
                {
                    ht.Add(sum, i);
                }
            }
        }
    }
}
