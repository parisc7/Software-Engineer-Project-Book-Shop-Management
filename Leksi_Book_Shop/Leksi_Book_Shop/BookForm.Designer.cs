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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label aUTHORSLabel;
            System.Windows.Forms.Label pUBLISHERSLabel;
            System.Windows.Forms.Label tITLELabel;
            System.Windows.Forms.Label pYEARLabel;
            System.Windows.Forms.Label pRICELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.pRICETextBox = new System.Windows.Forms.TextBox();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.pYEARTextBox = new System.Windows.Forms.TextBox();
            this.tITLETextBox = new System.Windows.Forms.TextBox();
            this.pUBLISHERSTextBox = new System.Windows.Forms.TextBox();
            this.aUTHORSTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.bookDataGridView = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.BOOKSTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            iSBNLabel = new System.Windows.Forms.Label();
            aUTHORSLabel = new System.Windows.Forms.Label();
            pUBLISHERSLabel = new System.Windows.Forms.Label();
            tITLELabel = new System.Windows.Forms.Label();
            pYEARLabel = new System.Windows.Forms.Label();
            pRICELabel = new System.Windows.Forms.Label();
            this.bookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(31, 43);
            iSBNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(79, 34);
            iSBNLabel.TabIndex = 39;
            iSBNLabel.Text = "ISBN:";
            // 
            // aUTHORSLabel
            // 
            aUTHORSLabel.AutoSize = true;
            aUTHORSLabel.Location = new System.Drawing.Point(430, 39);
            aUTHORSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            aUTHORSLabel.Name = "aUTHORSLabel";
            aUTHORSLabel.Size = new System.Drawing.Size(145, 34);
            aUTHORSLabel.TabIndex = 40;
            aUTHORSLabel.Text = "AUTHORS:";
            // 
            // pUBLISHERSLabel
            // 
            pUBLISHERSLabel.AutoSize = true;
            pUBLISHERSLabel.Location = new System.Drawing.Point(922, 39);
            pUBLISHERSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pUBLISHERSLabel.Name = "pUBLISHERSLabel";
            pUBLISHERSLabel.Size = new System.Drawing.Size(170, 34);
            pUBLISHERSLabel.TabIndex = 41;
            pUBLISHERSLabel.Text = "PUBLISHERS:";
            // 
            // tITLELabel
            // 
            tITLELabel.AutoSize = true;
            tITLELabel.Location = new System.Drawing.Point(31, 122);
            tITLELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tITLELabel.Name = "tITLELabel";
            tITLELabel.Size = new System.Drawing.Size(78, 34);
            tITLELabel.TabIndex = 42;
            tITLELabel.Text = "TITLE:";
            // 
            // pYEARLabel
            // 
            pYEARLabel.AutoSize = true;
            pYEARLabel.Location = new System.Drawing.Point(736, 119);
            pYEARLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pYEARLabel.Name = "pYEARLabel";
            pYEARLabel.Size = new System.Drawing.Size(110, 34);
            pYEARLabel.TabIndex = 43;
            pYEARLabel.Text = "PYEAR:";
            // 
            // pRICELabel
            // 
            pRICELabel.AutoSize = true;
            pRICELabel.Location = new System.Drawing.Point(1148, 119);
            pRICELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(100, 34);
            pRICELabel.TabIndex = 44;
            pRICELabel.Text = "PRICE:";
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(pRICELabel);
            this.bookListPanel.Controls.Add(this.pRICETextBox);
            this.bookListPanel.Controls.Add(pYEARLabel);
            this.bookListPanel.Controls.Add(this.pYEARTextBox);
            this.bookListPanel.Controls.Add(tITLELabel);
            this.bookListPanel.Controls.Add(this.tITLETextBox);
            this.bookListPanel.Controls.Add(pUBLISHERSLabel);
            this.bookListPanel.Controls.Add(this.pUBLISHERSTextBox);
            this.bookListPanel.Controls.Add(aUTHORSLabel);
            this.bookListPanel.Controls.Add(this.aUTHORSTextBox);
            this.bookListPanel.Controls.Add(iSBNLabel);
            this.bookListPanel.Controls.Add(this.iSBNTextBox);
            this.bookListPanel.Controls.Add(this.addButton);
            this.bookListPanel.Controls.Add(this.updateButton);
            this.bookListPanel.Controls.Add(this.deleteButton);
            this.bookListPanel.Controls.Add(this.closeButton);
            this.bookListPanel.Controls.Add(this.bookDataGridView);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(12, 12);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(1484, 793);
            this.bookListPanel.TabIndex = 1;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(1256, 116);
            this.pRICETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(160, 41);
            this.pRICETextBox.TabIndex = 45;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataMember = "BOOKS";
            this.bOOKSBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // lexi_BookshopDataSet
            // 
            this.lexi_BookshopDataSet.DataSetName = "Lexi_BookshopDataSet";
            this.lexi_BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pYEARTextBox
            // 
            this.pYEARTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PYEAR", true));
            this.pYEARTextBox.Location = new System.Drawing.Point(877, 116);
            this.pYEARTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pYEARTextBox.Name = "pYEARTextBox";
            this.pYEARTextBox.Size = new System.Drawing.Size(263, 41);
            this.pYEARTextBox.TabIndex = 44;
            // 
            // tITLETextBox
            // 
            this.tITLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "TITLE", true));
            this.tITLETextBox.Location = new System.Drawing.Point(130, 119);
            this.tITLETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tITLETextBox.Name = "tITLETextBox";
            this.tITLETextBox.Size = new System.Drawing.Size(598, 41);
            this.tITLETextBox.TabIndex = 43;
            // 
            // pUBLISHERSTextBox
            // 
            this.pUBLISHERSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PUBLISHERS", true));
            this.pUBLISHERSTextBox.Location = new System.Drawing.Point(1115, 36);
            this.pUBLISHERSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pUBLISHERSTextBox.Name = "pUBLISHERSTextBox";
            this.pUBLISHERSTextBox.Size = new System.Drawing.Size(302, 41);
            this.pUBLISHERSTextBox.TabIndex = 42;
            // 
            // aUTHORSTextBox
            // 
            this.aUTHORSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "AUTHORS", true));
            this.aUTHORSTextBox.Location = new System.Drawing.Point(583, 36);
            this.aUTHORSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.aUTHORSTextBox.Name = "aUTHORSTextBox";
            this.aUTHORSTextBox.Size = new System.Drawing.Size(331, 41);
            this.aUTHORSTextBox.TabIndex = 41;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(131, 36);
            this.iSBNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(291, 41);
            this.iSBNTextBox.TabIndex = 40;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(37, 719);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(191, 55);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(841, 719);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(191, 55);
            this.updateButton.TabIndex = 38;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(436, 719);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(191, 55);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1227, 719);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 55);
            this.closeButton.TabIndex = 36;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bookDataGridView
            // 
            this.bookDataGridView.AutoGenerateColumns = false;
            this.bookDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.aUTHORSDataGridViewTextBoxColumn,
            this.pUBLISHERSDataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.pYEARDataGridViewTextBoxColumn,
            this.pRICEDataGridViewTextBoxColumn});
            this.bookDataGridView.DataSource = this.bOOKSBindingSource;
            this.bookDataGridView.Location = new System.Drawing.Point(37, 199);
            this.bookDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowHeadersWidth = 51;
            this.bookDataGridView.RowTemplate.Height = 24;
            this.bookDataGridView.Size = new System.Drawing.Size(1381, 502);
            this.bookDataGridView.TabIndex = 31;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 200;
            // 
            // aUTHORSDataGridViewTextBoxColumn
            // 
            this.aUTHORSDataGridViewTextBoxColumn.DataPropertyName = "AUTHORS";
            this.aUTHORSDataGridViewTextBoxColumn.HeaderText = "AUTHORS";
            this.aUTHORSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aUTHORSDataGridViewTextBoxColumn.Name = "aUTHORSDataGridViewTextBoxColumn";
            this.aUTHORSDataGridViewTextBoxColumn.Width = 200;
            // 
            // pUBLISHERSDataGridViewTextBoxColumn
            // 
            this.pUBLISHERSDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHERS";
            this.pUBLISHERSDataGridViewTextBoxColumn.HeaderText = "PUBLISHERS";
            this.pUBLISHERSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pUBLISHERSDataGridViewTextBoxColumn.Name = "pUBLISHERSDataGridViewTextBoxColumn";
            this.pUBLISHERSDataGridViewTextBoxColumn.Width = 250;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.Width = 425;
            // 
            // pYEARDataGridViewTextBoxColumn
            // 
            this.pYEARDataGridViewTextBoxColumn.DataPropertyName = "PYEAR";
            this.pYEARDataGridViewTextBoxColumn.HeaderText = "PYEAR";
            this.pYEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pYEARDataGridViewTextBoxColumn.Name = "pYEARDataGridViewTextBoxColumn";
            this.pYEARDataGridViewTextBoxColumn.Width = 126;
            // 
            // pRICEDataGridViewTextBoxColumn
            // 
            this.pRICEDataGridViewTextBoxColumn.DataPropertyName = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.pRICEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pRICEDataGridViewTextBoxColumn.Name = "pRICEDataGridViewTextBoxColumn";
            this.pRICEDataGridViewTextBoxColumn.Width = 125;
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
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1508, 816);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_List";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
        private Lexi_BookshopDataSet lexi_BookshopDataSet;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private Lexi_BookshopDataSetTableAdapters.BOOKSTableAdapter bOOKSTableAdapter;
        private Lexi_BookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bookDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox pRICETextBox;
        private System.Windows.Forms.TextBox pYEARTextBox;
        private System.Windows.Forms.TextBox tITLETextBox;
        private System.Windows.Forms.TextBox pUBLISHERSTextBox;
        private System.Windows.Forms.TextBox aUTHORSTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRICEDataGridViewTextBoxColumn;
    }
}