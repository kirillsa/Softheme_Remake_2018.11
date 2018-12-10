using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(1);
            list.AddFirst(8);
            list.AddFirst(6);
            Console.WriteLine("Amount of elements in Linked list is {0}",list.Amount);
            Console.WriteLine("Elements in list:");
            list.ShowList();
            list.DeleteItem(6);
            Console.WriteLine("List with deleted element 6");
            list.ShowList();
            var arr = list.ToArray();
            Console.WriteLine("Elements in list as an array");
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.ReadLine();
        }
    }
}