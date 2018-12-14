using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(4);
            stack.Pop();
            stack.Peek();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.ShowStack();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.ShowStack();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.ShowStack();

            Console.ReadLine();
        }
    }
}
