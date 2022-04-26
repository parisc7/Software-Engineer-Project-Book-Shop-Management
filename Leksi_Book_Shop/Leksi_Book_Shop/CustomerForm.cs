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
        SqlConnection conn = new SqlConnection();
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


            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Paris Costa\Documents\GitHub\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";

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
        }

        private void closeAddCustomerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
