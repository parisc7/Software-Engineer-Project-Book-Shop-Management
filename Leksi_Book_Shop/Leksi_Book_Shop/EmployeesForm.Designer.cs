namespace Leksi_Book_Shop
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label eMPLOYEE_IDLabel;
            System.Windows.Forms.Label fNAMELabel;
            System.Windows.Forms.Label lNAMELabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label uSERNAMELabel;
            System.Windows.Forms.Label pASSWORDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.timeTableButton = new System.Windows.Forms.Button();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEE_IDTextBox = new System.Windows.Forms.TextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.eMPLOYEEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.eMPLOYEESTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            eMPLOYEE_IDLabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            this.bookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEE_IDLabel
            // 
            eMPLOYEE_IDLabel.AutoSize = true;
            eMPLOYEE_IDLabel.Location = new System.Drawing.Point(40, 36);
            eMPLOYEE_IDLabel.Name = "eMPLOYEE_IDLabel";
            eMPLOYEE_IDLabel.Size = new System.Drawing.Size(199, 34);
            eMPLOYEE_IDLabel.TabIndex = 35;
            eMPLOYEE_IDLabel.Text = "EMPLOYEE ID:";
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(513, 36);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(164, 34);
            fNAMELabel.TabIndex = 37;
            fNAMELabel.Text = "First Name:";
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(952, 36);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(141, 34);
            lNAMELabel.TabIndex = 39;
            lNAMELabel.Text = "Surname:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(40, 116);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(109, 34);
            pHONELabel.TabIndex = 41;
            pHONELabel.Text = "Phone:";
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(488, 116);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(167, 34);
            uSERNAMELabel.TabIndex = 43;
            uSERNAMELabel.Text = "USERNAME:";
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(932, 117);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(177, 34);
            pASSWORDLabel.TabIndex = 45;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(this.timeTableButton);
            this.bookListPanel.Controls.Add(this.pHONETextBox);
            this.bookListPanel.Controls.Add(this.lNAMETextBox);
            this.bookListPanel.Controls.Add(this.fNAMETextBox);
            this.bookListPanel.Controls.Add(eMPLOYEE_IDLabel);
            this.bookListPanel.Controls.Add(this.eMPLOYEE_IDTextBox);
            this.bookListPanel.Controls.Add(fNAMELabel);
            this.bookListPanel.Controls.Add(lNAMELabel);
            this.bookListPanel.Controls.Add(pHONELabel);
            this.bookListPanel.Controls.Add(uSERNAMELabel);
            this.bookListPanel.Controls.Add(this.uSERNAMETextBox);
            this.bookListPanel.Controls.Add(pASSWORDLabel);
            this.bookListPanel.Controls.Add(this.pASSWORDTextBox);
            this.bookListPanel.Controls.Add(this.addButton);
            this.bookListPanel.Controls.Add(this.updateButton);
            this.bookListPanel.Controls.Add(this.deleteButton);
            this.bookListPanel.Controls.Add(this.closeButton);
            this.bookListPanel.Controls.Add(this.customerDataGridView);
            this.bookListPanel.Controls.Add(this.searchCustomerButton);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(12, 12);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(1489, 794);
            this.bookListPanel.TabIndex = 3;
            // 
            // timeTableButton
            // 
            this.timeTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.timeTableButton.FlatAppearance.BorderSize = 0;
            this.timeTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeTableButton.Image = ((System.Drawing.Image)(resources.GetObject("timeTableButton.Image")));
            this.timeTableButton.Location = new System.Drawing.Point(1360, 110);
            this.timeTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeTableButton.Name = "timeTableButton";
            this.timeTableButton.Size = new System.Drawing.Size(67, 48);
            this.timeTableButton.TabIndex = 47;
            this.timeTableButton.UseVisualStyleBackColor = false;
            this.timeTableButton.Click += new System.EventHandler(this.timeTableButton_Click);
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(155, 110);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(242, 41);
            this.pHONETextBox.TabIndex = 42;
            this.pHONETextBox.Text = " ";
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // lexi_BookshopDataSet
            // 
            this.lexi_BookshopDataSet.DataSetName = "Lexi_BookshopDataSet";
            this.lexi_BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(1099, 29);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(328, 41);
            this.lNAMETextBox.TabIndex = 40;
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(683, 33);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(214, 41);
            this.fNAMETextBox.TabIndex = 38;
            // 
            // eMPLOYEE_IDTextBox
            // 
            this.eMPLOYEE_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "EMPLOYEE_ID", true));
            this.eMPLOYEE_IDTextBox.Location = new System.Drawing.Point(245, 33);
            this.eMPLOYEE_IDTextBox.Name = "eMPLOYEE_IDTextBox";
            this.eMPLOYEE_IDTextBox.ReadOnly = true;
            this.eMPLOYEE_IDTextBox.Size = new System.Drawing.Size(217, 41);
            this.eMPLOYEE_IDTextBox.TabIndex = 36;
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(661, 113);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(236, 41);
            this.uSERNAMETextBox.TabIndex = 44;
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(1115, 113);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(230, 41);
            this.pASSWORDTextBox.TabIndex = 46;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(46, 719);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(191, 55);
            this.addButton.TabIndex = 35;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(850, 719);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(191, 55);
            this.updateButton.TabIndex = 34;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(440, 719);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(191, 55);
            this.deleteButton.TabIndex = 33;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1236, 719);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 55);
            this.closeButton.TabIndex = 32;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPLOYEEIDDataGridViewTextBoxColumn,
            this.fNAMEDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.eMPLOYEESBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(46, 204);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(1381, 502);
            this.customerDataGridView.TabIndex = 30;
            // 
            // eMPLOYEEIDDataGridViewTextBoxColumn
            // 
            this.eMPLOYEEIDDataGridViewTextBoxColumn.DataPropertyName = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.HeaderText = "EMPLOYEE_ID";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Name = "eMPLOYEEIDDataGridViewTextBoxColumn";
            this.eMPLOYEEIDDataGridViewTextBoxColumn.Width = 250;
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            this.fNAMEDataGridViewTextBoxColumn.Width = 215;
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            this.lNAMEDataGridViewTextBoxColumn.Width = 222;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 200;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            this.uSERNAMEDataGridViewTextBoxColumn.Width = 220;
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            this.pASSWORDDataGridViewTextBoxColumn.Width = 220;
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.searchCustomerButton.FlatAppearance.BorderSize = 0;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomerButton.Image")));
            this.searchCustomerButton.Location = new System.Drawing.Point(403, 109);
            this.searchCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(59, 46);
            this.searchCustomerButton.TabIndex = 11;
            this.searchCustomerButton.UseVisualStyleBackColor = false;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.EMPLOYEESTableAdapter = this.eMPLOYEESTableAdapter;
            this.tableAdapterManager.ORDER_LISTTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1510, 816);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeesForm";
            this.Text = "EmploymentsForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.Button searchCustomerButton;
        private Lexi_BookshopDataSet lexi_BookshopDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private Lexi_BookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox eMPLOYEE_IDTextBox;
        private System.Windows.Forms.TextBox fNAMETextBox;
        private System.Windows.Forms.TextBox lNAMETextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.Button timeTableButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPLOYEEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
    }
}