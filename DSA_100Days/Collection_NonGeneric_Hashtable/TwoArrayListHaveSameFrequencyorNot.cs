using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Collection_NonGeneric_Hashtable
{
    //Check whether two arrays have the same frequency of elements
    internal class TwoArrayListHaveSameFrequencyorNot
    {
        public static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList()
            {
                1,2,2,3,3,3
            };
            ArrayList list2 = new ArrayList()
            {
                3,3,3,1,2,2
            };

            Hashtable ht1 = new Hashtable();
            Hashtable ht2 = new Hashtable();

            for(int i=0; i<list1.Count; i++)
            {
                int num1 = (int)list1[i];
                if(ht1.ContainsKey(num1))
                {
                    ht1[num1] = (int)ht1[num1] + 1;
                }
                else
                {
                    ht1.Add(num1, 1);
                }
            }

            for(int j=0; j<list2.Count; j++)
            {
                int num2 = (int)list2[j];
                if(ht2.ContainsKey(num2))
                {
                    ht2[num2] = (int)ht2[num2] + 1;
                }
                else
                {
                    ht2.Add(num2, 1);
                }
            }

            bool sameFrequency = true;
            if(ht1.Count != ht2.Count)
            {
                sameFrequency = false;
            }
            else
            {
                foreach(DictionaryEntry item in ht1)
                {
                    if(!ht2.ContainsKey(item.Key) || (int)ht2[item.Key] != (int)item.Value)
                    {
                        sameFrequency = false;
                        break;
                    }
                }
            }

            if(sameFrequency)
            {
                Console.WriteLine("Both arrays have the same frequency of elements.");
            }
            else
            {
                Console.WriteLine("Both arrays do not have the same frequency of elements.");
            }
        }
    }
}
