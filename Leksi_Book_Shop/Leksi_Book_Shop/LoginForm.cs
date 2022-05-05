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
        EmployeesForm employeesForm = new EmployeesForm();
        Employee admin = new Employee(0, null, null, 0, "admin", "admin");
        MainForm main;


        public LoginForm()
        {
            InitializeComponent();
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
                    Admin = true;
                    exist = true;
                }
            }
            /*
            foreach (var users in userAccess.userAccess)
            {
                if (users.username == usernameTxt.Text)
                {
                    if (users.password == passwordTxt.Text)
                    {
                        current.Copy(users);
                        break;
                    }
                }
                else
                {
                    exist = true;
                }
            }*/

            if (exist)
            {
                this.Hide();
                main = new MainForm(Admin);
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
