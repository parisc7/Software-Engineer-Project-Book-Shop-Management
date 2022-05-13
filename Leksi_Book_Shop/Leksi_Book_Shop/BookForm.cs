/** \file      BookForm.cs
*   \brief     Provides the Book Database
*   \details   This program regards to all the necessary functionalities
*   \author    SOFTTSING TEAM
*   \version   2.0
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
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>BookForm</code> is a class that is responsible for
    * the form's functionalities that are related to the book database
    * <BR>
    * @return Returns the corresponding applied changes
    */
    public partial class BookForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\GITHUB\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();

        // Book List
        public List<Book> BooksList=new List<Book>();

        // Default Constructor 

        /**
        * Function <code>BookForm</code> initialises the components
        * <BR>
        */
        public BookForm()
        {
            InitializeComponent();
        }

        /**
        * Function <code>BookForm_Load</code> loads the book's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void BookForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.lexi_BookshopDataSet.BOOKS);
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;Data Source = D:\GITHUB\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM BOOKS";

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>updateButton_Click</code> updates the book database records
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void updateButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE BOOKS SET AUTHORS ='" + aUTHORSTextBox.Text + "',PUBLISHERS='" + pUBLISHERSTextBox.Text +
                                                "',TITLE= '" + tITLETextBox.Text + "',PYEAR= " +int.Parse(pYEARTextBox.Text) + " ,PRICE= " + double.Parse(pRICETextBox.Text) 
                                                + " WHERE ISBN= " + int.Parse(iSBNTextBox.Text) + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>addButton_Click</code> inserts a new record to the book database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void addButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO BOOKS (ISBN,AUTHORS,PUBLISHERS,TITLE,PYEAR,PRICE) VALUES ("+ int.Parse(iSBNTextBox.Text) + ",'" 
                                                + aUTHORSTextBox.Text + "','" + pUBLISHERSTextBox.Text + "','" + tITLETextBox.Text 
                                                + "'," + int.Parse(pYEARTextBox.Text) + "," + double.Parse(pRICETextBox.Text) + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>deleteButton_Click</code> deletes a record from the book database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM BOOKS WHERE ISBN= " + int.Parse(iSBNTextBox.Text) + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>closeButton_Click</code> closes book form
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
        * Function <code>fillGrid</code> fills datagridview from the book database
        * <BR>
        */
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

        /**
        * Function <code>initializeList</code> generate linked list with the books from the database 
        * <BR>
        */
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
