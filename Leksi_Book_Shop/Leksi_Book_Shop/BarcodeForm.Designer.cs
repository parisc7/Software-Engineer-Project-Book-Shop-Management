namespace Leksi_Book_Shop
{
    partial class BarcodeForm
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
            this.barcodeScannerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // barcodeScannerTextBox
            // 
            this.barcodeScannerTextBox.Location = new System.Drawing.Point(301, 30);
            this.barcodeScannerTextBox.Name = "barcodeScannerTextBox";
            this.barcodeScannerTextBox.Size = new System.Drawing.Size(272, 20);
            this.barcodeScannerTextBox.TabIndex = 0;
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 72);
            this.Controls.Add(this.barcodeScannerTextBox);
            this.Name = "BarcodeForm";
            this.Text = "BarcodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barcodeScannerTextBox;
    }
}