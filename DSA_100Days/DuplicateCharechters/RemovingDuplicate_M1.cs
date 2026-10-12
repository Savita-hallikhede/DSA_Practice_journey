using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.DuplicateCharechters
{
    //Write a program to remove duplicate characters.
    internal class RemovingDuplicate_M1
    {
        public static void Main(string[] args)
        {
            string name = "ssaaaut";
            string result = "";
            for(int i=0; i<name.Length; i++)
            {
                bool isDuplicate = false;
                for (int j=0; j<name.Length; j++)
                {
                    if(i!=j && name[i] == name[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if(!isDuplicate && !result.Contains(name[i]))
                {
                    result = result + name[i];
                }
            }

            Console.WriteLine("The string after removing duplicate charecters is: " + result);
        }
    }
}
