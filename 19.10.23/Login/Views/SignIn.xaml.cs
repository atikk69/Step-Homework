using _12_Login.Models;
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
    public partial class SignIn : Page
    {
        public static List<User> Users = new();
        private string password;

        public SignIn()
        {
            InitializeComponent();
        }

        private void SignUpBtn(object sender, RoutedEventArgs e)
        {
            MainView.Frame.Content = new SignUp();
        }

        private void SignInBtn(object sender, RoutedEventArgs e)
        {
            foreach (var item in Users)
            {
                if (item.Email == EmailTxt.Text && item.Password == PasswordTxt.Text)
                    MessageBox.Show($"Welcome {item.Name}!");
            }
        }

        public static void AddUser(User _user)
        {
            Users.Add(_user);
        }

        private void ForgotBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainView.Frame.Content = new CheckEmail(EmailTxt.Text, new SignUp());
        }

        private void passwordTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            password += e.Text;
            PasswordTxt.Text = new string('*', password.Length);

            e.Handled = true;
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            PasswordTxt.Text = password;
        }
    }
}