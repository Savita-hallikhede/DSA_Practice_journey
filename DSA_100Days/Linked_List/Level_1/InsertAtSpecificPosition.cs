using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level_1
{
    internal class InsertAtSpecificPosition
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);

            LinkedListNode<int> current1 = list.First;
            LinkedListNode<int> last = list.Last;

            Console.WriteLine(current1.Value);
            Console.WriteLine(last.Value);

            int position = 3;
            int value = 25;

            LinkedListNode<int> current = list.First;

            for(int i=1; i<position-1; i++)
            {
                current = current.Next;
            }

            list.AddAfter(current, value);
            //The important point is that AddAfter() receives the node referenced by current.

            foreach(int item in list)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
