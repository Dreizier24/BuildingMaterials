using System;
using System.Collections.Generic;
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
using BuildingMaterials.ViewModel;

namespace BuildingMaterials.View
{
    /// <summary>
    /// Логика взаимодействия для AppMainWindow.xaml
    /// </summary>
    public partial class AppMainWindow : Window
    {
        private Product _product;
        public AppMainWindow(Product product)
        {
            InitializeComponent();

            this.DataContext = new AppMainWindowVM();
        }

        private void AddNewItem_Click(object sender, RoutedEventArgs e)
        {
            var addProdcutWindow = new AddOrRewriteProductWindow(null);
            addProdcutWindow.Show();
        }

        private void RewriteItem_Click(object sender, RoutedEventArgs e)
        {
            var rewriteProductWindow = new AddOrRewriteProductWindow((DataContext as AppMainWindowVM).SelectedProduct);
            rewriteProductWindow.Show();
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            (DataContext as AppMainWindowVM).DeleteSelectedData();
        }

        public void RefreshData()
        {
            (DataContext as AppMainWindowVM).LoadData();
        }
    }
}
