using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    public class Employee
    {
        public int Employee_id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Employee(int employee_id, string fName, string lName, int phone, string username, string password)
        {
            Employee_id= employee_id;
            Firstname = fName;
            Lastname = lName;
            Phone= phone;
            Username= username;
            Password= password;
        }

        public Employee() { }

        public void Copy(Employee user)
        {
            this.Employee_id = user.Employee_id;
            this.Firstname = user.Firstname;
            this.Lastname = user.Lastname;
            this.Phone = user.Phone;
            this.Username = user.Username;
            this.Password = user.Password;
        }

    }
}
