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
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class OrderPageViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        public DBContext _dbContext;
        public Product _selectedProduct;
        public User _currentUser;
        public int _productCount = 0;
        public int ProductCount
        {
            get { return _productCount; }
            set { Set(ref _productCount, value); }
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




        public OrderPageViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
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
        }


        public RelayCommand Buy
        {
            get => new(
                () =>
                {
                    Order newOrder = new()
                    {
                        UserId = CurrentUser.Id,
                        ProductId = SelectedProduct.Id,
                        Status = 1,
                        TotalPrice = SelectedProduct.Price
                    };
                    _dbContext = new();
                    _dbContext.Orders.Add(newOrder);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Sucsessfully bought!");
                    _navigationService.NavigateTo<GoodsPageViewModel>();

                });
        }


        public RelayCommand AddProduct
        {
            get => new(
                () =>
                {
                    ProductCount += 1;                
                });
        }

        public RelayCommand RemoveProduct
        {
            get => new(
                () =>
                {
                    if (ProductCount > 0)
                        ProductCount -= 1;
                });
        }

    }
}
