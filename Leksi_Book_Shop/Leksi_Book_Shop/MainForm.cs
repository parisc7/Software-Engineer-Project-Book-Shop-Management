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
using System.Data.OleDb;
using System.Windows.Forms;
using USB_Barcode_Scanner;


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
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Paris Costa\Documents\GitHub\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();

        BookForm books= new BookForm();
        CustomerForm customers= new CustomerForm();  
        EmployeesForm employees= new EmployeesForm();

        Employee curentEmployee=new Employee();
        Customer curentCustomer = new Customer();


        public List<Order> curentOrder= new List<Order>();

        //  Employee timetable Info 
        DateTime Login;
        DateTime Logout;
        bool Admin = false;
        double TotalPrice = 0;


        /**
        * Function <code>MainForm</code> initialises ALL components / isbn scanner
        * <BR>
        * @param admin    Indicates Admin 
        * @param employee Indicates Employee 
        */

        // Constructor for the form
        public MainForm(bool admin,Employee employee)
        {
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

            curentEmployee.Copy(employee);
            Admin = admin;

            // Employee Access
            if (admin== false)
            {
                Login = DateTime.Now;
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
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Paris Costa\Documents\GitHub\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
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
        * Function <code>payButton_Click</code> adds the amount of money for each purchase in the order list database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void payButton_Click(object sender, EventArgs e)
        {
            int sumPrice = 0, sumQuantity = 0;
            for (int i = 0; i < currentOrderDataGridView.RowCount; i++)
            {
                sumPrice += int.Parse(currentOrderDataGridView.Rows[i].Cells[0].Value.ToString());
                sumQuantity += int.Parse(currentOrderDataGridView.Rows[i].Cells[1].Value.ToString());
            }
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO ORDER_LIST (ORDER_ID, PRICE, QUANTITY, CLIENT_ID, EMPPLOYEE_ID) VALUES (" +
                                                orderNoTxtBox.Text + "," + sumPrice + "," + sumQuantity + "," + curentCustomer.Customer_id + "," +
                                                curentEmployee.Employee_id + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            orderNoTxtBox.Text = "";
            customerTxtBox.Text = "";
            nameSurnameTxttBox.Text = "";
            pointsTxtBox.Text = "";
            totalPriceLabel.Text = "";
        }

        /**
        * Function <code>Times</code> total time where employee was logged in
        * <BR>
        */
        private void Times()
        {
            if (Admin == false)
            {
                Logout = DateTime.Now;
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("INSERT INTO TIMETABLE (LOG_IN,LOG_OUT,EMPLOYEE_ID) VALUES ('" + Login.TimeOfDay + "','" + Logout.TimeOfDay + "'," + curentEmployee.Employee_id + ")", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
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
                    orderNoTxtBox.Text = $"{oRDER_LISTBindingSource.Count + 1}";
                    curentCustomer.copy(customer);
                    break;
                }
                else if (customer.Customer_id == int.Parse(customerTxtBox.Text))
                {
                    nameSurnameTxttBox.Text = $"{customer.Firstname} {customer.Lastname}";
                    pointsTxtBox.Text = $"{customer.Points}";
                    orderNoTxtBox.Text = $"{oRDER_LISTBindingSource.Count + 1}";
                    curentCustomer.copy(customer);
                    break;
                }
            }
        }
    }
}
