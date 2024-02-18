using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Trendyol.Models;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;
using Trendyol.Views;

namespace Trendyol.ViewModels
{
    class RegistrationViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        private readonly NavigationService navigationService;
        private readonly VerificationService _verificationService = new();
        DBContext _dbContext;
        public string _nameText = "";
        public string _surnameText = "";
        public string _emailText = "";
        public string _passwordText = "";
        public string _confirmpasswordText = "";

        public string Name
        {
            get { return _nameText; }
            set { Set(ref _nameText, value); }
        }
        public string Surname
        {
            get { return _surnameText; }
            set { Set(ref _surnameText, value); }
        }
        public string Email
        {
            get { return _emailText; }
            set { Set(ref _emailText, value); }
        }
        public string Password
        {
            get { return _passwordText; }
            set { Set(ref _passwordText, value); }
        }

        public string Confirmpassword
        {
            get { return _confirmpasswordText; }
            set { Set(ref _confirmpasswordText, value); }
        }


        public RegistrationViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
        }


        public RelayCommand SignUp
        {
            get => new(
               () =>
               {
                   if (_verificationService.IsNameValid(_nameText)
                   && _verificationService.IsNameValid(_surnameText)
                   && _verificationService.IsEmailameValid(_emailText)
                   && _verificationService.IsPasswordValid(_passwordText)
                   && _verificationService.IsPasswordValid(_confirmpasswordText)
                   && _passwordText == _confirmpasswordText)
                   {
                       User newUser = new()
                       {
                           Name = _nameText,
                           Surname = _surnameText,
                           Email = _emailText,
                           Password = _passwordText,
                           Membership = "User"
                       };
                       _dbContext = new();
                       _dbContext.Users.Add(newUser);
                       _dbContext.SaveChanges();
                       MessageBox.Show("Successfully Signed Up!");
                       _navigationService.NavigateTo<GoodsPageViewModel>();

                   }
                   else
                   {
                       MessageBox.Show("Something wet wrong!Please try again.");
                       Name = "";
                       Surname = "";
                       Email = "";
                       Password = "";
                       Confirmpassword = "";
                   }


               });
        }
        public RelayCommand LogIn
        {
            get => new(
           () =>
           {
               _navigationService.NavigateTo<LogInViewModel>();
           });
        }



    }
}
