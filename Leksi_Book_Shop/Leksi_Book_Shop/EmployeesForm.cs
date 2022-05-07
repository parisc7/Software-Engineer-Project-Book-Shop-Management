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
    public partial class EmployeesForm : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb");
        OleDbCommand command = new OleDbCommand();
        public List<Employee> EmployeesList = new List<Employee>(); 

        public EmployeesForm()
        {
            InitializeComponent();  
        }

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
        
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lexi_BookshopDataSet.EMPLOYEES' table. You can move, or remove it, as needed.
            this.eMPLOYEESTableAdapter.Fill(this.lexi_BookshopDataSet.EMPLOYEES);
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\Paris Costa\Documents\GitHub\sussy - Softsing - 69 - BAKA\Leksi_Book_Shop\Leksi_Book_Shop\Lexi_Bookshop.accdb";
            command.Connection = conn;
            command.CommandText = "SELECT * FROM EMPLOYEES";
            initializeList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO EMPLOYEES (FIRSTNAME,LASTNAME,PHONE,USERNAME,PASSWORD) VALUES ('" 
                                                + fIRSTNAMETextBox.Text + "','" + lASTNAMETextBox.Text + "'," + pHONETextBox.Text 
                                                + ",'" + uSERNAMETextBox.Text + "','" + pASSWORDTextBox.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record ADDED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();
            initializeList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM EMPLOYEES WHERE EMPLOYEE_ID=" + eMPLOYEE_IDTextBox.Text + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record DELETED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fillGrid();
            initializeList();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE EMPLOYEES SET FIRSTNAME='" + fIRSTNAMETextBox.Text + "',LASTNAME= '" + lASTNAMETextBox.Text 
                                                + "',PHONE= " + pHONETextBox.Text + ",USERNAME='" + pHONETextBox.Text + "',PASSWORD='"
                                                + pASSWORDTextBox.Text + "'where EMPLOYEE_ID= " + eMPLOYEE_IDTextBox.Text + " ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Record UPDATED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
