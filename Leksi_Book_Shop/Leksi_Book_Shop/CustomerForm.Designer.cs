namespace Leksi_Book_Shop
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
            System.Windows.Forms.Label lNAMELabel;
            System.Windows.Forms.Label fNAMELabel;
            System.Windows.Forms.Label cLIENT_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.cLIENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.cLIENTSTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.CLIENTSTableAdapter();
            aDDRESSLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            cLIENT_IDLabel = new System.Windows.Forms.Label();
            this.bookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDDRESSLabel
            // 
            aDDRESSLabel.AutoSize = true;
            aDDRESSLabel.Location = new System.Drawing.Point(954, 101);
            aDDRESSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aDDRESSLabel.Name = "aDDRESSLabel";
            aDDRESSLabel.Size = new System.Drawing.Size(129, 34);
            aDDRESSLabel.TabIndex = 26;
            aDDRESSLabel.Text = "Address:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(45, 104);
            pHONELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(109, 34);
            pHONELabel.TabIndex = 24;
            pHONELabel.Text = "Phone:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(455, 98);
            eMAILLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(103, 34);
            eMAILLabel.TabIndex = 22;
            eMAILLabel.Text = "E-Mail:";
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(954, 40);
            lNAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(141, 34);
            lNAMELabel.TabIndex = 20;
            lNAMELabel.Text = "Surname:";
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(455, 37);
            fNAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(164, 34);
            fNAMELabel.TabIndex = 18;
            fNAMELabel.Text = "First Name:";
            // 
            // cLIENT_IDLabel
            // 
            cLIENT_IDLabel.AutoSize = true;
            cLIENT_IDLabel.Location = new System.Drawing.Point(45, 37);
            cLIENT_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cLIENT_IDLabel.Name = "cLIENT_IDLabel";
            cLIENT_IDLabel.Size = new System.Drawing.Size(146, 34);
            cLIENT_IDLabel.TabIndex = 17;
            cLIENT_IDLabel.Text = "CLIENT ID:";
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(this.addButton);
            this.bookListPanel.Controls.Add(this.updateButton);
            this.bookListPanel.Controls.Add(this.pHONETextBox);
            this.bookListPanel.Controls.Add(this.aDDRESSTextBox);
            this.bookListPanel.Controls.Add(fNAMELabel);
            this.bookListPanel.Controls.Add(this.fNAMETextBox);
            this.bookListPanel.Controls.Add(this.searchCustomerButton);
            this.bookListPanel.Controls.Add(this.customerDataGridView);
            this.bookListPanel.Controls.Add(aDDRESSLabel);
            this.bookListPanel.Controls.Add(pHONELabel);
            this.bookListPanel.Controls.Add(eMAILLabel);
            this.bookListPanel.Controls.Add(this.eMAILTextBox);
            this.bookListPanel.Controls.Add(lNAMELabel);
            this.bookListPanel.Controls.Add(this.lNAMETextBox);
            this.bookListPanel.Controls.Add(cLIENT_IDLabel);
            this.bookListPanel.Controls.Add(this.cLIENT_IDTextBox);
            this.bookListPanel.Controls.Add(this.deleteButton);
            this.bookListPanel.Controls.Add(this.closeButton);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(12, 12);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(1486, 794);
            this.bookListPanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(51, 709);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(191, 55);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
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
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(158, 101);
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
            this.aDDRESSTextBox.Location = new System.Drawing.Point(1102, 101);
            this.aDDRESSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            this.aDDRESSTextBox.Size = new System.Drawing.Size(330, 41);
            this.aDDRESSTextBox.TabIndex = 28;
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(627, 37);
            this.fNAMETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(319, 41);
            this.fNAMETextBox.TabIndex = 21;
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.searchCustomerButton.FlatAppearance.BorderSize = 0;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomerButton.Image")));
            this.searchCustomerButton.Location = new System.Drawing.Point(380, 101);
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
            this.fNAMEDataGridViewTextBoxColumn,
            this.lNAMEDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.cLIENTSBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(51, 177);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(1381, 502);
            this.customerDataGridView.TabIndex = 29;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.HeaderText = "CLIENT_ID";
            this.cLIENTIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            this.cLIENTIDDataGridViewTextBoxColumn.Width = 190;
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "FNAME";
            this.fNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            this.fNAMEDataGridViewTextBoxColumn.Width = 180;
            // 
            // lNAMEDataGridViewTextBoxColumn
            // 
            this.lNAMEDataGridViewTextBoxColumn.DataPropertyName = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.HeaderText = "LNAME";
            this.lNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNAMEDataGridViewTextBoxColumn.Name = "lNAMEDataGridViewTextBoxColumn";
            this.lNAMEDataGridViewTextBoxColumn.Width = 190;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.Width = 210;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 215;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.Width = 342;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(558, 98);
            this.eMAILTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(388, 41);
            this.eMAILTextBox.TabIndex = 25;
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(1122, 33);
            this.lNAMETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(310, 41);
            this.lNAMETextBox.TabIndex = 23;
            // 
            // cLIENT_IDTextBox
            // 
            this.cLIENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "CLIENT_ID", true));
            this.cLIENT_IDTextBox.Location = new System.Drawing.Point(199, 37);
            this.cLIENT_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cLIENT_IDTextBox.Name = "cLIENT_IDTextBox";
            this.cLIENT_IDTextBox.ReadOnly = true;
            this.cLIENT_IDTextBox.Size = new System.Drawing.Size(203, 41);
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
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1241, 709);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 55);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeAddCustomerButton_Click);
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1510, 817);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
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
        private System.Windows.Forms.TextBox fNAMETextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox lNAMETextBox;
        private System.Windows.Forms.TextBox cLIENT_IDTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
    }
}