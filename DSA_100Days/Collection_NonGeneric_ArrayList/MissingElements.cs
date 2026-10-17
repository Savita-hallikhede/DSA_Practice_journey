using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_ArrayList
{
    internal class MissingElements
    {
        public static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                1,2,3,4,6,7,8
            };

            int actuvalSum = 0;
            for(int i=0; i<list.Count; i++)
            {
                int valuei = Convert.ToInt32(list[i]);
                actuvalSum = actuvalSum + valuei;
            }

            int n = list.Count + 1;
            int exceptedSum = n * (n + 1) / 2;

            int MissingValue = exceptedSum - actuvalSum;
            Console.WriteLine("The Missing Value is : "+ MissingValue);

        }
    }
}
