using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.BasicLevel3
{
    internal class FindDuplicateChar
    {
        //Write a program to find duplicate characters.

        public static void Main(string[] args)
        {
            string str = "ssaaaut";

            string result = ""; 
            for (int i=0; i<str.Length; i++)
            {
                bool isDuplicate = false;

                for(int j=0; j<result.Length; j++)
                {
                    if(str[i] == result[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if(isDuplicate)
                {
                    Console.WriteLine($"The duplicate character is: {str[i]}"); 
                }
                else
                {
                    result = result + str[i];
                }   
            }


        }

    }
}
