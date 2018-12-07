using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static int[] RandomTicket(int n)
        {
            var random = new Random();
            var arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 10);
            }

            return arr;
        }

        static void Main(string[] args)
        {
            var lotteryTicket = new LotteryTicket();
            var randomTicket = RandomTicket(6);
            Console.WriteLine("This is a lottery. \nYou have to write down 6 numbers between 1 and 9\nTo continue press Enter");
            Console.ReadLine();
            Console.Clear();
            lotteryTicket.InputTicketNumbers();
            if (lotteryTicket.Compare(randomTicket))
            {
                Console.WriteLine("You guess all numbers");
            }
            else
            {
                Console.WriteLine("You lost");
            }
            Console.WriteLine("Your ticket    Winner ticket");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(lotteryTicket[i] + "              " + randomTicket[i]);
            }

            Console.ReadLine();
        }
    }
}
