
using System;
using System.Collections.Generic;

namespace DSA_100Days.Linked_List.Level2
{
    internal class RemoveNthNodeFromEnd_M2
    {
        public static LinkedList<int> RemoveNthNodeFromEnd(
            LinkedList<int> list, int n)
        {
            int count = list.Count;

            if (n <= 0 || n > count)
            {
                Console.WriteLine("Invalid value of n");
                return list;
            }

            if (count == n)
            {
                list.RemoveFirst();
                return list;
            }

            int position = count - n;

            LinkedListNode<int> temp = list.First;

            // Find the previous node
            for (int i = 1; i < position; i++)
            {
                temp = temp.Next;
            }

            list.Remove(temp.Next);

            return list;
        }

        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);

            int n = 3;

            RemoveNthNodeFromEnd(list, n);

            foreach (int value in list)
            {
                Console.Write(value + " ");
            }
        }
    }
}
