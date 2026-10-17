using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    
    internal class CheckSorted
    {
        public static void Main(string[] args)
        {
            

            ArrayList list = new ArrayList()
            {
                2,3,4,5,6
            };

            bool isArrayListSorted = true;

            for(int i=0; i < list.Count-1; i++)
            {
                int current = Convert.ToInt32(list[i]);
                int next = Convert.ToInt32(list[i+1]);

                if(current > next)
                {
                    isArrayListSorted = false;
                }
            }

            if(isArrayListSorted)
            {
                Console.WriteLine("ArrayList is sorteed");
            }
            else
            {
                Console.WriteLine("ArrayList is not sorteed");
            }
        }
    }
}
