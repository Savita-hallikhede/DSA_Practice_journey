using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Equal 0s and 1s
    internal class EqualZerosAndOnes
    {
        public static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 1, 1, 0 };

            Hashtable ht = new Hashtable();

            int sum = 0;
            int maxLength = 0;

            // Sum 0 first is stored at index -1
            ht[0] = -1;
            for(int i=0; i<arr.Length; i++) // 0,1,0,1
            {
                // Treat 0 as -1 and 1 as +1
                if(arr[i] == 0) 
                {
                    sum = sum - 1; // -1,0,-1,-1
                }
                else
                {
                    sum = sum + 1;
                }

                if(ht.ContainsKey(sum))
                {
                    int previousIndex = (int)ht[sum];//-1,0

                    int length = i-previousIndex;//2,2

                    if(length > maxLength)
                    {
                        maxLength = length;//2,2
                    }
                }
                else
                {
                    ht.Add(sum, i); // -1,0 
                }
            }
            Console.WriteLine("Longest subarray Length:" + maxLength); 
        }
    }
}
