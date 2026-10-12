using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.DuplicateCharechters
{
    //Write a program to find duplicate characters.
    internal class FindingDuplicate_M2
    {
        
        public static void Main(string[] args)
        {
            string str = "ssaaaut";
            for (int i=0; i<str.Length; i++)
            {
                int count = 0;
                for(int j=0; j<str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                       
                    }
                }

                bool isPrinted  = false;
                for (int k=0; k<i; k++)
                {
                    if(str[i] == str[k])
                    {
                        isPrinted = true;
                        break;
                    }
                }

                if(!isPrinted && count>1)
                {
                    Console.WriteLine("the duplicate charechter is " + str[i]);
                }
            }
        }
    }
}
