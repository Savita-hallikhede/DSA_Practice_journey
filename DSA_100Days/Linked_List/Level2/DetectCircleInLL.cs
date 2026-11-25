using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level2
{
    internal class DetectCircleInLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

        }

        public static void DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if(slow == fast)
                {
                    Console.WriteLine("Cycle is present in Linked List");
                    break;
                }
            }

        }
        public static void Main(String[] args)
        {

            ListNode head = new ListNode();
            head.val = 3;

            head.next = new ListNode();
            head.next.val = 2;

            head.next.next = new ListNode();
            head.next.next.val = 0;

            head.next.next.next = new ListNode();
            head.next.next.next.val = 4;

            head.next.next.next.next = new ListNode();
            head.next.next.next.next = head.next;



           DetectCycle(head);
        }
    }
}
