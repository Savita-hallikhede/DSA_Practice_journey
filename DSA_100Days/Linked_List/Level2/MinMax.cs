using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level2
{
    internal class MinMax
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

        public static void FindMaxMinValues(ListNode head)
        {
            if(head == null)
            {
                Console.WriteLine("The linked list is empty.");
                return;
            }

            int max = head.val;
            int min = head.val;

            ListNode temp = head;

            while(temp != null)
            {
                if(temp.val > max)
                {
                    max = temp.val;
                }

                if(temp.val < min)
                {
                    min = temp.val;
                }

                temp = temp.next;

            }

            Console.WriteLine("Maximum value :" + max);
            Console.WriteLine("Minimum value :" + min);
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the element:");
            int[] value = System.Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            ListNode head = new ListNode(value[0]);
            ListNode temp = head;

            for(int i=1; i<value.Length; i++)
            {
                temp.next = new ListNode(value[i]);
                temp = temp.next;
            }

            FindMaxMinValues(head);

        }
    }
}
