using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leksi_Book_Shop
{
    public partial class Book_List : Form
    {
        public Book_List()
        {
            InitializeComponent();
        }

        private void closeBookListButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
