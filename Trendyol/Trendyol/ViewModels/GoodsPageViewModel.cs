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
using System.Windows.Documents;
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Repository;
using Trendyol.Services.Interfaces;
using Trendyol.Views;

namespace Trendyol.ViewModels
{
    class GoodsPageViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        private readonly IOrderRepository _orderRepository;
        public readonly IProductRepository _productRepository;
        public readonly IWarehouseRepository _warehouseRepository;
        public Product _selectedProduct;
        public ObservableCollection<Warehouse> warehouses;
        public ObservableCollection<Order> orders;

        public ObservableCollection<Order> Orders
        {
            get { return orders; }
            set { Set(ref orders, value); }
        }

        public ObservableCollection<Warehouse> Warehouses
        {
            get { return warehouses; }
            set { Set(ref warehouses, value); }
        }

        public ObservableCollection<Product> Products { get; set; }

        public int _productCount = 0;
        public int ProductCount
        {
            get { return _productCount; }
            set { Set(ref _productCount, value); }
        }

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set { Set(ref _selectedProduct, value); }
        }


        public GoodsPageViewModel(INavigationService navigationService, IDataService dataService,IProductRepository productRepository,IWarehouseRepository warehouseRepository,IMessenger messenger,IOrderRepository orderRepository)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _productRepository = productRepository;
            _warehouseRepository = warehouseRepository;
            _orderRepository = orderRepository;
            _messenger = messenger;
            Products =  new ObservableCollection<Product>(_productRepository.GetAll());
            _dataService.SendData(Products);
            Warehouses = new ObservableCollection<Warehouse>(_warehouseRepository.GetAll());
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as ObservableCollection<Product> != null)
                {
                    Products = message.Data as ObservableCollection<Product>;
                }
                _messenger.Register<DataMessage>(this, message =>
                {
                    if (message.Data as ObservableCollection<Order> != null)
                    {
                        Orders = message.Data as ObservableCollection<Order>;
                    }
                });
            });
        }


        public RelayCommand Buy
        {
            get => new(
                () =>
                {
                    if (SelectedProduct != null)
                    {
                        var CurrentInStock = _warehouseRepository.GetByProductId(SelectedProduct.Id);
                        _dataService.SendData(SelectedProduct);
                        _dataService.SendData(CurrentInStock);
                        _navigationService.NavigateTo<OrderPageViewModel>();
                    }
                    else
                        MessageBox.Show("Please select a product!");
                   
                });
        }


        public RelayCommand ToProfile
        {
            get => new(
                () =>
                {
                    _navigationService.NavigateTo<ProfileViewModel>();
                });
        }


        public RelayCommand Exit
        {
            get => new(
                () =>
                {
                    _navigationService.NavigateTo<LogInViewModel>();
                    Orders = new ObservableCollection<Order>(_orderRepository.GetOrders());
                    _dataService.SendData(Orders);
                });
        }

    }
}

