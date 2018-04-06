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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Service.MockupService.Data;

namespace WpfApp.Products
{
    /// <summary>
    /// Interaction logic for ProductsView.xaml
    /// </summary>
    public partial class ProductsView : UserControl
    {
        WpfAppDBEntities entities = new WpfAppDBEntities();

        public static DataGrid datagrid;

        private void Load()
        {
            dataGridProduct.ItemsSource = entities.Products.ToList();
            datagrid = dataGridProduct;
        }

        public ProductsView()
        {
            InitializeComponent();
            this.Load();
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            InsertProduct Iproduct = new InsertProduct();
            Iproduct.ShowDialog();
        }



        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int Id = (dataGridProduct.SelectedItem as Product).Id;
            UpdateProduct Uproduct = new UpdateProduct(Id);
            Uproduct.ShowDialog();
        }



        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("Delete product?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                int Id = (dataGridProduct.SelectedItem as Product).Id;
                var deleteProduct = entities.Products.Where(p => p.Id == Id).Single();
                entities.Products.Remove(deleteProduct);
                entities.SaveChanges();
                dataGridProduct.ItemsSource = entities.Products.ToList();
            }

         
        }
    }
}
