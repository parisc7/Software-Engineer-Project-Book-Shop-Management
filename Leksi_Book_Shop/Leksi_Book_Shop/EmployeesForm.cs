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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void eMPLOYEESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lexi_BookshopDataSet);

        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            //this.eMPLOYEESTableAdapter.Fill(this.lexi_BookshopDataSet.EMPLOYEES);

        }

        
    }
}
