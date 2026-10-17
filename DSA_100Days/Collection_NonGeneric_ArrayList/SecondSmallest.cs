using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    //Find second smallest element
    internal class SecondSmallest
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
        {
            1, 22, 33, 44, 22, 33, 22
        };

            int smallest = int.MaxValue;
            int secsmallest = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                int value = Convert.ToInt32(list[i]);

                if (value < smallest)
                {
                    secsmallest = smallest;
                    smallest = value;
                }
                else if (value > smallest && value < secsmallest)
                {
                    secsmallest = value;
                }
            }

            Console.WriteLine("Smallest: " + smallest);
            Console.WriteLine("Second smallest: " + secsmallest);
        }
    }
}
    

