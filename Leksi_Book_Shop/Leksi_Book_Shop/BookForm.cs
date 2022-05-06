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
        public List<Book> BooksList=new List<Book>();

        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.lexi_BookshopDataSet.BOOKS);
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = C:\Users\Paris Costa\Documents\GitHub\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM BOOKS";
            initializeList();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE BOOKS SET AUTHORS'" + aUTHORSTextBox.Text + "',PUBLISHERS='" + pUBLISHERSTextBox.Text +
                                                "',TITLE= '" + tITLETextBox.Text + "',PYEAR=" + pYEARTextBox.Text + ",PRICE=" + pRICETextBox.Text 
                                                + "WHERE ISBN= " + iSBNTextBox.Text + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();
            initializeList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO BOOKS (AUTHORS,PUBLISHERS,TITLE,PYEAR,PRICE) VALUES ('" 
                                                + aUTHORSTextBox.Text + "','" + pUBLISHERSTextBox.Text + "','" + tITLETextBox.Text 
                                                + "'," + pYEARTextBox.Text + "," + pRICETextBox.Text + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();
            initializeList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM BOOKS WHERE ISBN=" + iSBNTextBox.Text + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();
            initializeList();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void fillGrid()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM BOOKS ORDER BY ISBN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bookDataGridView.DataSource = dt;
            conn.Close();
            iSBNTextBox.Text = "";
            aUTHORSTextBox.Text = "";
            pUBLISHERSTextBox.Text = "";
            tITLETextBox.Text = "";
            pYEARTextBox.Text = "";
            pRICETextBox.Text = "";
        }

        public void initializeList()
        {
            BooksList.Clear();
            for (int i = 0; i < bOOKSBindingSource.Count; i++)
            {
                Book book = new Book();
                book.ISBN = int.Parse(bookDataGridView.Rows[i].Cells[0].Value.ToString());
                book.Authors = bookDataGridView.Rows[i].Cells[1].Value.ToString();
                book.Publishers = bookDataGridView.Rows[i].Cells[2].Value.ToString();
                book.Title = bookDataGridView.Rows[i].Cells[3].Value.ToString();
                book.Pyear = int.Parse(bookDataGridView.Rows[i].Cells[4].Value.ToString());
                book.Price = double.Parse(bookDataGridView.Rows[i].Cells[5].Value.ToString());
                BooksList.Add(book);
            }
        }

    }
}
