using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //4Sum
    internal class Sum4
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 10;

            Hashtable ht = new Hashtable();

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        int needed = arr[i] - arr[j] - target;

                        if (ht.ContainsKey(needed))
                        {
                            Console.WriteLine(needed + "+" + arr[i] + "+" + arr[j] + "+" + arr[k] + "=" + needed);
                        }
                        else
                        {
                            ht.Add(arr[k], 1);
                        }
                    }
                }
            }
        }
    }
}
