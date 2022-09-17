using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization.Model
{
    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int BordDate { get; set; }
        public decimal Salary { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User()
        {
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            BordDate = int.MaxValue;
            Salary = decimal.MinValue;
            Login = string.Empty;
            Password = string.Empty;
            Role = Role.Unknown;
        }

        public User(string firstName, string middleName, string lastName, int borddate, decimal salary)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            BordDate = borddate;
            Salary = salary;
            

        }
        public override string ToString()
        {
            return $"ФИО: {FirstName} {MiddleName} {LastName}\nДата рождения: {BordDate}\n" + $"Зарплата:{Salary}";
        }
    }

}
