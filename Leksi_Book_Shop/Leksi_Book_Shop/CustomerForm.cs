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
    public partial class CustomerForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();



        public CustomerForm()
        {
            InitializeComponent();
        }

        private void closeCustomerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eMPLOYEESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lexi_BookshopDataSet);

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.CLIENTS' table. You can move, or remove it, as needed.
            this.cLIENTSTableAdapter.Fill(this.lexi_BookshopDataSet.CLIENTS);


            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";

            command.Connection = conn;
            command.CommandText = "SELECT * FROM CLIENTS";
           


        }

        void fillGrid()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM CLIENTS ORDER BY CLIENT_ID",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cLIENTSBindingSource.DataSource = dt;
            conn.Close();
            fNAMETextBox.Text = "";
            lNAMETextBox.Text = "";
            pHONETextBox.Text = "";
            eMAILTextBox.Text = "";
            aDDRESSTextBox.Text = "";
            cLIENT_IDTextBox.Text = "";
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
         {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update CLIENTS set  FNAME'" + fNAMETextBox.Text + ",LNAME=" + lNAMETextBox.Text + ",EMAIL= "+eMAILTextBox.Text+ ",PHONE="+pHONETextBox.Text+",ADDRESS="+aDDRESSTextBox.Text+ "where CLIENT_ID= " + cLIENT_IDTextBox.Text + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record UPDATED");
            fillGrid();
         }


         private void addButton_Click(object sender, EventArgs e)
         {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO CLIENTS (FNAME,LNAME,EMAIL,PHONE,ADDRESS) values ('" + fNAMETextBox.Text + "','"   + lNAMETextBox.Text + "','" + eMAILTextBox.Text + "','" + pHONETextBox.Text + "','" + aDDRESSTextBox.Text +  ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record ADDED");
            fillGrid();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM CLIENTS WHERE CLIENT_ID=" + cLIENT_IDTextBox+" ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record DELETED");
            fillGrid();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



