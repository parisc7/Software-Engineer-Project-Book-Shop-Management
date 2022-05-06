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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTableForm));
            this.bookListPanel = new System.Windows.Forms.Panel();
            this.eMPLOYEE_IDTextBox = new System.Windows.Forms.TextBox();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.fNAMETextBox = new System.Windows.Forms.TextBox();
            this.lNAMETextBox = new System.Windows.Forms.TextBox();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.lOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOGOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIMETABLETableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TIMETABLETableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.eMPLOYEESTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter();
            eMPLOYEE_IDLabel = new System.Windows.Forms.Label();
            fNAMELabel = new System.Windows.Forms.Label();
            lNAMELabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            this.bookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eMPLOYEE_IDLabel
            // 
            eMPLOYEE_IDLabel.AutoSize = true;
            eMPLOYEE_IDLabel.Location = new System.Drawing.Point(25, 157);
            eMPLOYEE_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eMPLOYEE_IDLabel.Name = "eMPLOYEE_IDLabel";
            eMPLOYEE_IDLabel.Size = new System.Drawing.Size(199, 34);
            eMPLOYEE_IDLabel.TabIndex = 32;
            eMPLOYEE_IDLabel.Text = "EMPLOYEE ID:";
            // 
            // fNAMELabel
            // 
            fNAMELabel.AutoSize = true;
            fNAMELabel.Location = new System.Drawing.Point(25, 229);
            fNAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fNAMELabel.Name = "fNAMELabel";
            fNAMELabel.Size = new System.Drawing.Size(166, 34);
            fNAMELabel.TabIndex = 34;
            fNAMELabel.Text = "FIRSTNAME:";
            // 
            // lNAMELabel
            // 
            lNAMELabel.AutoSize = true;
            lNAMELabel.Location = new System.Drawing.Point(25, 299);
            lNAMELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lNAMELabel.Name = "lNAMELabel";
            lNAMELabel.Size = new System.Drawing.Size(152, 34);
            lNAMELabel.TabIndex = 36;
            lNAMELabel.Text = "SURNAME:";
            // 
            // pHONELabel
            // 
            pHONELabel.AutoSize = true;
            pHONELabel.Location = new System.Drawing.Point(25, 370);
            pHONELabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pHONELabel.Name = "pHONELabel";
            pHONELabel.Size = new System.Drawing.Size(118, 34);
            pHONELabel.TabIndex = 38;
            pHONELabel.Text = "PHONE:";
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
            this.bookListPanel.Controls.Add(this.closeButton);
            this.bookListPanel.Controls.Add(this.customerDataGridView);
            this.bookListPanel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookListPanel.Location = new System.Drawing.Point(12, 11);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.Size = new System.Drawing.Size(1005, 794);
            this.bookListPanel.TabIndex = 4;
            // 
            // eMPLOYEE_IDTextBox
            // 
            this.eMPLOYEE_IDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.eMPLOYEE_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "EMPLOYEE_ID", true));
            this.eMPLOYEE_IDTextBox.Location = new System.Drawing.Point(244, 154);
            this.eMPLOYEE_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.eMPLOYEE_IDTextBox.Name = "eMPLOYEE_IDTextBox";
            this.eMPLOYEE_IDTextBox.ReadOnly = true;
            this.eMPLOYEE_IDTextBox.Size = new System.Drawing.Size(259, 41);
            this.eMPLOYEE_IDTextBox.TabIndex = 33;
            // 
            // eMPLOYEESBindingSource
            // 
            this.eMPLOYEESBindingSource.DataMember = "EMPLOYEES";
            this.eMPLOYEESBindingSource.DataSource = this.lexi_BookshopDataSet;
            // 
            // lexi_BookshopDataSet
            // 
            this.lexi_BookshopDataSet.DataSetName = "Lexi_BookshopDataSet";
            this.lexi_BookshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fNAMETextBox
            // 
            this.fNAMETextBox.BackColor = System.Drawing.SystemColors.Window;
            this.fNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "FNAME", true));
            this.fNAMETextBox.Location = new System.Drawing.Point(244, 225);
            this.fNAMETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fNAMETextBox.Name = "fNAMETextBox";
            this.fNAMETextBox.ReadOnly = true;
            this.fNAMETextBox.Size = new System.Drawing.Size(259, 41);
            this.fNAMETextBox.TabIndex = 35;
            // 
            // lNAMETextBox
            // 
            this.lNAMETextBox.BackColor = System.Drawing.SystemColors.Window;
            this.lNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "LNAME", true));
            this.lNAMETextBox.Location = new System.Drawing.Point(244, 295);
            this.lNAMETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lNAMETextBox.Name = "lNAMETextBox";
            this.lNAMETextBox.ReadOnly = true;
            this.lNAMETextBox.Size = new System.Drawing.Size(259, 41);
            this.lNAMETextBox.TabIndex = 37;
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eMPLOYEESBindingSource, "PHONE", true));
            this.pHONETextBox.Location = new System.Drawing.Point(244, 366);
            this.pHONETextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pHONETextBox.Name = "pHONETextBox";
            this.pHONETextBox.ReadOnly = true;
            this.pHONETextBox.Size = new System.Drawing.Size(259, 41);
            this.pHONETextBox.TabIndex = 39;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(787, 722);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(191, 55);
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
            this.customerDataGridView.Location = new System.Drawing.Point(532, 34);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(447, 668);
            this.customerDataGridView.TabIndex = 30;
            // 
            // lOGINDataGridViewTextBoxColumn
            // 
            this.lOGINDataGridViewTextBoxColumn.DataPropertyName = "LOG_IN";
            this.lOGINDataGridViewTextBoxColumn.HeaderText = "LOG_IN";
            this.lOGINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOGINDataGridViewTextBoxColumn.Name = "lOGINDataGridViewTextBoxColumn";
            this.lOGINDataGridViewTextBoxColumn.Width = 197;
            // 
            // lOGOUTDataGridViewTextBoxColumn
            // 
            this.lOGOUTDataGridViewTextBoxColumn.DataPropertyName = "LOG_OUT";
            this.lOGOUTDataGridViewTextBoxColumn.HeaderText = "LOG_OUT";
            this.lOGOUTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOGOUTDataGridViewTextBoxColumn.Name = "lOGOUTDataGridViewTextBoxColumn";
            this.lOGOUTDataGridViewTextBoxColumn.Width = 197;
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
            // eMPLOYEESTableAdapter
            // 
            this.eMPLOYEESTableAdapter.ClearBeforeFill = true;
            // 
            // TimeTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1029, 816);
            this.Controls.Add(this.bookListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TimeTableForm";
            this.Text = "TimeTableForm";
            this.Load += new System.EventHandler(this.TimeTableForm_Load);
            this.bookListPanel.ResumeLayout(false);
            this.bookListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIMETABLEBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGOUTDataGridViewTextBoxColumn;
    }
}