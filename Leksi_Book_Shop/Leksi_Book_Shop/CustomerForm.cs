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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void closeCustomerButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lexi_bookshopDataSet);

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_bookshopDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.lexi_bookshopDataSet.Customer);

        }
    }
}
