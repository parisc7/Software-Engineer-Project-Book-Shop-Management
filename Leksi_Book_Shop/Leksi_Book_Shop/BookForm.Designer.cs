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
            this.bOOKSTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.BOOKSTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            iSBNLabel.Location = new System.Drawing.Point(33, 26);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(64, 25);
            iSBNLabel.TabIndex = 39;
            iSBNLabel.Text = "ISBN:";
            // 
            // aUTHORSLabel
            // 
            aUTHORSLabel.AutoSize = true;
            aUTHORSLabel.Location = new System.Drawing.Point(282, 32);
            aUTHORSLabel.Name = "aUTHORSLabel";
            aUTHORSLabel.Size = new System.Drawing.Size(119, 25);
            aUTHORSLabel.TabIndex = 40;
            aUTHORSLabel.Text = "AUTHORS:";
            // 
            // pUBLISHERSLabel
            // 
            pUBLISHERSLabel.AutoSize = true;
            pUBLISHERSLabel.Location = new System.Drawing.Point(637, 32);
            pUBLISHERSLabel.Name = "pUBLISHERSLabel";
            pUBLISHERSLabel.Size = new System.Drawing.Size(137, 25);
            pUBLISHERSLabel.TabIndex = 41;
            pUBLISHERSLabel.Text = "PUBLISHERS:";
            // 
            // tITLELabel
            // 
            tITLELabel.AutoSize = true;
            tITLELabel.Location = new System.Drawing.Point(33, 94);
            tITLELabel.Name = "tITLELabel";
            tITLELabel.Size = new System.Drawing.Size(68, 25);
            tITLELabel.TabIndex = 42;
            tITLELabel.Text = "TITLE:";
            // 
            // pYEARLabel
            // 
            pYEARLabel.AutoSize = true;
            pYEARLabel.Location = new System.Drawing.Point(332, 103);
            pYEARLabel.Name = "pYEARLabel";
            pYEARLabel.Size = new System.Drawing.Size(87, 25);
            pYEARLabel.TabIndex = 43;
            pYEARLabel.Text = "PYEAR:";
            // 
            // pRICELabel
            // 
            pRICELabel.AutoSize = true;
            pRICELabel.Location = new System.Drawing.Point(800, 103);
            pRICELabel.Name = "pRICELabel";
            pRICELabel.Size = new System.Drawing.Size(80, 25);
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
            this.bookListPanel.Location = new System.Drawing.Point(9, 10);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(1113, 649);
            this.bookListPanel.TabIndex = 1;
            // 
            // pRICETextBox
            // 
            this.pRICETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PRICE", true));
            this.pRICETextBox.Location = new System.Drawing.Point(963, 94);
            this.pRICETextBox.Name = "pRICETextBox";
            this.pRICETextBox.Size = new System.Drawing.Size(100, 34);
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
            this.pYEARTextBox.Location = new System.Drawing.Point(445, 94);
            this.pYEARTextBox.Name = "pYEARTextBox";
            this.pYEARTextBox.Size = new System.Drawing.Size(224, 34);
            this.pYEARTextBox.TabIndex = 44;
            // 
            // tITLETextBox
            // 
            this.tITLETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "TITLE", true));
            this.tITLETextBox.Location = new System.Drawing.Point(103, 94);
            this.tITLETextBox.Name = "tITLETextBox";
            this.tITLETextBox.Size = new System.Drawing.Size(197, 34);
            this.tITLETextBox.TabIndex = 43;
            // 
            // pUBLISHERSTextBox
            // 
            this.pUBLISHERSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "PUBLISHERS", true));
            this.pUBLISHERSTextBox.Location = new System.Drawing.Point(805, 29);
            this.pUBLISHERSTextBox.Name = "pUBLISHERSTextBox";
            this.pUBLISHERSTextBox.Size = new System.Drawing.Size(259, 34);
            this.pUBLISHERSTextBox.TabIndex = 42;
            // 
            // aUTHORSTextBox
            // 
            this.aUTHORSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "AUTHORS", true));
            this.aUTHORSTextBox.Location = new System.Drawing.Point(407, 29);
            this.aUTHORSTextBox.Name = "aUTHORSTextBox";
            this.aUTHORSTextBox.Size = new System.Drawing.Size(224, 34);
            this.aUTHORSTextBox.TabIndex = 41;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bOOKSBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(103, 23);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(100, 34);
            this.iSBNTextBox.TabIndex = 40;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(28, 584);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(143, 45);
            this.addButton.TabIndex = 39;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(631, 584);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(143, 45);
            this.updateButton.TabIndex = 38;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(310, 584);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(143, 45);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(920, 584);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 45);
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
            this.bookDataGridView.Location = new System.Drawing.Point(28, 162);
            this.bookDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bookDataGridView.Name = "bookDataGridView";
            this.bookDataGridView.RowHeadersWidth = 51;
            this.bookDataGridView.RowTemplate.Height = 24;
            this.bookDataGridView.Size = new System.Drawing.Size(1036, 408);
            this.bookDataGridView.TabIndex = 31;
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
            // 
            // aUTHORSDataGridViewTextBoxColumn
            // 
            this.aUTHORSDataGridViewTextBoxColumn.DataPropertyName = "AUTHORS";
            this.aUTHORSDataGridViewTextBoxColumn.HeaderText = "AUTHORS";
            this.aUTHORSDataGridViewTextBoxColumn.Name = "aUTHORSDataGridViewTextBoxColumn";
            this.aUTHORSDataGridViewTextBoxColumn.Width = 200;
            // 
            // pUBLISHERSDataGridViewTextBoxColumn
            // 
            this.pUBLISHERSDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHERS";
            this.pUBLISHERSDataGridViewTextBoxColumn.HeaderText = "PUBLISHERS";
            this.pUBLISHERSDataGridViewTextBoxColumn.Name = "pUBLISHERSDataGridViewTextBoxColumn";
            this.pUBLISHERSDataGridViewTextBoxColumn.Width = 200;
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            this.tITLEDataGridViewTextBoxColumn.Width = 200;
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
            this.ClientSize = new System.Drawing.Size(1131, 663);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookForm";
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