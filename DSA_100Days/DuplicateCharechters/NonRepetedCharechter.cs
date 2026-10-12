using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.DuplicateCharechters
{
    //Write a program to find the first non-repeated character.

    internal class NonRepetedCharechter
    {
       
        public static void Main(string[] args)
        {
            string str = "ssaaaut";
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;

                    }
                }
                if (count == 1)
                {
                    Console.WriteLine("the first non-repeated charechter is " + str[i]);
                    break;

                }
            }
        }
    }
}
