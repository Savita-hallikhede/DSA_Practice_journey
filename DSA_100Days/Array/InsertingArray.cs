using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Array
{
    //Insert an element at a specific position
    internal class InsertingArray
    {
        public static void Main(string[] args)
        {
            int[] arr1 = {1,2,3,4,6,7,8,9 };
            int element = 5;
            int position = 4;

            int[] newArray = new int[arr1.Length + 1];

            for(int i=0; i<position; i++)
            {
                newArray[i] = arr1[i]; // 1,2,3,4
            }

            newArray[position] = element;   // 1,2,3,4,5

            for(int i=position; i<arr1.Length; i++)
            {
                newArray[i+1] = arr1[i];

            }

            Console.WriteLine("Successfully inserted the array at correct position");
            for(int i=0; i<newArray.Length; i++)
            {
                Console.Write(newArray[i] +" ");
            }
               
        }
    }
}
