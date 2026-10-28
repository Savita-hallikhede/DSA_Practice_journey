using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Linked_List.Level_1
{
    internal class Delete
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            list.AddLast(40);
            list.AddLast(50);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            //list.RemoveFirst();
            //list.RemoveLast();

            list.Remove(30);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            list.Clear();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


        }
    }
}
