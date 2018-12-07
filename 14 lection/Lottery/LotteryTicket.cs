using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class LotteryTicket
    {
        private int[] ticket;

        public LotteryTicket()
        {
            ticket = new int[6];
        }

        public int this[int i]
        {
            get { return ticket[i]; }
            private set { ticket[i] = value; }
        }

        public void InputTicketNumbers()
        {
            int bufNumber = 0;
            for (int i = 0; i < ticket.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Please enter {i + 1} number. It should be between 1 and 9");
                    int.TryParse(Console.ReadLine(), out bufNumber);
                } while (bufNumber < 1 || bufNumber > 9);

                this[i] = bufNumber;
            }
        }

        private int[] Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var buf = arr[i];
                        arr[i] = arr[j];
                        arr[j] = buf;
                    }
                }
            }
            return arr;
        }

        public bool Compare(int[] arr)
        {
            ticket = Sort(ticket);
            arr = Sort(arr);
            for (int i = 0; i < ticket.Length; i++)
            {
                if (ticket[i] != arr[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
