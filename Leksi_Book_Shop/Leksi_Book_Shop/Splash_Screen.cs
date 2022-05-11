/** \file      Splash_Screen.cs
*   \brief     Provides the Waiting Pop-Up Screen 
*   \details   This program regards to all the necessary functionalities
*   \author    SOFTTSING TEAM
*   \version   0.2
*   \date      2022-2022
*   \bug       No bugs Included
*   \copyright SOFTTSING Ltd.
*/

// Packets Used
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
    /**
    * Class <code>Splash_Screen</code> is a class that is responsible for
    * the functionalities that are related to the waiting pop up screen
    * <BR>
    * @return Returns the successful or NOT log in
    */
    public partial class Splash_Screen : Form
    {
        // Default Constructor 

        /**
        * Function <code>Splash_Screen</code> initialises the components and triggers timer
        * <BR>
        */
        public Splash_Screen()
        {
            InitializeComponent();
            timer.Start();
          
        }

        /**
        * Function <code>timer_Tick</code> indicates the timing procedure
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void timer_Tick(object sender, EventArgs e)
        {
            // Loading to 100%...
            progressBar.ForeColor = Color.DarkRed;
            if (progressBar.Value < 100)
            {
                progressBar.Value += 1;
                processLbl.Text=progressBar.Value.ToString()+"%";
            }
            
            // Once arriving at 100%, pop up window closes and proceeds to the log in form
            else
            {
                this.Close();   
            }
        }
    }
}
