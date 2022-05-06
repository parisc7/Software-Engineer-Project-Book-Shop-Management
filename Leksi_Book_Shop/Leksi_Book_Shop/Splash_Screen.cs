using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leksi_Book_Shop
{
    public partial class Splash_Screen : Form
    {
        
        public Splash_Screen()
        {
            InitializeComponent();
            timer.Start();
          
        }
      
        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar.ForeColor = Color.DarkRed;
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                processLbl.Text=progressBar.Value.ToString()+"%";
            }
            else
            {
                this.Close();   
            }
        }
    }
}
