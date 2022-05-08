/** \file      TimeTableForm.cs
*   \brief     Provides the Log in/out timetable database
*   \details   This program regards to all the necessary functionalities
*   \author    SOFTTSING TEAM
*   \version   0.1
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
using System.Data.OleDb;

namespace Leksi_Book_Shop
{
    /**
   * Class <code>TimeTableForm</code> is a class that is responsible for
   * the form's functionalities that are related to the log in/out timing database
   * <BR>
   * @return Returns the corresponding results
   */
    public partial class TimeTableForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();

        // Indicating each employee loggin' in the system
        Employee Current =new Employee();

        // Default Constructor 

        /**
        * Function <code>TimeTableForm</code> initialises the components and copies current employee's info
        * <BR>
        * @param employee Represents every employee on the system
        */
        public TimeTableForm(Employee employee)
        {
            InitializeComponent();
            Current .Copy(employee);
            display();

        }

        /**
        * Function <code>TimeTableForm_Load</code> loads the timetable's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void TimeTableForm_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.TIMETABLE' table. You can move, or remove it, as needed.
            this.tIMETABLETableAdapter.Fill(this.lexi_BookshopDataSet.TIMETABLE);
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM TIMETABLE WHERE EMPLOYE_ID ="+Current.Employee_id;
            
        }

        /**
        * Function <code>closeButton_Click</code> closes timetable's access database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
        * Function <code>display</code> displays employee information
        * <BR>
        */
        public void display()
        {
            eMPLOYEE_IDTextBox.Text = Current.Employee_id.ToString();
            fIRSTNAMETextBox.Text=Current.Firstname.ToString();
            lASTNAMETextBox.Text= Current.Lastname.ToString();
            pHONETextBox.Text=Current.Phone.ToString();
        }
    }
}
