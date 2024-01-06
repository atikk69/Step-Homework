using System;
using System.Collections.Generic;
using System.Linq;
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

namespace _12_Login.Views
{
    public partial class ResetPassword : Page
    {
        private string password = "";
        private string email = "";

        public ResetPassword(string email)
        {
            InitializeComponent();
        }

        private void passwordTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            password += e.Text;
            passwordTextBox.Text = new string('*', password.Length);

            e.Handled = true;
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            passwordTextBox.Text = password;
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in SignIn.Users)
            {
                if (item.Email == email)
                    item.Password = password;
            }
        }
    }
}
