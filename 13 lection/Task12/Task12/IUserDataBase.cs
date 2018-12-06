using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    interface IUserDataBase : IDisposable
    {
        IUser[] GetAllUsers();

        IUser FindUser(String name);

        void AddUser(IUser user);
    }
}
