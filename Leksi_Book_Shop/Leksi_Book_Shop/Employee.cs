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

        public void Copy(Employee user)
        {
            this.Employee_id = user.Employee_id;
            this.FName = user.FName;
            this.LName = user.LName;
            this.Phone = user.Phone;
            this.Username = user.Username;
            this.Password = user.Password;
        }

    }
}
