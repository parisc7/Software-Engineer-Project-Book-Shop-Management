using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USB_Barcode_Scanner;

namespace Leksi_Book_Shop
{
    public partial class BarcodeForm : Form
    {
        public BarcodeForm()
        {
            InitializeComponent();
            BarcodeScanner barcodeScanner = new BarcodeScanner(barcodeScannerTextBox);
            barcodeScanner.BarcodeScanned += BarcodeScanner_BarcodeScanned;
        }

        private void BarcodeScanner_BarcodeScanned(object sender, BarcodeScannerEventArgs e)
        {
            
        }

        private void barcodeScannerTextBox_TextChanged(object sender, BarcodeScannerEventArgs e)
        {
            barcodeScannerTextBox.Text = e.Barcode;
        }
    }
}
