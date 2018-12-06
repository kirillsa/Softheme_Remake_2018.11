using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Authenticator : IAuthenticator, IUserDataBase
    {
        IUser[] users;

        public Authenticator(int n)
        {
            users = new User[n];
        }

        public IUser[] GetAllUsers()
        {
            return users;
        }

        public IUser FindUser(String name)
        {
            foreach (var user in users)
            {
                if (user == null)
                {
                    return null;
                }

                if (((user.Name != null) && (user.Name == name)) || ((user.Email != null) && (user.Email == name)))
                {
                    return user;
                }
            }
            return null;
        }

        public void AddUser(IUser user)
        {
            for (var i = 0; i < users.Length; i++)
            {
                if (users[i] == null)
                {
                    user.Time = DateTime.Now;
                    users[i] = (User)user;
                    break;
                }
            }
            // array overflow
        }

        public int AuthenticateUser(IUser user)
        {
            var foundUser = user.Name == null ? FindUser(user.Email) : FindUser(user.Name);
            if (foundUser != null)
            {
                if (foundUser.Password == user.Password)
                {
                    Console.WriteLine("Last time logged in{0}", foundUser.Time);
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            AddUser(user);
            return 0;
        }

        public void ShowUsers()
        {
            foreach (var user in users)
            {
                if (user == null)
                {
                    break;
                }
                user.GetFullInfo();
            }
        }

        public void Dispose()
        {
            foreach (var user in users)
            {
                if (user == null)
                {
                    break;
                }
                user.GetFullInfo();
            }
            Console.WriteLine("Dispose");
            Console.ReadLine();
        }
    }
}