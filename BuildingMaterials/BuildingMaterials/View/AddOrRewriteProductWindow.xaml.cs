using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BuildingMaterials.DbStorage;

namespace BuildingMaterials.View
{
    /// <summary>
    /// Логика взаимодействия для AddOrRewriteProductWindow.xaml
    /// </summary>
    public partial class AddOrRewriteProductWindow : Window
    {

        Product _product;
        public AddOrRewriteProductWindow(Product product)
        {
            InitializeComponent();

            foreach (var item in App.Current.Windows)
            {
                if (item is GoodsWindow)
                    this.Owner = item as Window;
            }
            if (product is null)
            {
                _product = product = new Product();
            }
            else
            {
                _product = product;
            }

            this.DataContext = _product;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new TradeEntities())
            {
                try
                {
                    db.Product.AddOrUpdate(_product);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены!","",MessageBoxButton.OK,MessageBoxImage.Information);
                    (Owner as GoodsWindow)?.RefreshData();
                    Owner.Focus();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
