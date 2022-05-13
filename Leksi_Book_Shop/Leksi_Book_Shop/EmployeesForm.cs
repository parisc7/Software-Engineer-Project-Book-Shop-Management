/** \file      EmployeesForm.cs
*   \brief     Provides the Employee Database
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
using System.Data;
using System.Data.OleDb;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>EmployeesForm</code> is a class that is responsible for
    * the form's functionalities that are related to the employee database
    * <BR>
    * @return Returns the corresponding applied changes
    */
    public partial class EmployeesForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =D:\GITHUB\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();

        // Employee List
        public List<Employee> EmployeesList = new List<Employee>();

        // Default Constructor 

        /**
        * Function <code>EmployeesForm</code> initialises the components
        * <BR>
        */
        public EmployeesForm()
        {
            InitializeComponent();  
        }

        /**
        * Function <code>timeTableButton_Click</code> shows employee's log in and log out time
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void timeTableButton_Click(object sender, EventArgs e)
        {
            Employee curemployee = new Employee();
            foreach (var employees in EmployeesList)
            {
                if (employees.Employee_id == int.Parse(eMPLOYEE_IDTextBox.Text))
                {
                    curemployee.Copy(employees);
                    break;
                }
            }
            this.Hide();
            TimeTableForm time = new TimeTableForm(curemployee);
            time.ShowDialog();
            this.Show();
        }

        /**
        * Function <code>EmployeesForm_Load</code> loads the employee database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.lexi_BookshopDataSet.EMPLOYEES);
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\GITHUB\sussy-Softsing-69-BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM EMPLOYEES";

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>addButton_Click</code> inserts a new record to the employee database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void addButton_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO EMPLOYEES (EMPLOYEE_ID,FIRSTNAME,LASTNAME,PHONE,USERNAME,PASSWORD) VALUES ( "+ int.Parse(eMPLOYEE_IDTextBox.Text)+",'"
                                                + fIRSTNAMETextBox.Text + "','" + lASTNAMETextBox.Text + "'," + int.Parse(pHONETextBox.Text) 
                                                + ",'" + uSERNAMETextBox.Text + "','" + pASSWORDTextBox.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>deleteButton_Click</code> deletes a record from the employee database
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void deleteButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM EMPLOYEES WHERE EMPLOYEE_ID= " +int.Parse( eMPLOYEE_IDTextBox.Text) + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>updateButton_Click</code> updates the employee database record
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void updateButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE EMPLOYEES SET FIRSTNAME='" + fIRSTNAMETextBox.Text + "',LASTNAME= '" + lASTNAMETextBox.Text 
                                                + "',PHONE= " + int.Parse(pHONETextBox.Text) + ",USERNAME= '" + pHONETextBox.Text + "' ,PASSWORD='"
                                                + pASSWORDTextBox.Text + "' WHERE EMPLOYEE_ID= " + int.Parse( eMPLOYEE_IDTextBox.Text) + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();

            // Cause database and forms are communicating through a linked list to retrieve and apply new info
            initializeList();
        }

        /**
        * Function <code>closeButton_Click</code> closes employee form
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
        * Function <code>fillGrid</code> fill datagridview from the employee database
        * <BR>
        */
        void fillGrid()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM EMPLOYEES ORDER BY EMPLOYEE_ID", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            eMPLOYEESBindingSource.DataSource = dt;
            conn.Close();
            fIRSTNAMETextBox.Text = "";
            lASTNAMETextBox.Text = "";
            pHONETextBox.Text = "";
            pASSWORDTextBox.Text = "";
            uSERNAMETextBox.Text = "";
            eMPLOYEE_IDTextBox.Text = "";
        }

        /**
        * Function <code>initializeList</code> generate linked list with the employees from the database 
        * <BR>
        */
        public void initializeList()
        {
            EmployeesList.Clear();
            for (int i = 0; i < eMPLOYEESBindingSource.Count; i++) 
            {
                Employee employee = new Employee();
                employee.Employee_id = int.Parse(employeeDataGridView.Rows[i].Cells[0].Value.ToString());
                employee.Firstname = employeeDataGridView.Rows[i].Cells[1].Value.ToString();
                employee.Lastname= employeeDataGridView.Rows[i].Cells[2].Value.ToString();
                employee.Phone = int.Parse(employeeDataGridView.Rows[i].Cells[3].Value.ToString());
                employee.Password = employeeDataGridView.Rows[i].Cells[4].Value.ToString();
                employee.Username = employeeDataGridView.Rows[i].Cells[5].Value.ToString();
                EmployeesList.Add(employee);
            }         
        }

    }
}
