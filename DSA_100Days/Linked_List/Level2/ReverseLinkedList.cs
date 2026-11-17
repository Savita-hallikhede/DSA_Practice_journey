using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level2
{
    internal class ReverseLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val)
            {
                this.val = val;
                this.next = null;
               
            }

        }

        public class Program
        {
            public static ListNode ReverseList(ListNode head)
            {
                ListNode prev = null;
                ListNode curr = head;

                while (curr != null)
                {
                    ListNode next = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = next;

                }

                return prev;

            }



            public static void Main(string[] args)
            {
                // is a predefined method in C# provided by the System namespace.
                //Its purpose is to convert every element in an array from one type to another type.

                int[] values = System.Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                
                ListNode head = new ListNode(values[0]);

                ListNode temp = head;
                for (int i = 1; i < values.Length; i++)
                {
                    temp.next = new ListNode(values[i]);
                    temp = temp.next;
                }

                head = ReverseList(head);
                Console.WriteLine("Reversed Linked List:");

                temp = head;

                while (temp != null)
                {
                    Console.Write(temp.val + " ");
                    temp = temp.next;
                }





            }
        }
    }
}
