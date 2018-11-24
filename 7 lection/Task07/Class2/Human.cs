using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Human
    {
        public DateTime BirthDate { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; }

        public Human ( string date, string firstName, string lastName)
        {
            BirthDate = DateTime.Parse(date);
            FirstName = firstName;
            LastName = lastName;
            Age = DateTime.Today.Year - DateTime.Parse(date).Year;
        }

        public bool Compare(Human human)
        {
            return (this.FirstName == human.FirstName) && (this.LastName == human.LastName) && (this.Age == human.Age);
        }
    }
}
