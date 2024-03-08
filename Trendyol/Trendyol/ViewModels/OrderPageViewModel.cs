﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Repository;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class OrderPageViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        private readonly IOrderRepository _orderRepository;
        private readonly IWarehouseRepository _warehouseRepository;

        public Product _selectedProduct;
        public User _currentUser;
        public List<string> Statuses = ["Order confirmed", "Received at the warehouse", "Shipped", "Under customs inspection", "At the post office"];
        public Warehouse _stockCount;
        public int _productCount = 0;
        public ObservableCollection<Warehouse> warehouses;
        public ObservableCollection<Order> _orders;

        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
            set { Set(ref _orders, value); }
        }


        public ObservableCollection<Warehouse> Warehouses
        {
            get { return warehouses; }
            set { Set(ref warehouses, value); }
        }
        public int ProductCount
        {
            get { return _productCount; }
            set { Set(ref _productCount, value); }
        }
        public Warehouse StockCount
        {
            get { return _stockCount; }
            set { Set(ref _stockCount, value); }
        }
        public User CurrentUser
        {
            get => _currentUser;
            set
            {
                Set(ref _currentUser, value); 
            }
        }

        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set { Set(ref _selectedProduct, value); }
        }




        public OrderPageViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger, IOrderRepository orderRepository,IWarehouseRepository warehouseRepository)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            _orderRepository = orderRepository;
            _warehouseRepository = warehouseRepository;
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as Product != null)
                {
                   SelectedProduct  = message.Data as Product;

                }
            });
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as User != null)
                {
                    CurrentUser = message.Data as User;
                }
            });
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as Warehouse  != null)
                {
                    StockCount = message.Data as Warehouse;
                }
            });
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as ObservableCollection<Order> != null)
                {
                    Orders = message.Data as ObservableCollection<Order>;
                }
            });
        }


        public RelayCommand Buy
        {
            get => new(
                () =>
                {
                    if (ProductCount > 0)
                    {
                        Order newOrder = new()
                        {
                            UserId = CurrentUser.Id,
                            ProductId = SelectedProduct.Id,
                            Status = "Order confirmed",
                            TotalPrice = SelectedProduct.Price * ProductCount,
                            ProductsCount = ProductCount
                        };
                        StockCount.Count -= ProductCount;
                        ProductCount = 0;
                        _orderRepository.Insert(newOrder);
                        _orderRepository.SaveChanges();
                        _warehouseRepository.SaveChanges();
                        Orders = new ObservableCollection<Order>(_orderRepository.GetAll());
                        StockCount = _warehouseRepository.GetByProductId(SelectedProduct.Id);
                        _dataService.SendData(Orders);
                        MessageBox.Show("Sucsessfully bought!");
                        _navigationService.NavigateTo<GoodsPageViewModel>();
                        
                    }
                    else
                        MessageBox.Show("You must buy at least 1 product");

                });
        }


        public RelayCommand AddProduct
        {
            get => new(
                () =>
                {
                    if(ProductCount != StockCount.Count)
                        ProductCount += 1;                
                });
        }

        public RelayCommand RemoveProduct
        {
            get => new(
                () =>
                {
                    if (ProductCount > 0)
                    {
                        ProductCount -= 1;
                    }
                });
        }

    }
}
