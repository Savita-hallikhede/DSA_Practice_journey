using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.BasicLevel3
{
    internal class RemoveDuplicateChar1
    {
        public static void Main(string[] args)
        {
            //remove duplicate cahr

            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();


            for (int i = 0; i < name.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (name[i] == name[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(name[i]);
                }
            }

        }
    }
}
