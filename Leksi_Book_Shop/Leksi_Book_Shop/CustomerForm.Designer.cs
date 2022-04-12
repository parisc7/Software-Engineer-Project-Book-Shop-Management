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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.customerTab = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.closeAddCustomerButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.customerTxtBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.closeFindCustomerButton = new System.Windows.Forms.Button();
            this.deleteCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_bookshopDataSet = new Leksi_Book_Shop.lexi_bookshopDataSet();
            this.customerTableAdapter = new Leksi_Book_Shop.lexi_bookshopDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.lexi_bookshopDataSetTableAdapters.TableAdapterManager();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltypointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookListPanel.SuspendLayout();
            this.customerTab.SuspendLayout();
            this.addTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_bookshopDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(this.customerTab);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(9, 10);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(1059, 522);
            this.bookListPanel.TabIndex = 2;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.addTab);
            this.customerTab.Controls.Add(this.tabPage2);
            this.customerTab.Location = new System.Drawing.Point(10, 3);
            this.customerTab.Margin = new System.Windows.Forms.Padding(2);
            this.customerTab.Name = "customerTab";
            this.customerTab.SelectedIndex = 0;
            this.customerTab.Size = new System.Drawing.Size(1037, 506);
            this.customerTab.TabIndex = 0;
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.addTab.Controls.Add(this.addCustomerButton);
            this.addTab.Controls.Add(this.closeAddCustomerButton);
            this.addTab.Location = new System.Drawing.Point(4, 34);
            this.addTab.Margin = new System.Windows.Forms.Padding(2);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(2);
            this.addTab.Size = new System.Drawing.Size(1029, 468);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "ADD";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Location = new System.Drawing.Point(743, 402);
            this.addCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(101, 36);
            this.addCustomerButton.TabIndex = 10;
            this.addCustomerButton.Text = "&ADD";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            // 
            // closeAddCustomerButton
            // 
            this.closeAddCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeAddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAddCustomerButton.Location = new System.Drawing.Point(569, 402);
            this.closeAddCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeAddCustomerButton.Name = "closeAddCustomerButton";
            this.closeAddCustomerButton.Size = new System.Drawing.Size(101, 36);
            this.closeAddCustomerButton.TabIndex = 9;
            this.closeAddCustomerButton.Text = "&Close";
            this.closeAddCustomerButton.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.tabPage2.Controls.Add(this.searchCustomerButton);
            this.tabPage2.Controls.Add(this.customerTxtBox);
            this.tabPage2.Controls.Add(this.customerDataGridView);
            this.tabPage2.Controls.Add(this.closeFindCustomerButton);
            this.tabPage2.Controls.Add(this.deleteCustomerButton);
            this.tabPage2.Controls.Add(this.updateCustomerButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1029, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FIND";
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.searchCustomerButton.FlatAppearance.BorderSize = 0;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomerButton.Image")));
            this.searchCustomerButton.Location = new System.Drawing.Point(723, 16);
            this.searchCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(44, 37);
            this.searchCustomerButton.TabIndex = 11;
            this.searchCustomerButton.UseVisualStyleBackColor = false;
            // 
            // customerTxtBox
            // 
            this.customerTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTxtBox.Location = new System.Drawing.Point(172, 19);
            this.customerTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerTxtBox.Name = "customerTxtBox";
            this.customerTxtBox.Size = new System.Drawing.Size(506, 34);
            this.customerTxtBox.TabIndex = 10;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailaddressDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.loyaltypointsDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(28, 85);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(856, 312);
            this.customerDataGridView.TabIndex = 9;
            // 
            // closeFindCustomerButton
            // 
            this.closeFindCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeFindCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFindCustomerButton.Location = new System.Drawing.Point(714, 417);
            this.closeFindCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeFindCustomerButton.Name = "closeFindCustomerButton";
            this.closeFindCustomerButton.Size = new System.Drawing.Size(101, 36);
            this.closeFindCustomerButton.TabIndex = 8;
            this.closeFindCustomerButton.Text = "&Close";
            this.closeFindCustomerButton.UseVisualStyleBackColor = false;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteCustomerButton.FlatAppearance.BorderSize = 0;
            this.deleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerButton.Location = new System.Drawing.Point(398, 417);
            this.deleteCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(101, 36);
            this.deleteCustomerButton.TabIndex = 5;
            this.deleteCustomerButton.Text = "&Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCustomerButton.Location = new System.Drawing.Point(82, 417);
            this.updateCustomerButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(101, 36);
            this.updateCustomerButton.TabIndex = 7;
            this.updateCustomerButton.Text = "&Update";
            this.updateCustomerButton.UseVisualStyleBackColor = false;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.lexi_bookshopDataSet;
            // 
            // lexi_bookshopDataSet
            // 
            this.lexi_bookshopDataSet.DataSetName = "lexi_bookshopDataSet";
            this.lexi_bookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.DB_BookTableAdapter = null;
            this.tableAdapterManager.DB_customerTableAdapter = null;
            this.tableAdapterManager.DB_MainTableAdapter = null;
            this.tableAdapterManager.DB_orderTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Leksi_Book_Shop.lexi_bookshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // emailaddressDataGridViewTextBoxColumn
            // 
            this.emailaddressDataGridViewTextBoxColumn.DataPropertyName = "email_address";
            this.emailaddressDataGridViewTextBoxColumn.HeaderText = "email_address";
            this.emailaddressDataGridViewTextBoxColumn.Name = "emailaddressDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // loyaltypointsDataGridViewTextBoxColumn
            // 
            this.loyaltypointsDataGridViewTextBoxColumn.DataPropertyName = "loyalty_points";
            this.loyaltypointsDataGridViewTextBoxColumn.HeaderText = "loyalty_points";
            this.loyaltypointsDataGridViewTextBoxColumn.Name = "loyaltypointsDataGridViewTextBoxColumn";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1079, 542);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.bookListPanel.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_bookshopDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.TabControl customerTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button closeFindCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.TextBox customerTxtBox;
        private System.Windows.Forms.Button closeAddCustomerButton;
        private System.Windows.Forms.Button addCustomerButton;
        private lexi_bookshopDataSet lexi_bookshopDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private lexi_bookshopDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private lexi_bookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltypointsDataGridViewTextBoxColumn;
    }
}