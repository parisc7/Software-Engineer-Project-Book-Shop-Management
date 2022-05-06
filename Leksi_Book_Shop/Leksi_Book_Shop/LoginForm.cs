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
    public partial class LoginForm : Form
    {
        EmployeesForm employees= new EmployeesForm();
        Employee admin = new Employee(0, null, null, 0, "admin", "admin");
        MainForm main;


        public LoginForm()
        {
            InitializeComponent();
            employees.Show();
            employees.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool Admin=true;
            Employee current = new Employee();
            bool exist = false;

            if (usernameTxt.Text == admin.Username)
            {
                if (passwordTxt.Text == admin.Password)
                {
                    current=admin;
                    Admin = true;
                    exist = true;
                }
            }
           
            foreach (var employee in employees.EmployeesList)
            {
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
                else
                {
                    exist = false;
                }
            }

            if (exist)
            {
                this.Hide();
                main = new MainForm(Admin,current);
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Clear();
                passwordTxt.Clear();
            }
        }
    }
}
