using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static int[] GenerateArray(int n)
        {
            var arr = new int[n];
            var rand = new Random();
            var posSingleNum = rand.Next(0, n - 1);
            var currentNum = 0;
            var count = 0;

            for (var i = 0; i < n; i++)
            {
                if (i == posSingleNum)
                {
                    if (count == 0)
                    {
                        Console.WriteLine("Single number is {0}", currentNum);
                        arr[i] = currentNum++;
                        continue;
                    }
                    else
                    {
                        arr[i + 1] = currentNum;
                        arr[i] = ++currentNum;
                        Console.WriteLine("Single number is {0}", currentNum);
                        currentNum++;
                        i++;
                        count = 0;
                        continue;
                    }
                }
                else
                {
                    if (count == 0)
                    {
                        arr[i] = currentNum;
                        count++;
                        continue;
                    }
                    else
                    {
                        arr[i] = currentNum++;
                        count = 0;
                        continue;
                    }
                }
            }
            return arr;
        }

        static void ShowArray(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if ((i % 10 == 0) && (i > 0))
                {
                    Console.WriteLine();
                }
                Console.Write(arr[i].ToString() +' ');
            }
        }

        static int FindSingle(int[] arr)
        {
            for (var i = 0; i < arr.Length-1; i+=2)
            {
                if (arr[i] == arr[i + 1])
                {
                    continue;
                }
                return arr[i] == arr[i + 2] ? arr[i + 1] : arr[i];
            }

            return arr[arr.Length-1];
        }

        static void Main(string[] args)
        {
            var arr = GenerateArray(1001);
            ShowArray(arr);
            Console.WriteLine(FindSingle(arr));
            Console.ReadLine();
        }
    }
}