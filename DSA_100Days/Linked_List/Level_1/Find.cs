using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level_1
{
    internal class Find
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);
            list.AddLast(20);
            list.AddLast(20);

            //Find the first and last elements of a Linked List.

            Console.WriteLine(list.First.Value);
            Console.WriteLine(list.Last.Value);

            //Find the middle node of a Linked List.

            LinkedListNode<int> current = list.First;
            for(int i=1; i<=list.Count/2; i++)
            {
                current = current.Next;
            }

            Console.WriteLine("Middle node:" + current.Value);

            //Find the Nth node from the beginning
            int n = 4;
            if(n<1 || n>list.Count)
            {
                Console.WriteLine("Invalid position");
            }
            else
            {
                LinkedListNode<int> current1 = list.First;
                for(int i=1; i<n; i++)
                {
                    current1 = current1.Next;

                }

                Console.WriteLine(current1.Value);
            }

            //Count the occurrences of a given value in a Linked List.



            int count = 0;
            int target = 20;
            foreach(int i in list)
            {
                if(i==target)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
           
            Console.WriteLine("Count of " + target + " is: " + count);

        }
    }
}
