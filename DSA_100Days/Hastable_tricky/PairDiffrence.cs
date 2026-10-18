using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Hastable_tricky
{
    //Pair with Given Difference
    internal class PairDiffrence
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 7, 11, 15 };
            int Diffrence = 5;

            Hashtable ht = new Hashtable();

            foreach(int i in arr)
            {
                int needed = i-Diffrence;

                if(ht.ContainsKey(needed))
                {
                    Console.WriteLine( i + "-" +needed +"="+ Diffrence);
                    break;
                }
                else
                {
                    ht.Add(i, 1);
                }
            }

            //foreach(DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}
         
        }
    }
} 
