
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level2
{
    internal class FindInterSectionInTwoLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
        }

        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            ListNode a = headA;
            ListNode b = headB;

            while (a != b)
            {
                if (a == null)
                {
                    a = headB;
                }
                else
                {
                    a = a.next;
                }

                if (b == null)
                {
                    b = headA;
                }
                else
                {
                    b = b.next;
                }
            }

            return a;
        }

        public static void Main(string[] args)
        {
            // First Linked List
            ListNode headA = new ListNode();
            headA.val = 10;

            headA.next = new ListNode();
            headA.next.val = 20;

            headA.next.next = new ListNode();
            headA.next.next.val = 30;


            // Second Linked List
            ListNode headB = new ListNode();
            headB.val = 5;

            headB.next = new ListNode();
            headB.next.val = 15;


            // Common Linked List
            ListNode common = new ListNode();
            common.val = 40;

            common.next = new ListNode();
            common.next.val = 50;


            // Connecting both Linked Lists
            headA.next.next.next = common;
            headB.next.next = common;


            ListNode result = GetIntersectionNode(headA, headB);

            if (result != null)
            {
                Console.WriteLine("Intersection point: " + result.val);
            }
            else
            {
                Console.WriteLine("No intersection found");
            }
        }
    }
}
