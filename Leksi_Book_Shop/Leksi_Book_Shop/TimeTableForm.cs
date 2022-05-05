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
    public partial class TimeTableForm : Form
    {
        public TimeTableForm(int emplyeeID)
        {
            InitializeComponent();
        }

        private void TimeTableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.lexi_BookshopDataSet.EMPLOYEES);
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.lexi_BookshopDataSet.EMPLOYEES);
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.TIMETABLE' table. You can move, or remove it, as needed.
            this.tIMETABLETableAdapter.Fill(this.lexi_BookshopDataSet.TIMETABLE);

        }
    }
}
