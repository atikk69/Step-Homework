using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _12_Login.Models;

namespace _12_Login.Views
{
    public partial class CheckEmail : Page
    {
        private static int Code { get; set; }
        private User UserToAdd { get; set; }

        private Page returnPage;

        public CheckEmail(User _user, Page _returnPage)
        {
            InitializeComponent();
            returnPage = _returnPage;
            UserToAdd = _user;
            SendEmail(_user.Email);
        }

        private void NumberCheck(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
            else
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Length >= 1)
                {
                    e.Handled = true;
                }
            }
        }

        public static void SendEmail(string sendEmail)
        {
            MailAddress from = new MailAddress("elnurloginapp@gmail.com", "Login Programm");
            MailAddress to = new MailAddress(sendEmail, "User");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Your identification code: ";

            Random random = new Random();
            Code = random.Next(1000, 10000);

            message.Body = Code.ToString();
            message.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from.Address, "ebioiltzziwnpcbe");

            smtp.Send(message);
        }

        public void SendBtn(object sender, RoutedEventArgs e)
        {
            string IdentificationCode = Code1.Text + Code2.Text + Code3.Text + Code4.Text;

            if(IdentificationCode == Code.ToString())
            {
                MessageBox.Show("You have been successfully added");
                SignIn.AddUser(UserToAdd);
            }
            
            MainView.Frame.Content = returnPage;
        }
    }
}
