using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level2
{
    internal class RemoveNthNodeFromEnd_M1
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

        public static ListNode RemoveNthFromEnd(ListNode head , int n)
        {
            ListNode First = head;
            ListNode Second = head;

            for(int i=0; i<n; i++)
            {
                First = First.next;
            }

            if(First==null)
            {
                return head.next;
            }

            while(First.next!=null)
            {
                First = First.next;
                Second = Second.next;
            }

            ListNode deleteNode = Second.next;
            Second.next = Second.next.next;
            return head;


        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements entered in the linked list");
            int[] arr = System.Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("Enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());

            ListNode head = new ListNode(arr[0]);

            ListNode temp = head;
            for(int i=1; i<arr.Length; i++)
            {
                temp.next = new ListNode(arr[i]);
                temp = temp.next;
            }

            head = RemoveNthFromEnd(head, n);

            temp = head;
            while(temp!=null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }

        }
        

            
            

    }
}
