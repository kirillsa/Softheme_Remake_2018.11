using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static  int[] GenerateArray(int n)
        {
            var rand = new Random();
            var arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(0, n - 1);
            }

            return arr;
        }

        static void ShowArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + ' ');
            }
            Console.WriteLine();
        }

        static void SortArray(int[] arr)
        {
            for (var i = 0; i < arr.Length-1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var arr = GenerateArray(10);
            ShowArray(arr);
            SortArray(arr);
            ShowArray(arr);

            Console.ReadLine();
        }
    }
}
