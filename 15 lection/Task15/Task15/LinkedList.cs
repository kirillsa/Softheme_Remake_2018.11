using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    public class LinkedList<T>
    {
        public Item<T> Head { get; private set; }
        public int Amount { get; private set; }

        public void AddFirst(T value)
        {
            if (Head == null)
            {
                var newElement = new Item<T>();
                newElement.Data = value;
                newElement.Previous = null;
                newElement.Next = null;
                Head = newElement;
                Amount = 1;
            }
            else
            {
                var newElement = new Item<T>();
                newElement.Data = value;
                newElement.Previous = null;
                newElement.Next = Head;
                Head.Previous = newElement;
                Head = newElement;
                Amount++;
            }
        }

        public Item<T> FindItem(T value)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void DeleteItem(T value)
        {
            var itemToDelete = FindItem(value);
            if ((itemToDelete != null) && (Amount == 1))
            {
                Head = null;
                Amount--;
            }
            else if ((itemToDelete != null) && (itemToDelete.Previous == null))
            {
                Head = itemToDelete.Next;
                Head.Previous = null;
                Amount--;
            }
            else if ((itemToDelete != null) && (itemToDelete.Next == null))
            {
                var prevItem = itemToDelete.Previous;
                prevItem.Next = null;
                Amount--;
            }
            else if (itemToDelete != null)
            {
                var prevItem = itemToDelete.Previous;
                var nextItem = itemToDelete.Next;
                prevItem.Next = nextItem;
                nextItem.Previous = prevItem;
                Amount--;
            }
        }

        public T[] ToArray()
        {
            var arr = new T[Amount];
            var i = Amount;
            var current = Head;
            while (current != null)
            {
                arr[--i] = current.Data;
                current = current.Next;
            }

            return arr;
        }

        public void ShowList()
        {
            var current = Head;
            while (current != null)
            {
                Console.Write(current.Data.ToString() + ' ');
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}