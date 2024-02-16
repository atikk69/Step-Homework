using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyol.Models;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class SuperAdminMenuViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        private readonly ObservableCollection<User> _users;
        public User _selectedUser;


        public SuperAdminMenuViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
        }
    }
}
