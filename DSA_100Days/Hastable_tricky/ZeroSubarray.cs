using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    internal class ZeroSubarray
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, -1, -1, 3, -3 };
            Hashtable ht = new Hashtable();
            int sum = 0;
            ht[0] = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
                if (ht.ContainsKey(sum))
                {
                    int start = (int)ht[sum] + 1;
                   
                    Console.WriteLine();
                    for (int j = start; j <= i; j++)
                    {
                        Console.Write(arr[j] + " ");
                    }
                   
                }
                else
                {
                    ht.Add(sum, i);
                }
            }

        }
    }
}
