
using System;
using System.Collections.Generic;

namespace DSA_100Days.Linked_List.Level2
{
    // Remove the Nth node from the end of a Linked List.

    internal class RemoveNthNodeFromEnd
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

        public static ListNode RemoveNthNodeFromEndMethod(ListNode head, int n)
        {
            // Step 1: Check invalid input
            if (head == null || n <= 0)
            {
                return head;
            }

            // Step 2: Calculate length
            int Length = 0;
            ListNode temp = head;

            while (temp != null)
            {
                Length++;
                temp = temp.next;
            }

            // Step 3: Check whether n is valid
            if (n > Length)
            {
                return head;
            }

            // Step 4: Create dummy node
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            // Step 5: Find the previous node
            temp = dummy;

            for (int i = 0; i < Length - n; i++)
            {
                temp = temp.next;
            }

            // Step 6: Remove the Nth node
            temp.next = temp.next.next;

            // Step 7: Return updated head
            return dummy.next;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements:");

            int[] arr = System.Array.ConvertAll(
                Console.ReadLine().Split(' '), int.Parse);

            // Create linked list
            ListNode head = new ListNode(arr[0]);

            ListNode temp = head;

            for (int i = 1; i < arr.Length; i++)
            {
                temp.next = new ListNode(arr[i]);
                temp = temp.next;
            }

            Console.WriteLine("Enter the value of n:");

            int n = Convert.ToInt32(Console.ReadLine());

            // Get updated linked list
            ListNode newHead = RemoveNthNodeFromEndMethod(head, n);

            Console.WriteLine("Updated Linked List:");

            // Display updated linked list
            temp = newHead;

            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
}
