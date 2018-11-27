using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class ArrayClass
    {
        private int[] Arr;

        public ArrayClass(int n)
        {
            Arr = new int[n];
            var rand = new Random();
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = rand.Next(0, 10);
            }
        }

        public int? this[int i]
        {
            get
            {
                if (i < Arr.Length)
                {
                    return Arr[i];
                }

                return null;
            }
        }

        public void Add(params int[] arr)
        {
            var newArray = new int[Arr.Length+arr.Length];
            for (var i = 0; i < Arr.Length; i++)
            {
                newArray[i] = Arr[i];
            }
            for (var i = 0; i < arr.Length; i++)
            {
                newArray[i+Arr.Length] = arr[i];
            }

            Arr = newArray;
        }

        public bool Contains(int number)
        {
            for (var i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == number)
                { 
                    return true;
                }
            }

            return false;
        }

        public void ShowArray()
        {
            foreach (var num in Arr)
            {
                Console.Write(num.ToString()+ ' ');
            }
            Console.WriteLine();
        }
    }
}
