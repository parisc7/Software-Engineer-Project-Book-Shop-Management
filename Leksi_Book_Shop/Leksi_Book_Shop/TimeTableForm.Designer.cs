namespace Leksi_Book_Shop
{
    partial class TimeTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTableForm));
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.tIMETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIMETABLETableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TIMETABLETableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.eMPLOYEE_IDTextBox = new System.Windows.Forms.TextBox();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.uSERNAMETextBox = new System.Windows.Forms.TextBox();
            this.pASSWORDTextBox = new System.Windows.Forms.TextBox();
            this.lOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            eMPLOYEE_IDLabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            uSERNAMELabel = new System.Windows.Forms.Label();
            pASSWORDLabel = new System.Windows.Forms.Label();
            this.bookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bookListPanel
            // 
            this.bookListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.bookListPanel.Controls.Add(eMPLOYEE_IDLabel);
            this.bookListPanel.Controls.Add(this.eMPLOYEE_IDTextBox);
            this.bookListPanel.Controls.Add(fNAMELabel);
            this.bookListPanel.Controls.Add(this.fNAMETextBox);
            this.bookListPanel.Controls.Add(lNAMELabel);
            this.bookListPanel.Controls.Add(this.lNAMETextBox);
            this.bookListPanel.Controls.Add(pHONELabel);
            this.bookListPanel.Controls.Add(this.pHONETextBox);
            this.bookListPanel.Controls.Add(uSERNAMELabel);
            this.bookListPanel.Controls.Add(this.uSERNAMETextBox);
            this.bookListPanel.Controls.Add(pASSWORDLabel);
            this.bookListPanel.Controls.Add(this.pASSWORDTextBox);
            this.bookListPanel.Controls.Add(this.closeButton);
            this.bookListPanel.Controls.Add(this.customerDataGridView);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(9, 9);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(754, 652);
            this.bookListPanel.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(590, 587);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(143, 45);
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
            this.lOGINDataGridViewTextBoxColumn,
            this.lOGOUTDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.tIMETABLEBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(284, 28);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(450, 543);
            this.customerDataGridView.TabIndex = 30;
            // 
            // lexi_BookshopDataSet
            // 
            this.lexi_BookshopDataSet.DataSetName = "Lexi_BookshopDataSet";
            this.lexi_BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIMETABLEBindingSource
            // 
            this.tIMETABLEBindingSource.DataMember = "TIMETABLE";
            this.tIMETABLEBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // tIMETABLETableAdapter
            // 
            this.tIMETABLETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOOKSTableAdapter = null;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.EMPLOYEESTableAdapter = this.eMPLOYEESTableAdapter;
            this.tableAdapterManager.ORDER_LISTTableAdapter = null;
            this.tableAdapterManager.ORDERTableAdapter = null;
            this.tableAdapterManager.TIMETABLETableAdapter = this.tIMETABLETableAdapter;
            this.tableAdapterManager.UpdateOrder = Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // eMPLOYEE_IDLabel
            // 
            eMPLOYEE_IDLabel.AutoSize = true;
            eMPLOYEE_IDLabel.Location = new System.Drawing.Point(3, 62);
            eMPLOYEE_IDLabel.Name = "eMPLOYEE_IDLabel";
            eMPLOYEE_IDLabel.Size = new System.Drawing.Size(161, 25);
            eMPLOYEE_IDLabel.TabIndex = 32;
            eMPLOYEE_IDLabel.Text = "EMPLOYEE ID:";
            // 
            // eMPLOYEE_IDTextBox
            // 
            this.eMPLOYEE_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "EMPLOYEE_ID", true));
            this.eMPLOYEE_IDTextBox.Location = new System.Drawing.Point(170, 59);
            this.eMPLOYEE_IDTextBox.Name = "eMPLOYEE_IDTextBox";
            this.eMPLOYEE_IDTextBox.Size = new System.Drawing.Size(100, 34);
            this.eMPLOYEE_IDTextBox.TabIndex = 33;
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(3, 102);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(97, 25);
            fNAMELabel.TabIndex = 34;
            fNAMELabel.Text = "FNAME:";
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(170, 99);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.Size = new System.Drawing.Size(100, 34);
            this.fNAMETextBox.TabIndex = 35;
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(3, 142);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(96, 25);
            lNAMELabel.TabIndex = 36;
            lNAMELabel.Text = "LNAME:";
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(170, 139);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.Size = new System.Drawing.Size(100, 34);
            this.lNAMETextBox.TabIndex = 37;
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(3, 182);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(93, 25);
            pHONELabel.TabIndex = 38;
            pHONELabel.Text = "PHONE:";
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(170, 179);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.Size = new System.Drawing.Size(100, 34);
            this.pHONETextBox.TabIndex = 39;
            // 
            // uSERNAMELabel
            // 
            uSERNAMELabel.AutoSize = true;
            uSERNAMELabel.Location = new System.Drawing.Point(3, 222);
            uSERNAMELabel.Name = "uSERNAMELabel";
            uSERNAMELabel.Size = new System.Drawing.Size(137, 25);
            uSERNAMELabel.TabIndex = 40;
            uSERNAMELabel.Text = "USERNAME:";
            // 
            // uSERNAMETextBox
            // 
            this.uSERNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "USERNAME", true));
            this.uSERNAMETextBox.Location = new System.Drawing.Point(170, 219);
            this.uSERNAMETextBox.Name = "uSERNAMETextBox";
            this.uSERNAMETextBox.Size = new System.Drawing.Size(100, 34);
            this.uSERNAMETextBox.TabIndex = 41;
            // 
            // pASSWORDLabel
            // 
            pASSWORDLabel.AutoSize = true;
            pASSWORDLabel.Location = new System.Drawing.Point(3, 262);
            pASSWORDLabel.Name = "pASSWORDLabel";
            pASSWORDLabel.Size = new System.Drawing.Size(141, 25);
            pASSWORDLabel.TabIndex = 42;
            pASSWORDLabel.Text = "PASSWORD:";
            // 
            // pASSWORDTextBox
            // 
            this.pASSWORDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "PASSWORD", true));
            this.pASSWORDTextBox.Location = new System.Drawing.Point(170, 259);
            this.pASSWORDTextBox.Name = "pASSWORDTextBox";
            this.pASSWORDTextBox.Size = new System.Drawing.Size(100, 34);
            this.pASSWORDTextBox.TabIndex = 43;
            // 
            // lOGINDataGridViewTextBoxColumn
            // 
            this.lOGINDataGridViewTextBoxColumn.DataPropertyName = "LOG_IN";
            this.lOGINDataGridViewTextBoxColumn.HeaderText = "LOG_IN";
            this.lOGINDataGridViewTextBoxColumn.Name = "lOGINDataGridViewTextBoxColumn";
            this.lOGINDataGridViewTextBoxColumn.Width = 197;
            // 
            // lOGOUTDataGridViewTextBoxColumn
            // 
            this.lOGOUTDataGridViewTextBoxColumn.DataPropertyName = "LOG_OUT";
            this.lOGOUTDataGridViewTextBoxColumn.HeaderText = "LOG_OUT";
            this.lOGOUTDataGridViewTextBoxColumn.Name = "lOGOUTDataGridViewTextBoxColumn";
            this.lOGOUTDataGridViewTextBoxColumn.Width = 197;
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(772, 663);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TimeTableForm";
            this.Text = "TimeTableForm";
            this.Load += new System.EventHandler(this.TimeTableForm_Load);
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bookListPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private Lexi_BookshopDataSet lexi_BookshopDataSet;
        private System.Windows.Forms.BindingSource tIMETABLEBindingSource;
        private Lexi_BookshopDataSetTableAdapters.TIMETABLETableAdapter tIMETABLETableAdapter;
        private Lexi_BookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private System.Windows.Forms.TextBox eMPLOYEE_IDTextBox;
        private System.Windows.Forms.TextBox fNAMETextBox;
        private System.Windows.Forms.TextBox lNAMETextBox;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox uSERNAMETextBox;
        private System.Windows.Forms.TextBox pASSWORDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGOUTDataGridViewTextBoxColumn;
    }
}