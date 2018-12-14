using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Stack <T>
    {
        private T[] arr;
        private int current;

        public Stack (int size)
        {
            arr = new T[size];
            current = -1;
        }

        public void Push (T value)
        {
            if (current == arr.Length-1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }

            arr[++current] = value;
        }

        public T Pop()
        {
            if (current == -1)
            {
                Console.WriteLine("Stack is empty. First Push something");
                return arr[0];
            }
            else
            {
                return arr[current--];
            }
        }

        public T Peek()
        {
            if (current == -1)
            {
                Console.WriteLine("Stack is empty. First Push something");
                return arr[0];
            }

            return arr[current];
        }

        public void ShowStack()
        {
            if (current == -1)
            {
                Console.WriteLine("Stack is empty. First Push something");
                return;
            }
            else
            {
                for (var i = 0; i <= current; i++)
                {
                    Console.Write(arr[i].ToString() + ' ');
                }
                Console.WriteLine();
            }
        }
    }
}
