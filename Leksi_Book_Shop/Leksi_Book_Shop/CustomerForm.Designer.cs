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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.Label pHONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label cLIENT_IDLabel;
            System.Windows.Forms.Label fIRSTNAMELabel;
            System.Windows.Forms.Label lASTNAMELabel;
            System.Windows.Forms.Label pOINTSLabel;
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cLIENT_IDTextBox = new System.Windows.Forms.TextBox();
            this.cLIENTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lexi_BookshopDataSet = new Leksi_Book_Shop.Lexi_BookshopDataSet();
            this.pOINTSTextBox = new System.Windows.Forms.TextBox();
            this.lASTNAMETextBox = new System.Windows.Forms.TextBox();
            this.fIRSTNAMETextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.pHONETextBox = new System.Windows.Forms.TextBox();
            this.aDDRESSTextBox = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.cLIENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIRSTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POINTS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.eMPLOYEESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEESTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter();
            this.tableAdapterManager = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.TableAdapterManager();
            this.cLIENTSTableAdapter = new Leksi_Book_Shop.Lexi_BookshopDataSetTableAdapters.CLIENTSTableAdapter();
            aDDRESSLabel = new System.Windows.Forms.Label();
            pHONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            cLIENT_IDLabel = new System.Windows.Forms.Label();
            fIRSTNAMELabel = new System.Windows.Forms.Label();
            lASTNAMELabel = new System.Windows.Forms.Label();
            pOINTSLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aDDRESSLabel
            // 
            resources.ApplyResources(aDDRESSLabel, "aDDRESSLabel");
            aDDRESSLabel.Name = "aDDRESSLabel";
            // 
            // pHONELabel
            // 
            resources.ApplyResources(pHONELabel, "pHONELabel");
            pHONELabel.Name = "pHONELabel";
            // 
            // eMAILLabel
            // 
            resources.ApplyResources(eMAILLabel, "eMAILLabel");
            eMAILLabel.Name = "eMAILLabel";
            // 
            // cLIENT_IDLabel
            // 
            resources.ApplyResources(cLIENT_IDLabel, "cLIENT_IDLabel");
            cLIENT_IDLabel.Name = "cLIENT_IDLabel";
            // 
            // fIRSTNAMELabel
            // 
            resources.ApplyResources(fIRSTNAMELabel, "fIRSTNAMELabel");
            fIRSTNAMELabel.Name = "fIRSTNAMELabel";
            // 
            // lASTNAMELabel
            // 
            resources.ApplyResources(lASTNAMELabel, "lASTNAMELabel");
            lASTNAMELabel.Name = "lASTNAMELabel";
            // 
            // pOINTSLabel
            // 
            resources.ApplyResources(pOINTSLabel, "pOINTSLabel");
            pOINTSLabel.Name = "pOINTSLabel";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.mainPanel.Controls.Add(this.cLIENT_IDTextBox);
            this.mainPanel.Controls.Add(this.pOINTSTextBox);
            this.mainPanel.Controls.Add(this.lASTNAMETextBox);
            this.mainPanel.Controls.Add(this.fIRSTNAMETextBox);
            this.mainPanel.Controls.Add(pOINTSLabel);
            this.mainPanel.Controls.Add(this.addButton);
            this.mainPanel.Controls.Add(this.updateButton);
            this.mainPanel.Controls.Add(this.pHONETextBox);
            this.mainPanel.Controls.Add(this.aDDRESSTextBox);
            this.mainPanel.Controls.Add(this.customerDataGridView);
            this.mainPanel.Controls.Add(aDDRESSLabel);
            this.mainPanel.Controls.Add(pHONELabel);
            this.mainPanel.Controls.Add(eMAILLabel);
            this.mainPanel.Controls.Add(this.eMAILTextBox);
            this.mainPanel.Controls.Add(cLIENT_IDLabel);
            this.mainPanel.Controls.Add(this.deleteButton);
            this.mainPanel.Controls.Add(this.closeButton);
            this.mainPanel.Controls.Add(fIRSTNAMELabel);
            this.mainPanel.Controls.Add(lASTNAMELabel);
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // cLIENT_IDTextBox
            // 
            this.cLIENT_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "CLIENT_ID", true));
            resources.ApplyResources(this.cLIENT_IDTextBox, "cLIENT_IDTextBox");
            this.cLIENT_IDTextBox.Name = "cLIENT_IDTextBox";
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
            // pOINTSTextBox
            // 
            this.pOINTSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "POINTS", true));
            resources.ApplyResources(this.pOINTSTextBox, "pOINTSTextBox");
            this.pOINTSTextBox.Name = "pOINTSTextBox";
            this.pOINTSTextBox.ReadOnly = true;
            // 
            // lASTNAMETextBox
            // 
            this.lASTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "LASTNAME", true));
            resources.ApplyResources(this.lASTNAMETextBox, "lASTNAMETextBox");
            this.lASTNAMETextBox.Name = "lASTNAMETextBox";
            // 
            // fIRSTNAMETextBox
            // 
            this.fIRSTNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "FIRSTNAME", true));
            resources.ApplyResources(this.fIRSTNAMETextBox, "fIRSTNAMETextBox");
            this.fIRSTNAMETextBox.Name = "fIRSTNAMETextBox";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.Name = "updateButton";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // pHONETextBox
            // 
            this.pHONETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "PHONE", true));
            resources.ApplyResources(this.pHONETextBox, "pHONETextBox");
            this.pHONETextBox.Name = "pHONETextBox";
            // 
            // aDDRESSTextBox
            // 
            this.aDDRESSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "ADDRESS", true));
            resources.ApplyResources(this.aDDRESSTextBox, "aDDRESSTextBox");
            this.aDDRESSTextBox.Name = "aDDRESSTextBox";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(113)))), ((int)(((byte)(108)))));
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIENTIDDataGridViewTextBoxColumn,
            this.FIRSTNAME,
            this.LASTNAME,
            this.eMAILDataGridViewTextBoxColumn,
            this.POINTS,
            this.pHONEDataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn});
            this.customerDataGridView.DataSource = this.cLIENTSBindingSource;
            resources.ApplyResources(this.customerDataGridView, "customerDataGridView");
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowTemplate.Height = 24;
            // 
            // cLIENTIDDataGridViewTextBoxColumn
            // 
            this.cLIENTIDDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ID";
            resources.ApplyResources(this.cLIENTIDDataGridViewTextBoxColumn, "cLIENTIDDataGridViewTextBoxColumn");
            this.cLIENTIDDataGridViewTextBoxColumn.Name = "cLIENTIDDataGridViewTextBoxColumn";
            // 
            // FIRSTNAME
            // 
            this.FIRSTNAME.DataPropertyName = "FIRSTNAME";
            resources.ApplyResources(this.FIRSTNAME, "FIRSTNAME");
            this.FIRSTNAME.Name = "FIRSTNAME";
            // 
            // LASTNAME
            // 
            this.LASTNAME.DataPropertyName = "LASTNAME";
            resources.ApplyResources(this.LASTNAME, "LASTNAME");
            this.LASTNAME.Name = "LASTNAME";
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            resources.ApplyResources(this.eMAILDataGridViewTextBoxColumn, "eMAILDataGridViewTextBoxColumn");
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            // 
            // POINTS
            // 
            this.POINTS.DataPropertyName = "POINTS";
            resources.ApplyResources(this.POINTS, "POINTS");
            this.POINTS.Name = "POINTS";
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            resources.ApplyResources(this.pHONEDataGridViewTextBoxColumn, "pHONEDataGridViewTextBoxColumn");
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            resources.ApplyResources(this.aDDRESSDataGridViewTextBoxColumn, "aDDRESSDataGridViewTextBoxColumn");
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTSBindingSource, "EMAIL", true));
            resources.ApplyResources(this.eMAILTextBox, "eMAILTextBox");
            this.eMAILTextBox.Name = "eMAILTextBox";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lexi_BookshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button closeButton;
        private Lexi_BookshopDataSet lexi_BookshopDataSet;
        private System.Windows.Forms.BindingSource eMPLOYEESBindingSource;
        private Lexi_BookshopDataSetTableAdapters.EMPLOYEESTableAdapter eMPLOYEESTableAdapter;
        private Lexi_BookshopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Lexi_BookshopDataSetTableAdapters.CLIENTSTableAdapter cLIENTSTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTSBindingSource;
        private System.Windows.Forms.TextBox pHONETextBox;
        private System.Windows.Forms.TextBox aDDRESSTextBox;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox cLIENT_IDTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox pOINTSTextBox;
        private System.Windows.Forms.TextBox lASTNAMETextBox;
        private System.Windows.Forms.TextBox fIRSTNAMETextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIRSTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POINTS;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
    }
}