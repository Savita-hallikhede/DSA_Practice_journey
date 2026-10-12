using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.DuplicateCharechters
{
    //Write a program to find duplicate characters.

    internal class FindingDuplicate_M1
    {
        public static void Main(string[] args)
        {
            string name = "ssaaaut";
            string result = "";
            for (int i = 0; i < name.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < name.Length; j++)
                {
                    if (i != j && name[i] == name[j])
                    {

                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate && !result.Contains(name[i]))
                {
                    result = result + name[i];
                }
            }

            Console.WriteLine("The duplicate charechter is:"+ result);
        }
    }

}

      
    

