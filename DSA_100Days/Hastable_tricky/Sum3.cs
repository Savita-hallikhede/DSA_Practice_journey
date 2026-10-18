using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //3Sum
    internal class Sum3
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, -3, 4, 5 };
            int target = 0;

            Hashtable ht = new Hashtable();
            for(int i=0; i<arr.Length; i++)
            {

                for (int j = i+1; j < arr.Length; j++)
                {
                    int needed = target - arr[i] - arr[j];  

                    if(ht.ContainsKey(needed))
                    {
                        Console.WriteLine(needed + "+" + arr[i] + "+" + arr[j] + "=" + target);
                        break;
                    }
                    else
                    {
                        ht.Add(arr[j], 1);
                    }
                }
            }
        }
    }
}
