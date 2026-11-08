using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level2
{
    internal class FindDuplicateElement
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

        public static ListNode FindingDuplicate(ListNode head)
        {
            ListNode current = head;

            while (current != null)
            {
                ListNode runner = current;

                while (runner.next != null)
                {
                    if (runner.next.val == current.val)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {
                        runner = runner.next;
                    }
                }

                current = current.next;
            }
            return head;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the numbers:");
            int[] value = System.Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            ListNode head = new ListNode(value[0]);
            ListNode temp = head;

            for (int i = 1; i < value.Length; i++)
            {
                temp.next = new ListNode(value[i]);
                temp = temp.next;
            }

            head = FindingDuplicate(head);
            Console.WriteLine("Linked List after removing duplicates:");

            temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }

            Console.WriteLine("null");
        }
    
    }
}
