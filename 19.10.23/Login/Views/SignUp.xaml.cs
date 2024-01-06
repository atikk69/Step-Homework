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
    public partial class SignUp : Page
    {
        private string password;

        public SignUp()
        {
            InitializeComponent();
        }

        private void AddUserBtn(object sender, RoutedEventArgs e)
        {
            User UserToAdd = new();

            UserToAdd.Name = NameTxt.Text;
            UserToAdd.Surname = SurnameTxt.Text;
            UserToAdd.Email = EmailTxt.Text;
            UserToAdd.Password = PasswordTxt.Text;

            foreach (var item in SignIn.Users)
            {
                if(item.Email == UserToAdd.Email)
                {
                    MessageBox.Show("This gmail is already registered");
                    return;
                }
            }

            MainView.Frame.Content = new CheckEmail(UserToAdd, new SignUp());
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
