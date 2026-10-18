using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Subarray with Given Sum

    //    11, 12, 13 is both a subarray AND a consecutive sequence.

    //But 12, 13, 20 is a subarray, but not a consecutive sequence.
    //Definition: A subarray is a continuous part of an array, where the elements are next to each other.
    //Definition: A consecutive sequence is a group of numbers where each next number is exactly 1 greater than the previous number.
    internal class SubarrayGivenSum
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 1 };

            Console.WriteLine("Enter the target:");
            int target = 4;
            Hashtable ht = new Hashtable();
            int sum = 0;

            foreach (int i in arr)
            {
                sum = sum + i;
                if(sum == target || ht.ContainsKey(sum-target))
                {
                    Console.WriteLine("Subarray with given sum exists");
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
