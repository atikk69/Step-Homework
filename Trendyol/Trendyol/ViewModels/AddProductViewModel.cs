using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using Trendyol.Messages;
using Trendyol.Models;
using Trendyol.Repository;
using Trendyol.Services.Interfaces;

namespace Trendyol.ViewModels
{
    class AddProductViewModel : ViewModelBase
    {

        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        IWarehouseRepository _warehouseRepository;
        IProductRepository _productRepository;
        public string _name;
        public string _description;
        public float _price;
        public int _productCount;
        public byte[] _selectedImage;
        public ObservableCollection<Product> _products;
        public ObservableCollection<Warehouse> Warehouse;

        public byte[] SelectedImage
        {
            get { return _selectedImage; }
            set { Set(ref _selectedImage, value); }
        }
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { Set(ref _products, value); }
        }
        public string Description
        {
            get { return _description; }
            set { Set(ref _description, value); }
        }
        public float Price
        {
            get { return _price; }
            set { Set(ref _price, value); }
        }
        public int ProductCount
        {
            get { return _productCount; }
            set { Set(ref _productCount, value); }
        }

        public AddProductViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger, IWarehouseRepository warehouseRepository, IProductRepository productRepository)
        {
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            _warehouseRepository = warehouseRepository;
            _productRepository = productRepository;
            _messenger.Register<DataMessage>(this, message =>
            {
                if (message.Data as ObservableCollection<Product> != null)
                {
                    Products = message.Data as ObservableCollection<Product>;
                }
            });
        }

        public RelayCommand BrowseImage => new(() =>
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.tif; ...";
            if (openFileDialog.ShowDialog() == true)
            {
                SelectedImage = File.ReadAllBytes(openFileDialog.FileName);
            }
        });

        public RelayCommand AddProduct => new(() =>
        {
            if (Name != null && Description != null && Price != 0 && SelectedImage != null)
            {
                Product newProduct = new()
                {
                    Name = Name,
                    Description = Description,
                    Price = Price,
                    Image = SelectedImage
                };
                _productRepository.Insert(newProduct);
                _productRepository.SaveChanges();
                Warehouse warehouse = new()
                {
                    ProductId = newProduct.Id,
                    Count = ProductCount
                };
                _warehouseRepository.Insert(warehouse);
                _warehouseRepository.SaveChanges();
                Products = new ObservableCollection<Product>(_productRepository.GetAll());
                _dataService.SendData(Products);
                MessageBox.Show("Sucessfully added new product!🥒");
            }
            else
                MessageBox.Show("Something wet wrong!Please try again");
            Name = "";
            Description = "";
            Price = 0;
        });

        public RelayCommand Exit => new(() =>
        {
            _navigationService.NavigateTo<AdminMenuViewModel>();
        });

    }
}
