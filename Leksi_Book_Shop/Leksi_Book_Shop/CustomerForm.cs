/** \file      CustomerForm.cs
*   \brief     Provides the Customer Database
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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>CustomerForm</code> is a class that is responsible for
    * the form's functionalities that are related to the customer database
    * <BR>
    * @return Returns the corresponding applied changes
    */
    public partial class CustomerForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Paris Costa\Documents\GitHub\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();

        // Customer List
        public List<Customer> CustomerList = new List<Customer>();

        // Default Constructor 

        /**
        * Function <code>CustomerForm</code> initialises the components
        * <BR>
        */
        public CustomerForm()
        {
            InitializeComponent();
        }


        /**
        * Function <code>fillGrid</code> fills customer's form gridview
        * <BR>
        */
        void fillGrid()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM CLIENTS ORDER BY CLIENT_ID",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cLIENTSBindingSource.DataSource = dt;
            conn.Close();
            fIRSTNAMETextBox.Text = "";
            lASTNAMETextBox.Text = "";
            pHONETextBox.Text = "";
            eMAILTextBox.Text = "";
            aDDRESSTextBox.Text = "";
            cLIENT_IDTextBox.Text = "";
            pOINTSTextBox.Text = "";
        }

        /**
        * Function <code>CustomerForm_Load</code> loads the customer's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.CLIENTS' table. You can move, or remove it, as needed.
            this.cLIENTSTableAdapter.Fill(this.lexi_BookshopDataSet.CLIENTS);
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Paris Costa\Documents\GitHub\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM CLIENTS";

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>updateButton_Click</code> updates the customer's access database records
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void updateButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(int.Parse(cLIENT_IDTextBox.ToString()), fIRSTNAMETextBox.Text, lASTNAMETextBox.Text,
                                             eMAILTextBox.Text, int.Parse(pHONETextBox.ToString()), 
                                             aDDRESSTextBox.Text, int.Parse(pOINTSTextBox.ToString()));
            update(customer); 
            MessageBox.Show("Record UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /**
        * Function <code>addButton_Click</code> inserts a new record to the customer's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void addButton_Click(object sender, EventArgs e)
         {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO CLIENTS (FIRSTNAME,LASTNAME,EMAIL,PHONE,ADDRESS,POINTS) VALUES ('" + fIRSTNAMETextBox.Text + "','"   + lASTNAMETextBox.Text + "','" + eMAILTextBox.Text + "','" + pHONETextBox.Text + "','" + aDDRESSTextBox.Text +  "',0)", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
         }

        /**
        * Function <code>deleteButton_Click</code> deletes a record from the customer's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM CLIENTS WHERE CLIENT_ID=" + cLIENT_IDTextBox.Text+" ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>closeButton_Click</code> closes customer's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
        * Function <code>update</code> refers to the updateButton_click function shown above
        * <BR>
        * @param customer Represents each customer
        */
        public void update(Customer customer)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE CLIENTS SET FIRSTNAME='" + customer.Firstname+ "',LASTNAME='" + customer.Lastname
                                                + "',EMAIL= '" + customer.Email+ "',PHONE=" + customer.Phone + ",ADDRESS='" + customer.Address 
                                                + ",POINTS=" + customer.Points + "WHERE CLIENT_ID= " + customer.Customer_id+ " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>initializeList</code> initialises customer's database, through linked list
        * <BR>
        */
        public void initializeList()
        {
            CustomerList.Clear();
            for (int i = 0; i < cLIENTSBindingSource.Count; i++)
            {
                Customer customer= new Customer();
                customer.Customer_id= int.Parse(customerDataGridView.Rows[i].Cells[0].Value.ToString());
                customer.Firstname= customerDataGridView.Rows[i].Cells[1].Value.ToString();
                customer.Lastname= customerDataGridView.Rows[i].Cells[2].Value.ToString();
                customer.Email= customerDataGridView.Rows[i].Cells[3].Value.ToString();
                customer.Points= int.Parse(customerDataGridView.Rows[i].Cells[4].Value.ToString());
                customer.Phone= int.Parse(customerDataGridView.Rows[i].Cells[5].Value.ToString());
                customer.Address= customerDataGridView.Rows[i].Cells[6].Value.ToString();
                CustomerList.Add(customer);
            }
        }
    }
}



