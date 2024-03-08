using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Repository;
using Trendyol.Services.Classes;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels;
class ProfileViewModel : ViewModelBase
{
    private readonly IDataService _dataService;
    private readonly IMessenger _messenger;
    private readonly INavigationService _navigationService;
    private readonly IOrderRepository _orderRepository;
    public User _currentUser;
    public Order _selectedOrder;
    public ObservableCollection<Order> orders;

    public ObservableCollection<Order> Orders
    {
        get { return orders; }
        set { Set(ref orders, value); }
    }
    public Order SelectedOrder
    {
        get { return _selectedOrder; }
        set { Set(ref _selectedOrder, value); }
    }

    public User CurrentUser
    {
        get => _currentUser;
        set
        {
            Set(ref _currentUser, value);
        }
    }


    public ProfileViewModel(INavigationService navigationService, IMessenger messenger,IOrderRepository orderRepository, IDataService dataService)
    {
        _navigationService = navigationService;
        _messenger = messenger;
        _orderRepository = orderRepository;
        _dataService = dataService;
        _messenger.Register<DataMessage>(this, message =>
        {
            if (message.Data as User != null)
            {
                CurrentUser = message.Data as User;
                Orders = new ObservableCollection<Order>(_orderRepository.GetOrders().Where(x => x.UserId == CurrentUser.Id));
                _dataService.SendData(Orders);

            } 
            if (message.Data as ObservableCollection<Order> != null && CurrentUser != null)
            {
                Orders = new ObservableCollection<Order>(_orderRepository.GetOrders().Where(x => x.UserId == CurrentUser.Id));
            }
        });
    }



    public RelayCommand ToGoodsPage
    {
        get => new(
            () =>
            {
                _navigationService.NavigateTo<GoodsPageViewModel>();
            });
    }

}

