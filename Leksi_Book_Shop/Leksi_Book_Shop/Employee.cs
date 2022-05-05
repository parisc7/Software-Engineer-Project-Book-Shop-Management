using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    internal class Employee
    {
        public int Employee_id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Employee(int employee_id, string fName, string lName, int phone, string username, string password)
        {
            Employee_id= employee_id;
            FName= fName;
            LName= lName;
            Phone= phone;
            Username= username;
            Password= password;
        }

        public Employee() { }

    }
}
