using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels;

public class ProfileViewModel : ViewModelBase
{
    private readonly IMessenger _messenger;
    private readonly INavigationService _navigationService;
    private readonly IDataService _dataService;
    public User _currentUser;
    public User CurrentUser
    {
        get => _currentUser;
        set
        {
            Set(ref _currentUser, value); // Функция Set() автоматически вызывает PropertyChanged.
        }
    }


    public ProfileViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger)
    {
        _navigationService = navigationService;
        _dataService = dataService;
        _messenger = messenger;
        _messenger.Register<DataMessage>(this, message =>
        {
            if (message.Data as User != null)
            {
             CurrentUser = message.Data as User;

            }
        });
    }














}

