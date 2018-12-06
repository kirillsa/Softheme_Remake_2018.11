using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    interface IUser
    {
        string Name { get; }
        string Password { get; }
        string Email { get; }
        DateTime Time { get; set; }

        void GetFullInfo();
    }
}
