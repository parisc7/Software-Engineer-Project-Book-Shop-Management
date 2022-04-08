namespace Leksi_Book_Shop
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderNoTxtBox = new System.Windows.Forms.TextBox();
            this.customerTxtBox = new System.Windows.Forms.TextBox();
            this.timeMskdTxtBox = new System.Windows.Forms.MaskedTextBox();
            this.nameSurnameTxttBox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.currentOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.booksButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.dailyTotalButton = new System.Windows.Forms.Button();
            this.mailButton = new System.Windows.Forms.Button();
            this.employeesButton = new System.Windows.Forms.Button();
            this.customerButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.companieLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.searchCustomerButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrderDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.companieLogoPictureBox);
            this.panel2.Controls.Add(this.orderNoTxtBox);
            this.panel2.Controls.Add(this.searchCustomerButton);
            this.panel2.Controls.Add(this.customerTxtBox);
            this.panel2.Controls.Add(this.timeMskdTxtBox);
            this.panel2.Controls.Add(this.nameSurnameTxttBox);
            this.panel2.Controls.Add(this.totalPriceLabel);
            this.panel2.Controls.Add(this.payButton);
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.currentOrderDataGridView);
            this.panel2.Location = new System.Drawing.Point(277, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 635);
            this.panel2.TabIndex = 2;
            // 
            // orderNoTxtBox
            // 
            this.orderNoTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orderNoTxtBox.Enabled = false;
            this.orderNoTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNoTxtBox.Location = new System.Drawing.Point(338, 34);
            this.orderNoTxtBox.Name = "orderNoTxtBox";
            this.orderNoTxtBox.Size = new System.Drawing.Size(207, 41);
            this.orderNoTxtBox.TabIndex = 8;
            // 
            // customerTxtBox
            // 
            this.customerTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.customerTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTxtBox.Location = new System.Drawing.Point(617, 34);
            this.customerTxtBox.Name = "customerTxtBox";
            this.customerTxtBox.Size = new System.Drawing.Size(207, 41);
            this.customerTxtBox.TabIndex = 6;
            // 
            // timeMskdTxtBox
            // 
            this.timeMskdTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.timeMskdTxtBox.Enabled = false;
            this.timeMskdTxtBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeMskdTxtBox.Location = new System.Drawing.Point(56, 34);
            this.timeMskdTxtBox.Mask = "00/00/0000 90:00";
            this.timeMskdTxtBox.Name = "timeMskdTxtBox";
            this.timeMskdTxtBox.Size = new System.Drawing.Size(207, 41);
            this.timeMskdTxtBox.TabIndex = 5;
            this.timeMskdTxtBox.ValidatingType = typeof(System.DateTime);
            // 
            // nameSurnameTxttBox
            // 
            this.nameSurnameTxttBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameSurnameTxttBox.Enabled = false;
            this.nameSurnameTxttBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSurnameTxttBox.Location = new System.Drawing.Point(49, 94);
            this.nameSurnameTxttBox.Name = "nameSurnameTxttBox";
            this.nameSurnameTxttBox.ReadOnly = true;
            this.nameSurnameTxttBox.Size = new System.Drawing.Size(835, 41);
            this.nameSurnameTxttBox.TabIndex = 4;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(689, 570);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(99, 34);
            this.totalPriceLabel.TabIndex = 3;
            this.totalPriceLabel.Text = "label1";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.payButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payButton.Location = new System.Drawing.Point(265, 563);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(152, 46);
            this.payButton.TabIndex = 2;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(46, 563);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(152, 46);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // currentOrderDataGridView
            // 
            this.currentOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentOrderDataGridView.Location = new System.Drawing.Point(45, 151);
            this.currentOrderDataGridView.Name = "currentOrderDataGridView";
            this.currentOrderDataGridView.RowHeadersWidth = 51;
            this.currentOrderDataGridView.RowTemplate.Height = 24;
            this.currentOrderDataGridView.Size = new System.Drawing.Size(836, 381);
            this.currentOrderDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.booksButton);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.dailyTotalButton);
            this.panel1.Controls.Add(this.mailButton);
            this.panel1.Controls.Add(this.employeesButton);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 635);
            this.panel1.TabIndex = 3;
            // 
            // booksButton
            // 
            this.booksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.booksButton.AutoSize = true;
            this.booksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.booksButton.FlatAppearance.BorderSize = 0;
            this.booksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Image = ((System.Drawing.Image)(resources.GetObject("booksButton.Image")));
            this.booksButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booksButton.Location = new System.Drawing.Point(20, 310);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(239, 70);
            this.booksButton.TabIndex = 5;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = false;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.AutoSize = true;
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutButton.Location = new System.Drawing.Point(20, 538);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(239, 70);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // dailyTotalButton
            // 
            this.dailyTotalButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyTotalButton.AutoSize = true;
            this.dailyTotalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.dailyTotalButton.FlatAppearance.BorderSize = 0;
            this.dailyTotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dailyTotalButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyTotalButton.Image = ((System.Drawing.Image)(resources.GetObject("dailyTotalButton.Image")));
            this.dailyTotalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dailyTotalButton.Location = new System.Drawing.Point(20, 462);
            this.dailyTotalButton.Name = "dailyTotalButton";
            this.dailyTotalButton.Size = new System.Drawing.Size(239, 70);
            this.dailyTotalButton.TabIndex = 7;
            this.dailyTotalButton.Text = "      Daily total";
            this.dailyTotalButton.UseVisualStyleBackColor = false;
            // 
            // mailButton
            // 
            this.mailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailButton.AutoSize = true;
            this.mailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.mailButton.FlatAppearance.BorderSize = 0;
            this.mailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mailButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailButton.Image = ((System.Drawing.Image)(resources.GetObject("mailButton.Image")));
            this.mailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mailButton.Location = new System.Drawing.Point(20, 386);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(239, 70);
            this.mailButton.TabIndex = 6;
            this.mailButton.Text = "E-mail";
            this.mailButton.UseVisualStyleBackColor = false;
            // 
            // employeesButton
            // 
            this.employeesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.employeesButton.AutoSize = true;
            this.employeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.employeesButton.FlatAppearance.BorderSize = 0;
            this.employeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesButton.Image = ((System.Drawing.Image)(resources.GetObject("employeesButton.Image")));
            this.employeesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeesButton.Location = new System.Drawing.Point(20, 234);
            this.employeesButton.Name = "employeesButton";
            this.employeesButton.Size = new System.Drawing.Size(239, 70);
            this.employeesButton.TabIndex = 4;
            this.employeesButton.Text = "Employees";
            this.employeesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.employeesButton.UseVisualStyleBackColor = false;
            // 
            // customerButton
            // 
            this.customerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerButton.AutoSize = true;
            this.customerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.customerButton.FlatAppearance.BorderSize = 0;
            this.customerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerButton.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerButton.Image = ((System.Drawing.Image)(resources.GetObject("customerButton.Image")));
            this.customerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customerButton.Location = new System.Drawing.Point(20, 160);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(239, 70);
            this.customerButton.TabIndex = 3;
            this.customerButton.Text = "     Customer";
            this.customerButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(44, 17);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(191, 124);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // companieLogoPictureBox
            // 
            this.companieLogoPictureBox.Image = global::Leksi_Book_Shop.Properties.Resources.Softtsing;
            this.companieLogoPictureBox.Location = new System.Drawing.Point(810, 599);
            this.companieLogoPictureBox.Name = "companieLogoPictureBox";
            this.companieLogoPictureBox.Size = new System.Drawing.Size(80, 23);
            this.companieLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.companieLogoPictureBox.TabIndex = 9;
            this.companieLogoPictureBox.TabStop = false;
            this.companieLogoPictureBox.Click += new System.EventHandler(this.companieLogoPictureBox_Click);
            // 
            // searchCustomerButton
            // 
            this.searchCustomerButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchCustomerButton.FlatAppearance.BorderSize = 0;
            this.searchCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustomerButton.Image = ((System.Drawing.Image)(resources.GetObject("searchCustomerButton.Image")));
            this.searchCustomerButton.Location = new System.Drawing.Point(832, 29);
            this.searchCustomerButton.Name = "searchCustomerButton";
            this.searchCustomerButton.Size = new System.Drawing.Size(58, 46);
            this.searchCustomerButton.TabIndex = 7;
            this.searchCustomerButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1198, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentOrderDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companieLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button dailyTotalButton;
        private System.Windows.Forms.Button mailButton;
        private System.Windows.Forms.Button employeesButton;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView currentOrderDataGridView;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.MaskedTextBox timeMskdTxtBox;
        private System.Windows.Forms.TextBox nameSurnameTxttBox;
        private System.Windows.Forms.TextBox customerTxtBox;
        private System.Windows.Forms.Button searchCustomerButton;
        private System.Windows.Forms.TextBox orderNoTxtBox;
        private System.Windows.Forms.PictureBox companieLogoPictureBox;
    }
}