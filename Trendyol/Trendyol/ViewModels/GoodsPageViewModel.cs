using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Trendyol.Models;
using Trendyol.Services.Interfaces;
using Trendyol.Views;

namespace Trendyol.ViewModels
{
    class GoodsPageViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationService;
        private readonly IDataService _dataService;
        public DBContext _dbContext;
        public int _productCount = 0;
        private readonly ObservableCollection<Product> _products;
        public Product _selectedProduct;

        public ObservableCollection<Product> Products { get; set; }

        public int ProductCount
        {
            get { return _productCount; }
            set { Set(ref _productCount, value); }
        }

        public GoodsPageViewModel(INavigationService navigationService, IDataService dataService, IMessenger messenger, DBContext dBContext)
        {
            _dbContext = dBContext;
            _navigationService = navigationService;
            _dataService = dataService;
            _messenger = messenger;
            Products =  new ObservableCollection<Product>(_dbContext.Products);
        }


        public RelayCommand Buy
        {
            get => new(
                () =>
                {
                   
                });
        }

    }
}

