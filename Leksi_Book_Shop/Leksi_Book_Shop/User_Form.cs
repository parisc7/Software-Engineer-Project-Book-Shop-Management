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
    public partial class User_Form : Form
    {
       

        public User_Form()
        {
            InitializeComponent();
            
        }

       

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
