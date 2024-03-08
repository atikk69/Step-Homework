using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Trendyol.Repository;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class LogInViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        public readonly IUserRepository _userRepository;
        LogInService _loginService;
        VerificationService _verificationService;
        public string _emailText = "";
        public string _passwordText = "";

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

        public LogInViewModel(INavigationService navigationService, IDataService dataService,LogInService loginService,VerificationService verificationService,IUserRepository userRepository)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _loginService = loginService;
            _verificationService = verificationService;
            _userRepository = userRepository;
        }


        public RelayCommand LogIn
        {
            get => new(
            () =>
            {
                if (_verificationService.IsEmailameValid(Email) && _verificationService.IsPasswordValid(Password) && _loginService.IsEmail(Email, _userRepository) && _loginService.PasswordIsTrue(Email,Password, _userRepository))
                {
                    var currentUser = _userRepository.GetByEmail(Email);
                    if (_loginService.IsEmail(Email, _userRepository) && _loginService.PasswordIsTrue(Email, Password, _userRepository) && currentUser.Membership == "User")
                    {
                        MessageBox.Show("Successfully Loged in!");
                        _dataService.SendData(currentUser);
                        _navigationService.NavigateTo<GoodsPageViewModel>();
                        Email = "";
                        Password = "";

                    }
                    else if (_loginService.IsEmail(_emailText, _userRepository) && _loginService.PasswordIsTrue(Email, Password, _userRepository) && currentUser.Membership == "SuperAdmin")
                    {
                        MessageBox.Show("Successfully Loged in!");
                        _navigationService.NavigateTo<SuperAdminMenuViewModel>();
                        Email = "";
                        Password = "";
                    }
                    else if (_loginService.IsEmail(_emailText, _userRepository) && _loginService.PasswordIsTrue(Email, Password, _userRepository) && currentUser.Membership == "Admin")
                    {
                        MessageBox.Show("Successfully Loged in!");
                        _navigationService.NavigateTo<AdminMenuViewModel>();
                        Email = "";
                        Password = "";
                    }
                }
                else
                {

                    MessageBox.Show("Something wet wrong!Please try again");
                    Email = "";
                    Password = "";


                }


            });


        }


    }
}
