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
    public partial class MailForm : Form
    {
        MimeMessage message = new MimeMessage();
        string emails;
        public MailForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //message.From.Add(new MailboxAddress("Βιβλιοπωλείο λέξη", "giorgos14kyperounta@gmail.com"));

            //message.To.Add(MailboxAddress.Parse("giorgos18hadjimichael@gmail.com"));

            message.Subject = "INFO";

            message.Body = new TextPart("plain")
            {
                Text = mailTxtBox.Text
            };


            SmtpClient client = new SmtpClient();

            try
            {
                client.Connect("smtp.gmail.com", 465, true);
                
                //client.Authenticate("giorgos14kyperounta@gmail.com","96849547");
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
}
