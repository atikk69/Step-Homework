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
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Repository;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    internal class AdminMenuViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        IOrderRepository _orderRepository;
        public Order _selectedOrder;
        public List<string> Statuses = ["Order confirmed", "Received at the warehouse", "Shipped", "Under customs inspection", "At the post office"];
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


        public AdminMenuViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger,IOrderRepository orderRepository)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            _orderRepository = orderRepository;
            Orders = new ObservableCollection<Order>(_orderRepository.GetOrders());
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as ObservableCollection<Order> != null)
                {
                    Orders = message.Data as ObservableCollection<Order>;
                }
            });
        }



        public RelayCommand Exit
        {
            get => new(
                () =>
                {
                    _navigationService.NavigateTo<LogInViewModel>();
                });
        }

        public RelayCommand NextLevel
        {
            get => new(
                () =>
                {
                    if (SelectedOrder != null && SelectedOrder.Status != "At the post office")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (SelectedOrder.Status == Statuses[i])
                            {
                                SelectedOrder.Status = Statuses[i + 1];
                                _orderRepository.SaveChanges();
                                MessageBox.Show("Status Leveled up!");
                                Orders = new ObservableCollection<Order>(_orderRepository.GetOrders());
                                _dataService.SendData(Orders);
                                return;
                            }
                        }
                    }
                    else if (SelectedOrder == null)
                        MessageBox.Show("Please select order!");
                    else
                        MessageBox.Show("You order is already delievered!");
                });
        }
        public RelayCommand DeleteOrder
        {
            get => new(
                () =>
                {
                    if (SelectedOrder != null && SelectedOrder.Status == "Order confirmed")
                    {
                        _orderRepository.Delete(SelectedOrder);
                        _orderRepository.SaveChanges();
                        Orders = new ObservableCollection<Order>(_orderRepository.GetOrders());
                        _dataService.SendData(Orders);
                        MessageBox.Show("Order sucessfully deleted");
                    }
                    else if (SelectedOrder != null && SelectedOrder.Status != "Order confirmed")
                        MessageBox.Show("Can't delete the order");
                    else
                        MessageBox.Show("Please select order!");
                    
                });
        }
        public RelayCommand ToAddProduct
        {
            get => new(
                () =>
                {
                    _navigationService.NavigateTo<AddProductViewModel>();
                });
        }
    }
}
