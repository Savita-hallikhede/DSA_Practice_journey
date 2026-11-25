using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level2
{
    internal class RemoveDuplicatesFromLL
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

        public static ListNode RemoveDuplicates(ListNode head)
        {
            ListNode current = head;
           

            while(current!= null)
            {
                ListNode run = current;

                while(run.next != null)
                {
                    if (run.next.val == current.val)
                    {
                        run.next = run.next.next;
                    }
                    else
                    {
                        run = run.next;
                    }
                }
                current = current.next;
            }
            return head;
        }

        public static void Main(string[] args)
        {
            int[] arr = System.Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);


            ListNode head = new ListNode(arr[0]);

            ListNode temp = head;
            for(int i=1; i<arr.Length; i++)
            {
                temp.next = new ListNode(arr[i]);
                temp = temp.next;
            }

            head = RemoveDuplicates(head);

            temp = head;

            while(temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }


        }

    }
}
