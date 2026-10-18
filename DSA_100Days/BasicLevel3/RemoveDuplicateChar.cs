using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.BasicLevel3
{
    internal class RemoveDuplicateChar
    {
        //Write a program to remove duplicate characters.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                bool isDuplicate = false;
                
                for (int j=0; j<result.Length; j++)
                {
                    if (str[i] == result[j] )
                    {
                        isDuplicate = true;
                        break;
                    }
                   
                }

                if(!isDuplicate)
                {
                   result = result+ str[i];
                }
            }

            Console.WriteLine($"The string after removing duplicate characters is: {result}");
        }
    }
}
