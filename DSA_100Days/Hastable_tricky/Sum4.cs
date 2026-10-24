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
            int[] arr = {2,-1,0,-2,1,3};
            int target = 2;

            

            for(int i=0; i<arr.Length-3; i++)
            {
                for(int j=i+1; j<arr.Length-2; j++)
                {
                    Hashtable ht = new Hashtable();
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        int needed = target - arr[i] - arr[j] - arr[k];

                        if (ht.ContainsKey(needed))
                        {
                            Console.WriteLine(needed + "," + arr[i] + "," + arr[j] + "," + arr[k] );
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
