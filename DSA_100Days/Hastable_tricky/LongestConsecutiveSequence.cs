using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Given an array, find the longest sequence of consecutive numbers.
    internal class LongestConsecutiveSequence
    {
        public static void Main(string[] args)
        {
            int[] arr = { 100, 4, 200, 1, 3, 2 };

            Hashtable ht = new Hashtable();

            foreach (int i in arr)
            {
                ht.Add(i, 1);
            }

            int maxLength = 0;
            int startNumber = 0;


            foreach (int i in arr) //100,4,200,1,3,2
            {
                if (!ht.ContainsKey(i - 1)) //99,3,199,0,2
                {
                    int current = i;//100,200,1
                    int length = 1;//1,1,1

                    while (ht.ContainsKey(current + 1))//101,201,2,2+1=3,3+1=4,4+1=5
                    {
                        current++; //2,3,4
                        length++; //2,3,4
                    }

                    if (length > maxLength)
                    {
                        maxLength = length;
                        startNumber = i;

                    }
                 }
              
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write((startNumber + i) + " ");
            }

            Console.WriteLine();
        }
    }
}

