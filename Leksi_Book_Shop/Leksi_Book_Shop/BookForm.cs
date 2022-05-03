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
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();


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

        }

        void fillGrid()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM BOOKS ORDER BY ISBN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bookDataGridView.DataSource = dt;
            conn.Close();
           /* fNAMETextBox.Text = "";
            lNAMETextBox.Text = "";
            pHONETextBox.Text = "";
            eMAILTextBox.Text = "";
            aDDRESSTextBox.Text = "";
            cLIENT_IDTextBox.Text = "";
           */
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update BOOKS set  AUTHORS'" + aUTHORSTextBox.Text + ",PUBLISHERS=" + pUBLISHERSTextBox.Text + ",TITLE= " + tITLETextBox.Text + ",PYEAR=" + pUBLISHERSTextBox.Text + ",PRICE=" + pUBLISHERSTextBox.Text + "where ISBN= " + pRICETextBox.Text + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record UPDATED");
            fillGrid();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("insert into BOOKS (AUTHORS,,PUBLISHERS,TITLE,PYEAR,PRICE) values ('" +aUTHORSTextBox.Text + "','" + pUBLISHERSTextBox.Text + "','" + tITLETextBox.Text + "','" + pUBLISHERSTextBox.Text + "','" + pRICETextBox.Text + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record ADDED");
            fillGrid();
        }
    }
}
