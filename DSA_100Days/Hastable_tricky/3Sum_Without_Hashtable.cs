using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    internal class _3Sum_Without_Hashtable
    {
        public static void Main(string[] args)
        {
            int[] arr = { -1, 0, 1, 2, -1, -4 };
            int target = 0;

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    for(int k=j+1; k<arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == target)
                        {
                            Console.WriteLine(arr[i] + "+" + arr[j] + "+" + arr[k] + "=" + target);
                        }
                    }
                }
            }
        }
    }
}
