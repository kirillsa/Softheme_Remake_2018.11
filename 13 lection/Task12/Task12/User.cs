using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class User : IUser
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public DateTime Time { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetPassword(string password)
        {
            Password = password;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public void GetFullInfo()
        {
            Console.WriteLine("User: name: {0}, password: {1}, email: {2}", Name, Password, Email);
        }
    }
}
