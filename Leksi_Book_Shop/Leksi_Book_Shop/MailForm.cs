/** \file      MailForm.cs
*   \brief     Provides the sending email process
*   \details   This program regards to all the necessary functionalities
*   \author    SOFTTSING TEAM
*   \version   2.0 
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
using MimeKit;
using MailKit.Net.Smtp;
using MailKit;

namespace Leksi_Book_Shop
{
    /**
    * Class <code>MailForm</code> is a class that is responsible for
    * the functionalities that are related to the sending email procedure
    * <BR>
    * @return Returns that email was successfully sent
    */
    public partial class MailForm : Form
    {
        MimeMessage message = new MimeMessage();
        CustomerForm customer =new CustomerForm();

        // Default Constructor 

        /**
        * Function <code>MailForm</code> initialises the components and runs the corresponding customer's database to acquire data
        * <BR>
        */
        public MailForm()
        {
            InitializeComponent();
            customer.Show();
            customer.Hide();    
        }

        /**
        * Function <code>sendButton_Click</code> sends email to the corresponding customer
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void sendButton_Click(object sender, EventArgs e)
        {
            //sender (onoma pou emfanizi (Sender's name), mail pou stelni (Sender's email))
            //message.From.Add(new MailboxAddress("Βιβλιοπωλείο λέξη", " "));

            foreach(var customer in customer.CustomerList)
            {
                message.To.Add(MailboxAddress.Parse(customer.Email));
                message.Subject = "INFO";
                message.Body = new TextPart("plain")
                {
                    Text = mailTxtBox.Text
                };
                SmtpClient client = new SmtpClient();
                try
                {
                    //to be able to enable the provider it sends
                    client.Connect("smtp.gmail.com", 465, true);
                    
                    //authentication of sender (email of sender, sender's email code)
                    //client.Authenticate(" ", " ");

                    client.Send(message);
                    MessageBox.Show("Email sent!", "SUCCESS!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        /**
        * Function <code>exitButton_Click</code> closes email form
        * <BR>
        * @param sender Triggers object (Default Parameters)
        * @param e      Triggers Event (Default Parameters)
        */
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
