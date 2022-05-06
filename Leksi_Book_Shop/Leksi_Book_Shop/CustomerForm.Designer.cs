﻿namespace Leksi_Book_Shop
{
    partial class CustomerForm
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
            System.Windows.Forms.Label aDDRESSLabel;
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label cLIENT_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.Label fIRSTNAMELabel;
            System.Windows.Forms.Label lASTNAMELabel;
            System.Windows.Forms.Label pOINTSLabel;
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.cLIENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.cLIENTSTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.CLIENTSTableAdapter();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POINTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMETextBox = new System.Windows.Forms.TextBox();
            this.lASTNAMETextBox = new System.Windows.Forms.TextBox();
            this.pOINTSTextBox = new System.Windows.Forms.TextBox();
            aDDRESSLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            cLIENT_IDLabel = new System.Windows.Forms.Label();
            fIRSTNAMELabel = new System.Windows.Forms.Label();
            lASTNAMELabel = new System.Windows.Forms.Label();
            pOINTSLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Location = new System.Drawing.Point(922, 101);
            aDDRESSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(129, 34);
            aDDRESSLabel.TabIndex = 26;
            aDDRESSLabel.Text = "Address:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(23, 101);
            pHONELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(109, 34);
            pHONELabel.TabIndex = 24;
            pHONELabel.Text = "Phone:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(398, 101);
            eMAILLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(103, 34);
            eMAILLabel.TabIndex = 22;
            eMAILLabel.Text = "E-Mail:";
            // 
            // cLIENT_IDLabel
            // 
            cLIENT_IDLabel.AutoSize = true;
            cLIENT_IDLabel.Location = new System.Drawing.Point(23, 39);
            cLIENT_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLIENT_IDLabel.Name = "cLIENT_IDLabel";
            cLIENT_IDLabel.Size = new System.Drawing.Size(146, 34);
            cLIENT_IDLabel.TabIndex = 17;
            cLIENT_IDLabel.Text = "CLIENT ID:";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.mainPanel.Controls.Add(this.pOINTSTextBox);
            this.mainPanel.Controls.Add(this.lASTNAMETextBox);
            this.mainPanel.Controls.Add(this.fIRSTNAMETextBox);
            this.mainPanel.Controls.Add(pOINTSLabel);
            this.mainPanel.Controls.Add(this.addButton);
            this.mainPanel.Controls.Add(this.updateButton);
            this.mainPanel.Controls.Add(this.pHONETextBox);
            this.mainPanel.Controls.Add(this.aDDRESSTextBox);
            this.mainPanel.Controls.Add(this.customerDataGridView);
            this.mainPanel.Controls.Add(aDDRESSLabel);
            this.mainPanel.Controls.Add(pHONELabel);
            this.mainPanel.Controls.Add(eMAILLabel);
            this.mainPanel.Controls.Add(this.eMAILTextBox);
            this.mainPanel.Controls.Add(cLIENT_IDLabel);
            this.mainPanel.Controls.Add(this.cLIENT_IDTextBox);
            this.mainPanel.Controls.Add(this.deleteButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(this.searchCustomerButton);
            this.mainPanel.Controls.Add(fIRSTNAMELabel);
            this.mainPanel.Controls.Add(lASTNAMELabel);
            this.mainPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1485, 794);
            this.mainPanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(29, 709);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(191, 55);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(855, 709);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(191, 55);
            this.updateButton.TabIndex = 30;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(140, 101);
            this.pHONETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(203, 41);
            this.pHONETextBox.TabIndex = 27;
            // 
            // cLIENTSBindingSource
            // 
            this.cLIENTSBindingSource.DataMember = "CLIENTS";
            this.cLIENTSBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // lexi_BookshopDataSet
            // 
            this.lexi_BookshopDataSet.DataSetName = "Lexi_BookshopDataSet";
            this.lexi_BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "ADDRESS", true));
            this.aDDRESSTextBox.Location = new System.Drawing.Point(1059, 98);
            this.aDDRESSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(406, 41);
            this.aDDRESSTextBox.TabIndex = 28;
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.searchCustomerButton.FlatAppearance.BorderSize = 0;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomerButton.Image")));
            this.searchCustomerButton.Location = new System.Drawing.Point(332, 97);
            this.searchCustomerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(59, 46);
            this.searchCustomerButton.TabIndex = 11;
            this.searchCustomerButton.UseVisualStyleBackColor = false;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.FIRSTNAME,
            this.LASTNAME,
            this.eMAILDataGridViewTextBoxColumn,
            this.POINTS,
            this.pHONEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.cLIENTSBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(29, 169);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(1436, 512);
            this.customerDataGridView.TabIndex = 29;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(509, 98);
            this.eMAILTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(405, 41);
            this.eMAILTextBox.TabIndex = 25;
            // 
            // cLIENT_IDTextBox
            // 
            this.cLIENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "CLIENT_ID", true));
            this.cLIENT_IDTextBox.Location = new System.Drawing.Point(177, 37);
            this.cLIENT_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cLIENT_IDTextBox.Name = "cLIENT_IDTextBox";
            this.cLIENT_IDTextBox.Size = new System.Drawing.Size(158, 41);
            this.cLIENT_IDTextBox.TabIndex = 19;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(445, 709);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(191, 55);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1274, 709);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 55);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = this.cLIENTSTableAdapter;
            this.tableAdapterManager.EMPLOYEESTableAdapter = this.eMPLOYEESTableAdapter;
            this.tableAdapterManager.ORDER_LISTTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cLIENTSTableAdapter
            // 
            this.cLIENTSTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.DataPropertyName = "FIRSTNAME";
            this.FIRSTNAME.HeaderText = "FIRSTNAME";
            this.FIRSTNAME.MinimumWidth = 6;
            this.FIRSTNAME.Name = "FIRSTNAME";
            this.FIRSTNAME.Width = 170;
            // 
            // LASTNAME
            // 
            this.LASTNAME.DataPropertyName = "LASTNAME";
            this.LASTNAME.HeaderText = "LASTNAME";
            this.LASTNAME.MinimumWidth = 6;
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.Width = 170;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 210;
            // 
            // POINTS
            // 
            this.POINTS.DataPropertyName = "POINTS";
            this.POINTS.HeaderText = "POINTS";
            this.POINTS.MinimumWidth = 6;
            this.POINTS.Name = "POINTS";
            this.POINTS.Width = 150;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 190;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.Width = 342;
            // 
            // fIRSTNAMELabel
            // 
            fIRSTNAMELabel.AutoSize = true;
            fIRSTNAMELabel.Location = new System.Drawing.Point(342, 39);
            fIRSTNAMELabel.Name = "fIRSTNAMELabel";
            fIRSTNAMELabel.Size = new System.Drawing.Size(166, 34);
            fIRSTNAMELabel.TabIndex = 31;
            fIRSTNAMELabel.Text = "FIRSTNAME:";
            // 
            // fIRSTNAMETextBox
            // 
            this.fIRSTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "FIRSTNAME", true));
            this.fIRSTNAMETextBox.Location = new System.Drawing.Point(500, 34);
            this.fIRSTNAMETextBox.Name = "fIRSTNAMETextBox";
            this.fIRSTNAMETextBox.Size = new System.Drawing.Size(267, 41);
            this.fIRSTNAMETextBox.TabIndex = 32;
            // 
            // lASTNAMELabel
            // 
            lASTNAMELabel.AutoSize = true;
            lASTNAMELabel.Location = new System.Drawing.Point(773, 39);
            lASTNAMELabel.Name = "lASTNAMELabel";
            lASTNAMELabel.Size = new System.Drawing.Size(163, 34);
            lASTNAMELabel.TabIndex = 32;
            lASTNAMELabel.Text = "LASTNAME:";
            // 
            // lASTNAMETextBox
            // 
            this.lASTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "LASTNAME", true));
            this.lASTNAMETextBox.Location = new System.Drawing.Point(933, 34);
            this.lASTNAMETextBox.Name = "lASTNAMETextBox";
            this.lASTNAMETextBox.Size = new System.Drawing.Size(299, 41);
            this.lASTNAMETextBox.TabIndex = 33;
            // 
            // pOINTSLabel
            // 
            pOINTSLabel.AutoSize = true;
            pOINTSLabel.Location = new System.Drawing.Point(1238, 31);
            pOINTSLabel.Name = "pOINTSLabel";
            pOINTSLabel.Size = new System.Drawing.Size(115, 34);
            pOINTSLabel.TabIndex = 33;
            pOINTSLabel.Text = "POINTS:";
            // 
            // pOINTSTextBox
            // 
            this.pOINTSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "POINTS", true));
            this.pOINTSTextBox.Enabled = false;
            this.pOINTSTextBox.Location = new System.Drawing.Point(1350, 28);
            this.pOINTSTextBox.Name = "pOINTSTextBox";
            this.pOINTSTextBox.ReadOnly = true;
            this.pOINTSTextBox.Size = new System.Drawing.Size(115, 41);
            this.pOINTSTextBox.TabIndex = 34;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1509, 817);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.Button closeButton;
        private Lexi_BookshopDataSet lexi_BookshopDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private Lexi_BookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Lexi_BookshopDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox cLIENT_IDTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox pOINTSTextBox;
        private System.Windows.Forms.TextBox lASTNAMETextBox;
        private System.Windows.Forms.TextBox fIRSTNAMETextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POINTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
    }
}