namespace Leksi_Book_Shop
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.closeBookListButton = new System.Windows.Forms.Button();
            this.deleteBookListButton = new System.Windows.Forms.Button();
            this.bookListGroupBox = new System.Windows.Forms.GroupBox();
            this.bookListDataGridView = new System.Windows.Forms.DataGridView();
            this.addBookListButton = new System.Windows.Forms.Button();
            this.updateBookListButton = new System.Windows.Forms.Button();
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.BOOKSTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookListPanel.SuspendLayout();
            this.bookListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(this.closeBookListButton);
            this.bookListPanel.Controls.Add(this.deleteBookListButton);
            this.bookListPanel.Controls.Add(this.bookListGroupBox);
            this.bookListPanel.Controls.Add(this.addBookListButton);
            this.bookListPanel.Controls.Add(this.updateBookListButton);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(9, 10);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(799, 436);
            this.bookListPanel.TabIndex = 1;
            // 
            // closeBookListButton
            // 
            this.closeBookListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.closeBookListButton.Location = new System.Drawing.Point(572, 392);
            this.closeBookListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeBookListButton.Name = "closeBookListButton";
            this.closeBookListButton.Size = new System.Drawing.Size(101, 36);
            this.closeBookListButton.TabIndex = 3;
            this.closeBookListButton.Text = "&Close";
            this.closeBookListButton.UseVisualStyleBackColor = false;
            this.closeBookListButton.Click += new System.EventHandler(this.closeBookListButton_Click);
            // 
            // deleteBookListButton
            // 
            this.deleteBookListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.deleteBookListButton.Location = new System.Drawing.Point(376, 392);
            this.deleteBookListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBookListButton.Name = "deleteBookListButton";
            this.deleteBookListButton.Size = new System.Drawing.Size(101, 36);
            this.deleteBookListButton.TabIndex = 2;
            this.deleteBookListButton.Text = "&Delete";
            this.deleteBookListButton.UseVisualStyleBackColor = false;
            // 
            // bookListGroupBox
            // 
            this.bookListGroupBox.Controls.Add(this.bookListDataGridView);
            this.bookListGroupBox.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListGroupBox.Location = new System.Drawing.Point(12, 11);
            this.bookListGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookListGroupBox.Name = "bookListGroupBox";
            this.bookListGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookListGroupBox.Size = new System.Drawing.Size(771, 375);
            this.bookListGroupBox.TabIndex = 1;
            this.bookListGroupBox.TabStop = false;
            this.bookListGroupBox.Text = "Book Database";
            // 
            // bookListDataGridView
            // 
            this.bookListDataGridView.AutoGenerateColumns = false;
            this.bookListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.aUTHORSDataGridViewTextBoxColumn,
            this.pUBLISHERSDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.pYEARDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.bookListDataGridView.DataSource = this.bOOKSBindingSource;
            this.bookListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookListDataGridView.Location = new System.Drawing.Point(2, 28);
            this.bookListDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookListDataGridView.Name = "bookListDataGridView";
            this.bookListDataGridView.RowHeadersWidth = 51;
            this.bookListDataGridView.Size = new System.Drawing.Size(767, 345);
            this.bookListDataGridView.TabIndex = 0;
            // 
            // addBookListButton
            // 
            this.addBookListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.addBookListButton.Location = new System.Drawing.Point(12, 392);
            this.addBookListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBookListButton.Name = "addBookListButton";
            this.addBookListButton.Size = new System.Drawing.Size(101, 36);
            this.addBookListButton.TabIndex = 2;
            this.addBookListButton.Text = "&Add";
            this.addBookListButton.UseVisualStyleBackColor = false;
            // 
            // updateBookListButton
            // 
            this.updateBookListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.updateBookListButton.Location = new System.Drawing.Point(193, 392);
            this.updateBookListButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBookListButton.Name = "updateBookListButton";
            this.updateBookListButton.Size = new System.Drawing.Size(101, 36);
            this.updateBookListButton.TabIndex = 2;
            this.updateBookListButton.Text = "&Update";
            this.updateBookListButton.UseVisualStyleBackColor = false;
            // 
            // lexi_BookshopDataSet
            // 
            this.lexi_BookshopDataSet.DataSetName = "Lexi_BookshopDataSet";
            this.lexi_BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // bOOKSTableAdapter
            // 
            this.bOOKSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = this.bOOKSTableAdapter;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.EMPLOYEESTableAdapter = null;
            this.tableAdapterManager.ORDER_LISTTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 65;
            // 
            // aUTHORSDataGridViewTextBoxColumn
            // 
            this.aUTHORSDataGridViewTextBoxColumn.DataPropertyName = "AUTHORS";
            this.aUTHORSDataGridViewTextBoxColumn.HeaderText = "AUTHORS";
            this.aUTHORSDataGridViewTextBoxColumn.Name = "aUTHORSDataGridViewTextBoxColumn";
            this.aUTHORSDataGridViewTextBoxColumn.Width = 110;
            // 
            // pUBLISHERSDataGridViewTextBoxColumn
            // 
            this.pUBLISHERSDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHERS";
            this.pUBLISHERSDataGridViewTextBoxColumn.HeaderText = "PUBLISHERS";
            this.pUBLISHERSDataGridViewTextBoxColumn.Name = "pUBLISHERSDataGridViewTextBoxColumn";
            this.pUBLISHERSDataGridViewTextBoxColumn.Width = 130;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.Width = 70;
            // 
            // pYEARDataGridViewTextBoxColumn
            // 
            this.pYEARDataGridViewTextBoxColumn.DataPropertyName = "PYEAR";
            this.pYEARDataGridViewTextBoxColumn.HeaderText = "PYEAR";
            this.pYEARDataGridViewTextBoxColumn.Name = "pYEARDataGridViewTextBoxColumn";
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(819, 455);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookForm";
            this.Text = "Book_List";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.bookListPanel.ResumeLayout(false);
            this.bookListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.Button closeBookListButton;
        private System.Windows.Forms.Button deleteBookListButton;
        private System.Windows.Forms.Button updateBookListButton;
        private System.Windows.Forms.Button addBookListButton;
        private System.Windows.Forms.GroupBox bookListGroupBox;
        private System.Windows.Forms.DataGridView bookListDataGridView;
        private Lexi_BookshopDataSet lexi_BookshopDataSet;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private Lexi_BookshopDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private Lexi_BookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
    }
}