using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class MOperator
    {
        MobileAccount[] accounts = new MobileAccount[100];

        public MOperator(params uint[] numbers)
        {
            accounts[0] = new MobileAccount(000);
            int i = 1;
            foreach (var number in numbers)
            {
                if (Verification(number) == 1)
                {
                    accounts[i++] = new MobileAccount(number);
                }
            }
        }

        private int Verification(uint number)
        {
            foreach (var account in accounts)
            {
                if (account.MobileNumber == number)
                    return 0;
            }
            return 1;
        }

        public int Routing(uint senderNumber, uint recieverNumber)
        {
            var verificationResult = Verification(recieverNumber);
            switch (verificationResult)
            {
                case 0:
                {

                    break;
                }
                case 1:
                {
                    return 1;
                }
            }

            return 0;
        }

        //Создайте один мобильный оператор поддерживающий маршрутизацию с многими экземплярами
    }
}
