using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Leksi_Book_Shop
{
    public partial class BookForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand command = new SqlCommand();


        public BookForm()
        {
            InitializeComponent();
        }

        private void closeBookListButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      //  
        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.lexi_BookshopDataSet.BOOKS);

            
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Paris Costa\Documents\GitHub\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";


            
            command.Connection = conn;
            command.CommandText = "SELECT * FROM BOOKS";

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            bookListDataGridView.DataSource = data;
        }

        private void updateBookListButton_Click(object sender, EventArgs e)
        {
            

/*
            try
            {
                conn.Open();
                command = new SqlCommand("UPDATE BOOKS SET ISBN=@a1, AUTHORS=@a2",conn);
                command.Parameters.Add("a1");
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         */  
        }

        private void bookListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
