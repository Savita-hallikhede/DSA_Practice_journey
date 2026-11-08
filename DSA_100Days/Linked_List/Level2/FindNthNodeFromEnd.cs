using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_100Days.Linked_List.Level2
{
    internal class FindNthNodeFromEnd
    {
        //2. Find the Nth node from the end of a Linked List.
        //Two-Pointer Approach to Find the Nth Node from the End of a Linked List.
        //Initialize two pointers(h1, h2) to head.
        //Move h1 by n - 1 nodes.
        //Increment both h1 and h2 until h1.next == null.
        //Return h2.
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

        public static ListNode FindNthFromEnd(ListNode head,int n)
        {
            ListNode first = head;
            ListNode second = head;

            for(int i=0; i<n; i++)
            {
                if(first == null)
                {
                    return null;
                }
                else
                {
                    first = first.next;
                }
                   
            }
          
            while(first != null)
            {
                first = first.next;
                second = second.next;
            }

            return second;
        }

        public static void Main(string[] argse)
        {
            Console.WriteLine("Enter the element:");
            int[] value = System.Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("Enter the n:");
            int n = int.Parse(Console.ReadLine());

            ListNode head = new ListNode(value[0]);
            ListNode temp = head;

            for(int i=1; i<value.Length; i++)
            {
                temp.next = new ListNode(value[i]);
                temp = temp.next;
            }

            ListNode result = FindNthFromEnd(head, n);

            if(result != null)
            {
                Console.WriteLine("The nth node from the end is: " + result.val);
            }
            else
            {
                Console.WriteLine("The list has fewer than n nodes.");
            }


        }
    }
}
