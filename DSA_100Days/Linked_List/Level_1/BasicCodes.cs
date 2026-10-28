using DSA_100Days.Collection_Genericollection_Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DSA_100Days.Linked_List.Level_1
{
    internal class BasicCodes
    {
        public static void Main(string[] args)
        {
            //Create a Linked List and add elements 10, 20, 30, 40, 50.
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);

            //Print all elements of a Linked List using foreach.
            foreach(int item in list)
            {
                Console.WriteLine(item + " ");
            }

            //Count the total number of nodes in a Linked List.
            Console.WriteLine(list.Count);

            //Search for a given element in a Linked List.
            foreach (int i in list)
            {
                if(i==30)
                {
                    Console.WriteLine(i);
                }
            }

            //Insert a node at the beginning of a Linked List.

            list.AddFirst(0);
            foreach (int item in list)
            {
                Console.WriteLine(item + " ");
            }

           

        }
    }
}
