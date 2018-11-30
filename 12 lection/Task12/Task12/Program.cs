using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            var auth = new Authenticator(10);
            do
            {
                var user = new User();
                Console.WriteLine("Enter your login or email");
                var login = Console.ReadLine();
                if (login == null)
                {
                    Console.WriteLine("Wrong login");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Enter password");
                var password = Console.ReadLine();
                if ((login == "exit") && (password == "exit"))
                {
                    break;
                }
                if (login.Contains('@'))
                {
                    user.SetEmail(login);
                }
                else
                {
                    user.SetName(login);
                }
                user.SetPassword(password);
                var authResult = auth.AuthenticateUser(user);
                if ( authResult == 1)
                {
                    Console.WriteLine("User authentication passed");
                }
                else if (authResult == -1)
                {
                    Console.WriteLine("Wrong password");
                }
                else if (authResult == 0)
                {
                    Console.WriteLine("Added new user");
                }
            }
            while (true);

            auth.ShowUsers();
            Console.ReadLine();
        }
    }
}