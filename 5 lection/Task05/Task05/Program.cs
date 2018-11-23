using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitFlag = false;
            do
            {
                var inputChoise = "";
                Console.Clear();
                Console.WriteLine("Make your choise:");
                Console.WriteLine("T for triangle, S for square, R for romb");
                Console.WriteLine("Q for exit");
                try
                {
                    inputChoise = Console.ReadLine();
                    switch (inputChoise)
                    {
                        case "Q":
                        case "q":
                        {
                            exitFlag = true;
                            continue;
                        }
                        case "T":
                        case "t":
                            Triangle();
                            continue;
                        case "S":
                        case "s":
                            Square();
                            continue;
                        case "R":
                        case "r":
                            Romb();
                            continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!exitFlag);
        }

        static void Triangle()
        {
            var size = Size();
            var fig = "";
            for (var i = 0; i < size; i++)
            {
                Console.WriteLine(fig += "* ");
            }
            Pause();
        }

        static void Square()
        {
            var size = Size();
            var fig = String.Concat(Enumerable.Repeat("* ", size));
            for (var i = 0; i < size; i++)
            {
                Console.WriteLine(fig);
            }
            Pause();
        }

        static void Romb()
        {
            var size = Size();
            var midSize = size / 2;
            if (size % 2 == 1)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i <= midSize)
                        {
                            if (j < (midSize - i) || (midSize + i) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                        else
                        {
                            if (j < (midSize + i - size + 1) || (midSize - i + size - 1) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                    }
                    Console.Write("\n");
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (i <= midSize)
                        {
                            if (j < (midSize - i - 1) || (midSize + i) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                        else
                        {
                            if (j < (midSize + i - size) || (midSize - i + size - 1) < j)
                            {
                                Console.Write("  ");
                            }
                            else
                                Console.Write("* ");
                        }
                    }
                    Console.Write("\n");
                }
            }
            Pause();
        }

        static int Size()
        {
            var size = 0;
            do
            {
                Console.WriteLine("Enter the size of the figure (1 to 10):");
                int.TryParse(Console.ReadLine(), out size);
            } while (size == 0);
            return size;
        }

        static void Pause()
        {
            Console.Write("Press enter");
            Console.ReadLine();
        }
    }
}
