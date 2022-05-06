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
        EmployeesForm employees= new EmployeesForm();
        Employee curent=new Employee();

        public MainForm(bool admin,Employee employee)
        {
            InitializeComponent();
            curent.Copy(employee);
            if (admin== false)
            {
                employeesButton.Visible = false;
            }
        }
        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            employees.ShowDialog();
            this.Show();
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
            this.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.lexi_BookshopDataSet.ORDER);

        }

        private void dailyTotalButton_Click(object sender, EventArgs e)
        {

        }
    }
}
