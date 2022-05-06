using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;
using System.Data.OleDb;


namespace Leksi_Book_Shop
{
    public partial class MainForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();
        BookForm books= new BookForm();
        CustomerForm customers= new CustomerForm();  
        EmployeesForm employees= new EmployeesForm();
        Employee curent=new Employee();
        DateTime Login;
        DateTime Logout;
        

       
        public MainForm(bool admin,Employee employee)
        {
            Login= DateTime.Now;
            customers.Show();
            customers.Hide();
            books.Show();
            books.Hide();
            employees.Show();
            employees.Hide();
            InitializeComponent();
            BarcodeScanner scanner = new BarcodeScanner(barcodeTxtBox);
            scanner.BarcodeScanned += Scanner_BarcodeScanned;  
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
            Times();
            this.Close();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.lexi_BookshopDataSet.ORDER);
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM ORDER ";
        }
        private void Scanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            barcodeTxtBox.Text = e.Barcode;
            foreach (var book in books.BooksList)
            {
                if (book.ISBN == int.Parse(barcodeTxtBox.Text))
                {
                    //NA BENI DAME STO TABLE TOU ORDER
                    break;
                }

            }

        }
        private void dailyTotalButton_Click(object sender, EventArgs e)
        {
            //NA TIPONI SE ENAN NEON FORM TA TOTAL TIS IMERAS
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            // NA DIAGRAFI POU TO ORDER TO SELECTED
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            orderNoTxtBox.Text = "";
            customerTxtBox.Text = "";
            nameSurnameTxttBox.Text = "";
            pointsTxtBox.Text = "";
            totalPriceLabel.Text = "";
            //NA APOTHIKEUETE STO ORDERLIST TO ORDER 
            // JE META NA KSANA GRAFI PANO TON TREXON ARITHMO TOUY ORDER SE AUKSOUSA SIRA FASI COUNTER
        }
        
        private void Times()
        {
            Logout= DateTime.Now;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO TIMETABLE (LOG_IN,LOG_OUT,EMPLOYEE_ID) VALUES ('" + Login.TimeOfDay+ "','" +Logout.TimeOfDay + "'," + curent.Employee_id+")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            foreach (var customer in customers.CustomerList)
            {
                if (customer.Phone == int.Parse(customerTxtBox.Text))
                {
                    nameSurnameTxttBox.Text = $"{customer.Firstname} {customer.Lastname}";
                    pointsTxtBox.Text =$"{customer.Points}";
                    break;
                }
                else if (customer.Customer_id == int.Parse(customerTxtBox.Text))
                {
                    nameSurnameTxttBox.Text = $"{customer.Firstname} {customer.Lastname}";
                    pointsTxtBox.Text = $"{customer.Points}";
                    break;
                }
            }
        }
    }
}
