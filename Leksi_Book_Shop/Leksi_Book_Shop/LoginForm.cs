/** \file      LoginForm.cs
*   \brief     Provides the Log In info
*   \details   This program regards to all the necessary functionalities
*   \author    SOFTTSING TEAM
*   \version   0.2
*   \date      2022-2022
*   \bug       No bugs Included
*   \copyright SOFTTSING Ltd.
*/

// Packets Used
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>LoginForm</code> is a class that is responsible for
    * the form's functionalities that are related to the log in
    * <BR>
    * @return Returns the successful or NOT log in
    */
    public partial class LoginForm : Form
    {
        EmployeesForm employees= new EmployeesForm();
        Employee admin = new Employee(0, null, null, 0, "admin", "admin");
        MainForm main;

        // Default Constructor 

        /**
        * Function <code>LoginForm</code> initialises the components and runs the corresponding employee's database to acquire data
        * <BR>
        */
        public LoginForm()
        {
            InitializeComponent();
            employees.Show();
            employees.Hide();
        }

        /**
        * Function <code>loginButton_Click</code> shows presence of admin or employee
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool Admin=true;
            Employee current = new Employee();
            bool exist = false;

            // Indicating person is an Admin 
            if (usernameTxt.Text == admin.Username)
            {
                if (passwordTxt.Text == admin.Password)
                {
                    current.Copy(admin);
                    Admin = true;
                    exist = true;
                }
            }

            // Indicating person is an Employee 
            else
            {
                foreach (var employee in employees.EmployeesList)
                {
                    // if username and password matches with the ones in the database, then proceed
                    if (employee.Username == usernameTxt.Text)
                    {
                        if (employee.Password == passwordTxt.Text)
                        {
                            current.Copy(employee);
                            Admin = false;
                            exist = true;
                            break;
                        }
                    }

                    // in case of not matching
                    else
                    {
                        exist = false;
                    }
                }
            }          
            
            // Privileges when 'exist' holds true
            if (exist)
            {
                this.Hide();
                main = new MainForm(Admin,current);
                main.ShowDialog();
                this.Close();
            }

            // Error Message when invalid credentials
            else
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Clear();
                passwordTxt.Clear();
            }
        }
    }
}
