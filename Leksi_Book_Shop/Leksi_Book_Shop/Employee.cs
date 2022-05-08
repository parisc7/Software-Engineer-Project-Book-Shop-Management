/** \file      Employee.cs
*   \brief     Provides the Employee Database
*   \details   This program regards to all the necessary information of Employees
*   \author    SOFTTSING TEAM
*   \version   0.1
*   \date      2022-2022
*   \bug       No bugs Included
*   \copyright SOFTTSING Ltd.
*/

// Packets Used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>Employee</code> is a class that is responsible for
    * the attribute elements that are related to every Employee
    * <BR>
    * @return Returns the filled up elements (attributes) of each Employee in the database through a linked list between forms created, to retrieve and apply changes
    */
    public class Employee
    {
        // Attributes of each employee
        public int Employee_id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Default Constructor 

        /**
        * Function <code>Employee</code> initialises the Employee attributes
        * <BR>
        * @param employee_id  The Employee's unique ID code
        * @param fName        The Employee's First Name
        * @param lName        The Employee's Last Name
        * @param phone        The Employee's Phone
        * @param username     The Employee's Login Username
        * @param password     The Employee's Login Passcode
        */
        public Employee(int employee_id, string fName, string lName, int phone, string username, string password)
        {
            Employee_id= employee_id;
            Firstname = fName;
            Lastname = lName;
            Phone= phone;
            Username= username;
            Password= password;
        }


        // Default
        public Employee() { }

        /**
        * Function <code>Copy</code> copies Employee attributes to current user attributes
        * <BR>
        * @param user Represents every user Employee on the system
        */
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
