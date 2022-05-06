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
        Employee Current=new Employee();
        public TimeTableForm(Employee employee)
        {
            InitializeComponent();
            Current .Copy(employee);
            display();

        }

        private void TimeTableForm_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.TIMETABLE' table. You can move, or remove it, as needed.
            this.tIMETABLETableAdapter.Fill(this.lexi_BookshopDataSet.TIMETABLE);

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void display()
        {
            eMPLOYEE_IDTextBox.Text = Current.Employee_id.ToString();
            fIRSTNAMETextBox.Text=Current.Firstname.ToString();
            
            pHONETextBox.Text=Current.Phone.ToString();

        }
    }
}
