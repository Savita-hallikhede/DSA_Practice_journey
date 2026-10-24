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
            int[] arr = {4,-2,1,-3,5};
            int target = 0;

            
            for(int i=0; i<arr.Length; i++)
            {
                Hashtable ht = new Hashtable();

                for (int j = i+1; j < arr.Length; j++)
                {
                    int needed = target - arr[i] - arr[j];  

                    if(ht.ContainsKey(needed))
                    {
                        Console.WriteLine(needed + "," + arr[i] + "," + arr[j]);
                        break;
                    }
                    else
                    {
                        ht.Add(arr[j], 1);//2,1,-1,
                    }
                }
            }
        }
    }
}
