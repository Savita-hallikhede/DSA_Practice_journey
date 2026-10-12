using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.DuplicateCharechters
{
    internal class RemovingDuplicate_M2
    {
        public static void Main(string[] args)
        {
            //Write a program to remove duplicate characters.
            string name = "ssaaaut";
            
            for(int i=0; i<name.Length; i++)
            {
                int count = 0;
                for(int j=0; j<name.Length; j++)
                {
                    if(name[i] == name[j])
                    {
                        count++;
                       
                    }
                }
                bool isPrinted = false;
                for(int k=0; k<i; k++)
                {
                    if(name[i] == name[k])
                    {
                        isPrinted = true;
                        break;
                    }
                }

                if(!isPrinted && count==1)
                {
                    Console.Write(name[i]);
                }   
            }

        }
        

    }
}
