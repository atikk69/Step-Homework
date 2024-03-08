using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Trendyol.Models;
using Trendyol.Repository;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels;

class SuperAdminMenuViewModel : ViewModelBase
{
    private readonly INavigationService _navigationService;
    private readonly IUserRepository _userRepository;
    public User _selectedUser;
    public ObservableCollection<User> users;



    public ObservableCollection<User> Users
    {
        get { return users; }
        set { Set(ref users, value); }
    }
    public User SelectedUser
    {
        get { return _selectedUser; }
        set { Set(ref _selectedUser, value); }
    }


    public SuperAdminMenuViewModel(INavigationService navigationService,IUserRepository userRepository)
    {
        _navigationService = navigationService;
        _userRepository = userRepository;
        Users = new ObservableCollection<User>(_userRepository.GetAll());
    }


    public RelayCommand Exit
    {
        get => new(
            () =>
            {
                _navigationService.NavigateTo<LogInViewModel>();
            });
    }

    public RelayCommand ToAdmin
    {
        get => new(
            () =>
            {
                if (SelectedUser != null)
                {
                    if (SelectedUser.Membership == "User")
                    {
                        var user = _userRepository.GetByEmail(SelectedUser.Email);
                        user.Membership = "Admin";
                        _userRepository.SaveChanges();
                        MessageBox.Show("Sucsessfully switched to admin");
                        Users = new ObservableCollection<User>(_userRepository.GetAll());
                    }
                    else if (SelectedUser.Membership == "SuperAdmin")
                    {
                        MessageBox.Show("You can't change the role of SuperAdmin");
                    }
                    else
                        MessageBox.Show("An error was occured.This member already is admin");
                }
                else
                    MessageBox.Show("Please select user");
            });
    }
    public RelayCommand ToUser
    {
        get => new(
            () =>
            {
                if (SelectedUser != null)
                {
                    if (SelectedUser.Membership == "Admin")
                    {
                        var user = _userRepository.GetByEmail(SelectedUser.Email);
                        user.Membership = "User";
                        _userRepository.SaveChanges();
                        MessageBox.Show("Sucsessfully switched to user");
                        Users = new ObservableCollection<User>(_userRepository.GetAll());
                    }
                    else if (SelectedUser.Membership == "SuperAdmin")
                    {
                        MessageBox.Show("You can't change the role of SuperAdmin");
                    }
                    else
                        MessageBox.Show("An error was occured.This member already is user");
                }
                else
                    MessageBox.Show("Please select user");

            });
    
        
    } 
    
}


