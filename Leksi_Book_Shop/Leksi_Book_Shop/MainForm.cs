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
    public partial class MainForm : Form
    {
        BookForm books= new BookForm();
        CustomerForm customers= new CustomerForm();  

        public MainForm()
        {
            InitializeComponent();
        }

        private void companieLogoPictureBox_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
        }

        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            customers.ShowDialog();
            this.Show();
        }

        private void booksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            books.ShowDialog();
            this.Show();    
        }

        private void mailButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailForm mailForm = new MailForm();
            mailForm.ShowDialog();
            this.ShowDialog();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
