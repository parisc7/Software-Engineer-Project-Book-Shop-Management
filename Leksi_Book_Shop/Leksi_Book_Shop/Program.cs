/** \file      Program.cs
*   \brief     Provides the full functioning system
*   \details   This program regards to all the necessary forms needed to run the application
*   \author    SOFTTSING TEAM
*   \version   0.1
*   \date      2022-2022
*   \bug       No bugs Included
*   \copyright SOFTTSING Ltd.
*/

// Packets Used
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>Program</code> is a class that controls the program
    * <BR>
    * @return Returns the working application
    */
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        /**
        * Function <code>main</code> is the main function of this program
        * <BR>
        */
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash_Screen());
            Application.Run(new LoginForm());
            //Application.Run(new EmployeesForm());
        }
    }
}
