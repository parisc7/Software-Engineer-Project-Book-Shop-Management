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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
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
            this.bookListPanel.SuspendLayout();
            this.customerTab.SuspendLayout();
            this.addTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(this.customerTab);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(12, 12);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(1258, 643);
            this.bookListPanel.TabIndex = 3;
            // 
            // customerTab
            // 
            this.customerTab.Controls.Add(this.addTab);
            this.customerTab.Controls.Add(this.tabPage2);
            this.customerTab.Location = new System.Drawing.Point(14, 4);
            this.customerTab.Name = "customerTab";
            this.customerTab.SelectedIndex = 0;
            this.customerTab.Size = new System.Drawing.Size(1231, 623);
            this.customerTab.TabIndex = 0;
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.addTab.Controls.Add(this.addCustomerButton);
            this.addTab.Controls.Add(this.closeAddCustomerButton);
            this.addTab.Location = new System.Drawing.Point(4, 42);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(1223, 577);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "ADD";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCustomerButton.Location = new System.Drawing.Point(991, 495);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(135, 44);
            this.addCustomerButton.TabIndex = 10;
            this.addCustomerButton.Text = "&ADD";
            this.addCustomerButton.UseVisualStyleBackColor = false;
            // 
            // closeAddCustomerButton
            // 
            this.closeAddCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeAddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAddCustomerButton.Location = new System.Drawing.Point(759, 495);
            this.closeAddCustomerButton.Name = "closeAddCustomerButton";
            this.closeAddCustomerButton.Size = new System.Drawing.Size(135, 44);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1223, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "FIND";
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.searchCustomerButton.FlatAppearance.BorderSize = 0;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomerButton.Image")));
            this.searchCustomerButton.Location = new System.Drawing.Point(964, 20);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(58, 46);
            this.searchCustomerButton.TabIndex = 11;
            this.searchCustomerButton.UseVisualStyleBackColor = false;
            // 
            // customerTxtBox
            // 
            this.customerTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTxtBox.Location = new System.Drawing.Point(229, 23);
            this.customerTxtBox.Name = "customerTxtBox";
            this.customerTxtBox.Size = new System.Drawing.Size(674, 41);
            this.customerTxtBox.TabIndex = 10;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(38, 105);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(1141, 384);
            this.customerDataGridView.TabIndex = 9;
            // 
            // closeFindCustomerButton
            // 
            this.closeFindCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeFindCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFindCustomerButton.Location = new System.Drawing.Point(952, 513);
            this.closeFindCustomerButton.Name = "closeFindCustomerButton";
            this.closeFindCustomerButton.Size = new System.Drawing.Size(135, 44);
            this.closeFindCustomerButton.TabIndex = 8;
            this.closeFindCustomerButton.Text = "&Close";
            this.closeFindCustomerButton.UseVisualStyleBackColor = false;
            // 
            // deleteCustomerButton
            // 
            this.deleteCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteCustomerButton.FlatAppearance.BorderSize = 0;
            this.deleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCustomerButton.Location = new System.Drawing.Point(530, 513);
            this.deleteCustomerButton.Name = "deleteCustomerButton";
            this.deleteCustomerButton.Size = new System.Drawing.Size(135, 44);
            this.deleteCustomerButton.TabIndex = 5;
            this.deleteCustomerButton.Text = "&Delete";
            this.deleteCustomerButton.UseVisualStyleBackColor = false;
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCustomerButton.Location = new System.Drawing.Point(109, 513);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(135, 44);
            this.updateCustomerButton.TabIndex = 7;
            this.updateCustomerButton.Text = "&Update";
            this.updateCustomerButton.UseVisualStyleBackColor = false;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1282, 667);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeesForm";
            this.Text = "EmploymentsForm";
            this.bookListPanel.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.TabControl customerTab;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button closeAddCustomerButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.TextBox customerTxtBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button closeFindCustomerButton;
        private System.Windows.Forms.Button deleteCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
    }
}