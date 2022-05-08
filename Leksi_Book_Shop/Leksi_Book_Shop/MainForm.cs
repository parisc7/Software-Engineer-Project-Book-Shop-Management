/** \file      MainForm.cs
*   \brief     Provides the Main Screen from where everything can be accessed and are connected
*   \details   This program regards to all the necessary functionalities
*   \author    SOFTTSING TEAM
*   \version   0.1
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
using USB_Barcode_Scanner;
using System.Data.OleDb;


namespace Leksi_Book_Shop
{
    /**
    * Class <code>MainForm</code> is a class that is responsible for
    * the functionalities that are related to the connection of each form created
    * <BR>
    * @return Returns a successful navigation throughout the system
    */
    public partial class MainForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();
        BookForm books= new BookForm();
        CustomerForm customers= new CustomerForm();  
        EmployeesForm employees= new EmployeesForm();
        Employee curent=new Employee();

        public List<Order> curentOrder= new List<Order>();

        // Timetable Info
        DateTime Login;
        DateTime Logout;

        double TotalPrice = 0;

        // Default Constructor 

        /**
        * Function <code>MainForm</code> initialises ALL components / forms / isbn scanner
        * <BR>
        * @param admin    Indicates Admin 
        * @param employee Indicates Employee 
        */
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

            //ISBN SCANNER
            BarcodeScanner scanner = new BarcodeScanner(barcodeTxtBox);
            scanner.BarcodeScanned += Scanner_BarcodeScanned;

            // Employee Access
            curent.Copy(employee);
            if (admin== false)
            {
                employeesButton.Visible = false;
            }
        }

        /**
        * Function <code>employeesButton_Click</code> loads the employee's form
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void employeesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            employees.ShowDialog();
            this.Show();
        }

        /**
        * Function <code>companieLogoPictureBox_Click</code> loads the company's LOGO
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void companieLogoPictureBox_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.ShowDialog();
        }

        /**
        * Function <code>customerButton_Click</code> loads the customer's form
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void customerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            customers.ShowDialog();
            this.Show();
        }

        /**
        * Function <code>booksButton_Click</code> loads the books's form
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void booksButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            books.ShowDialog();
            this.Show();    
        }

        /**
        * Function <code>mailButton_Click</code> loads the mail's form
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void mailButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailForm mailForm = new MailForm();
            mailForm.ShowDialog();
            this.Show();
        }

        /**
        * Function <code>logoutButton_Click</code> closes whole system (exit)
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void logoutButton_Click(object sender, EventArgs e)
        {
            Times();
            this.Close();
        }

        /**
        * Function <code>MainForm_Load</code> loads the order's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.ORDER_LIST' table. You can move, or remove it, as needed.
            this.oRDER_LISTTableAdapter.Fill(this.lexi_BookshopDataSet.ORDER_LIST);
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.ORDER' table. You can move, or remove it, as needed.
            this.oRDERTableAdapter.Fill(this.lexi_BookshopDataSet.ORDER);
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM ORDER ";
        }

        /**
        * Function <code>Scanner_BarcodeScanned</code> inserts scanned isbn to the order's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Barcode Scanner Event (Default Parameters)
        */
        private void Scanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            // Saves scanned isbn into a txt file
            barcodeTxtBox.Text = e.Barcode;
            Order order = new Order();
            bool newBook = true;
            foreach (var book in books.BooksList)
            {
                if (book.ISBN == int.Parse(barcodeTxtBox.Text))
                {
                    //checking if is existing in the list
                    foreach(var bookofList in curentOrder)
                    {
                        if (bookofList.ISBN==book.ISBN)
                        {
                            bookofList.Quantity++;
                            TotalPrice += bookofList.Price;
                            bookofList.Price+=book.Price;
                            newBook = false;
                        }
                        break;
                    }
                    if (newBook == true)
                    {
                        order.ISBN = book.ISBN;
                        order.Title = book.Title;
                        order.Quantity = 1;
                        order.Price = book.Price;
                        TotalPrice += order.Price;
                    }
                    break;
                }
            }
            totalPriceLabel.Text = $"€ { TotalPrice.ToString()}";
            curentOrder.Add(order);
        }

        /**
        * Function <code>dailyTotalButton_Click</code> shows the total payment amount
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void dailyTotalButton_Click(object sender, EventArgs e)
        {
            //NA TIPONI SE ENAN NEON FORM TA TOTAL TIS IMERAS
        }

        /**
        * Function <code>deleteButton_Click</code> deletes a record from the order's database, in case of a mistake
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // NA DIAGRAFI POU TO ORDER TO SELECTED
        }

        /**
        * Function <code>payButton_Click</code> adds the amount of money for each purchase in the order list database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
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

        /**
        * Function <code>Times</code> total time where employee was logged in
        * <BR>
        */
        private void Times()
        {
            Logout= DateTime.Now;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO TIMETABLE (LOG_IN,LOG_OUT,EMPLOYEE_ID) VALUES ('" + Login.TimeOfDay+ "','" +Logout.TimeOfDay + "'," + curent.Employee_id+")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /**
        * Function <code>searchCustomerButton_Click</code> searches for customers included in customer database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
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
