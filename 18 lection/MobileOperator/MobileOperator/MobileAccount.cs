using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileOperator
{
    class MobileAccount
    {
        public uint MobileNumber { get; private set; }

        public MobileAccount(uint number)
        {
            MobileNumber = number;
        }

        public void CallOut(uint number)
        {
            //();
        }



        //Каждый MobileAccount имеет свой уникальный номер и методы по отправке смс и совершении звонка на любой другой номер
    }
}
