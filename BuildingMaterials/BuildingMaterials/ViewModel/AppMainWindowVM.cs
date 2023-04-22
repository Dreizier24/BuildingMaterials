using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BuildingMaterials.DbStorage;
using System.IO;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media.Imaging;

namespace BuildingMaterials.ViewModel
{
    public class AppMainWindowVM : BaseViewModel
    {
        string qwerty = "123";

        private ObservableCollection<Product> _product;
        public ObservableCollection<Product> Product
        {
            get => _product;
            set
            {
                _product = value;
                OnPropertyChanged(nameof(Product));
            }
        }

        private Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        private int _productId;
        public int ProductId 
        { 
            get => _productId; 
            set
            {
                _productId = value;
                OnPropertyChanged(nameof(ProductId));
            }

        }
        private string _productArticleNumber;
        public string ProductArticleNumber 
        { 
            get => _productArticleNumber; 
            set 
            {
                _productArticleNumber = value;
                OnPropertyChanged(nameof(ProductArticleNumber));
            }
        }
        private string _productName;
        public string ProductName 
        { 
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }
        private int _unitId;
        public int UnitId 
        {
            get => _unitId;
            set
            {
                _unitId = value;
                OnPropertyChanged(nameof(UnitId));
            }
        }
        private decimal _productPrice;
        public decimal ProductPrice 
        {
            get => _productPrice;
            set
            {
                _productPrice = value;
                OnPropertyChanged(nameof(ProductPrice));
            }
        }
        private int _maxDiscount;
        public int MaxDiscount 
        { 
            get => _maxDiscount; 
            set
            {
                _maxDiscount = value;
                OnPropertyChanged(nameof(MaxDiscount));
            }
        }
        private int _manufacturerId;
        public int ManufacturerId 
        { 
            get => _manufacturerId; 
            set
            {
                _manufacturerId = value;
                OnPropertyChanged(nameof(ManufacturerId));
            }
        }
        private int _supplierID;
        public int SupplierId 
        { 
            get => _supplierID; 
            set 
            {
                _supplierID = value;
                OnPropertyChanged(nameof(SupplierId));
            } 
        }
        private int _categoryId;
        public int CategoryId 
        { 
            get => _categoryId; 
            set
            {
                _categoryId = value;
                OnPropertyChanged(nameof(CategoryId));
            }

        }
        private Nullable<int> _currentDiscount;
        public Nullable<int> CurrentDiscount 
        { 
            get => _currentDiscount; 
            set 
            {
                _currentDiscount = value;
                OnPropertyChanged(nameof(CurrentDiscount));
            } 
        }
        private int _storageAmount;
        public int StorageAmount
        {
            get => _storageAmount; 
            set
            {
                _storageAmount = value;
                OnPropertyChanged(nameof(StorageAmount));
            }
        }
        private string _description;
        public string Description 
        { 
            get => _description; 
            set 
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            } 
        }
        private string _productPhoto;

        public string ProductPhoto 
        { 
            get => _productPhoto;
            set
            {
                _productPhoto = value;
                OnPropertyChanged(nameof(ProductPhoto));
            }
        }

        public AppMainWindowVM()
        {
            Product = new ObservableCollection<Product>();
            LoadData();
        }

        public void LoadData()
        {
            if (Product.Count > 0)
                Product.Clear();
            var res = DBStorage.DB_s.Product.ToList();
            res.ForEach(elem => Product?.Add(elem));
        }
        
        public void DeleteSelectedData()
        {
            if (!(SelectedProduct is null))
            {
                using (var db = new TradeEntities())
                {
                    var res = MessageBox.Show("Вы уверены, что хотите удалить выбранный элемент?\n" +
                        "Это действие невозможно отменить","Предупреждение",MessageBoxButton.YesNo,MessageBoxImage.Question);
                    if (res == MessageBoxResult.Yes)
                    {
                        try
                        {
                            var forDelete = db.Product.Where(elem => elem.ProductId == SelectedProduct.ProductId).FirstOrDefault();
                            db.Product.Remove(forDelete);
                            db.SaveChanges();
                            LoadData();
                            MessageBox.Show("Данные успешно удалены", "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }
    }
}
