using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        SqlConnection conn = new SqlConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\giorgos\Desktop\trial1\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        SqlCommand command = new SqlCommand();


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

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            customerDataGridView.DataSource = data;
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            command = new SqlCommand("UPDATE CLIENTS SET  FNAME=@a1, LNAME=@a2, EMAIL=@a3, PHONE=@a4, ADDRESS=@a5 WHERE CLIENT_ID=@a6",conn);
            command.Parameters.Add("a1", fNAMETextBox.Text);
            command.Parameters.Add("a2", lNAMETextBox.Text);
            command.Parameters.Add("a3", eMAILTextBox.Text);
            command.Parameters.Add("a4", pHONETextBox.Text);
            command.Parameters.Add("a5", aDDRESSTextBox.Text);
            command.ExecuteNonQuery();
            //conn.Close();
            MessageBox.Show("Record Updated");
        }

        private void closeAddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "insert into CLIENTS values('" + fNAMETextBox.Text+"','"+ lNAMETextBox.Text + "','" + eMAILTextBox.Text + "','" + pHONETextBox.Text + "','" + aDDRESSTextBox.Text+"')";
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client ADDED Successfully");
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            /*conn.Open();
            command = new SqlCommand("INSERT INTO CLIENTS (FNAME,LNAME,EMAIL,PHONE,ADDRESS) values (@FNAME,@LNAME,@EMAIL,@PHONE,@ADDRESS)", conn);
            command.Parameters.Add("@FNAME", fNAMETextBox.Text);
            command.Parameters.Add("@LNAME", lNAMETextBox.Text);
            command.Parameters.Add("@EMAIL", eMAILTextBox.Text);
            command.Parameters.Add("@PHONE", pHONETextBox.Text);
            command.Parameters.Add("@ADDRESS", aDDRESSTextBox.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Record Added");*/


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
           /* var item = customerDataGridView.SelectedRows;

            if (item == null)
                return;

            customerDataGridView.Rows.Remove(item);*/

            
        }
    }
}
