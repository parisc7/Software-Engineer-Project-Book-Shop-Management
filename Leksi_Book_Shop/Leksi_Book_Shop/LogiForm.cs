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
    public partial class LogiForm : Form
    {
       // user_Form userAccess = new user_Form();
      
        public LogiForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            this.Hide();
            main.ShowDialog();
           
         /*   User current = new User();
            bool exist = false;
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
            }

            if (exist)
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameTxt.Clear();
                passwordTxt.Clear();
            }
            else
            {
                this.Hide();
                main = new MainForm(current);
                main.ShowDialog();
                this.Close();
            }
            */
        }
    }
}
