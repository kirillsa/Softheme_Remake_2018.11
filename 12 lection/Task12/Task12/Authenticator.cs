using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Authenticator : IAuthenticator
    {
        User[] users;

        public Authenticator(int n)
        {
            users = new User[n];
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
            foreach (var existUser in users)
            {
                if (existUser == null)
                {
                    break;
                }

                if (((existUser.Name == user.Name)&&(user.Name != null)) || ((existUser.Email == user.Email) && (user.Email != null)))
                {
                    if (existUser.Password == user.Password)
                    {
                        Console.WriteLine("Last time logged in{0}",existUser.Time);
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
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
    }
}