namespace Leksi_Book_Shop.Resources
{
    partial class Book_List_Form
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
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.closeBookListButton = new System.Windows.Forms.Button();
            this.deleteBookListButton = new System.Windows.Forms.Button();
            this.addBookListButton = new System.Windows.Forms.Button();
            this.bookListGroupBox = new System.Windows.Forms.GroupBox();
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.updateBookListButton = new System.Windows.Forms.Button();
            this.bookListPanel.SuspendLayout();
            this.bookListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(this.closeBookListButton);
            this.bookListPanel.Controls.Add(this.deleteBookListButton);
            this.bookListPanel.Controls.Add(this.updateBookListButton);
            this.bookListPanel.Controls.Add(this.addBookListButton);
            this.bookListPanel.Controls.Add(this.bookListGroupBox);
            this.bookListPanel.Location = new System.Drawing.Point(12, 12);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(909, 530);
            this.bookListPanel.TabIndex = 0;
            // 
            // closeBookListButton
            // 
            this.closeBookListButton.Location = new System.Drawing.Point(785, 486);
            this.closeBookListButton.Name = "closeBookListButton";
            this.closeBookListButton.Size = new System.Drawing.Size(112, 36);
            this.closeBookListButton.TabIndex = 3;
            this.closeBookListButton.Text = "&Close";
            this.closeBookListButton.UseVisualStyleBackColor = true;
            // 
            // deleteBookListButton
            // 
            this.deleteBookListButton.Location = new System.Drawing.Point(557, 488);
            this.deleteBookListButton.Name = "deleteBookListButton";
            this.deleteBookListButton.Size = new System.Drawing.Size(108, 33);
            this.deleteBookListButton.TabIndex = 2;
            this.deleteBookListButton.Text = "&Delete";
            this.deleteBookListButton.UseVisualStyleBackColor = true;
            // 
            // addBookListButton
            // 
            this.addBookListButton.Location = new System.Drawing.Point(29, 488);
            this.addBookListButton.Name = "addBookListButton";
            this.addBookListButton.Size = new System.Drawing.Size(108, 33);
            this.addBookListButton.TabIndex = 2;
            this.addBookListButton.Text = "&Add";
            this.addBookListButton.UseVisualStyleBackColor = true;
            // 
            // bookListGroupBox
            // 
            this.bookListGroupBox.Controls.Add(this.bookListDataGridView);
            this.bookListGroupBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListGroupBox.Location = new System.Drawing.Point(16, 14);
            this.bookListGroupBox.Name = "bookListGroupBox";
            this.bookListGroupBox.Size = new System.Drawing.Size(881, 462);
            this.bookListGroupBox.TabIndex = 1;
            this.bookListGroupBox.TabStop = false;
            this.bookListGroupBox.Text = "Book Database";
            // 
            // bookListDataGridView
            // 
            this.bookListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookListDataGridView.Location = new System.Drawing.Point(3, 29);
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.Size = new System.Drawing.Size(875, 430);
            this.bookListDataGridView.TabIndex = 0;
            // 
            // updateBookListButton
            // 
            this.updateBookListButton.Location = new System.Drawing.Point(249, 489);
            this.updateBookListButton.Name = "updateBookListButton";
            this.updateBookListButton.Size = new System.Drawing.Size(108, 33);
            this.updateBookListButton.TabIndex = 2;
            this.updateBookListButton.Text = "&Update";
            this.updateBookListButton.UseVisualStyleBackColor = true;
            // 
            // Book_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.bookListPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Book_List_Form";
            this.Text = "Book_List_Form";
            this.Load += new System.EventHandler(this.Book_List_Form_Load);
            this.bookListPanel.ResumeLayout(false);
            this.bookListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.DataGridView bookListDataGridView;
        private System.Windows.Forms.GroupBox bookListGroupBox;
        private System.Windows.Forms.Button closeBookListButton;
        private System.Windows.Forms.Button deleteBookListButton;
        private System.Windows.Forms.Button addBookListButton;
        private System.Windows.Forms.Button updateBookListButton;
    }
}