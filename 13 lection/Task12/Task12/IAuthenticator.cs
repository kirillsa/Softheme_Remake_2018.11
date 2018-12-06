using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    interface IAuthenticator
    {
        int AuthenticateUser(IUser user);
    }
}
