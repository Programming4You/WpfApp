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
using WpfApp.Service.MockupService.Data;

namespace WpfApp.Products
{
    /// <summary>
    /// Interaction logic for UpdateProduct.xaml
    /// </summary>
    public partial class UpdateProduct : Window
    {
        WpfAppDBEntities entities = new WpfAppDBEntities();
        int Id;

        public UpdateProduct(int idProduct)
        {
            InitializeComponent();
            Id = idProduct;

            Product product = (from p in entities.Products
                               where p.Id == Id
                               select p).FirstOrDefault();

            dateDatePicker.SelectedDate = product.ModifiedDate;
            nameTextBox.Text = product.Name;
            priceTextBox.Text = (product.Price).ToString();
            weightTextBox.Text = (product.Weight).ToString();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = (from p in entities.Products
                                   where p.Id == Id
                                   select p).Single();

                product.ModifiedDate = DateTime.Parse(dateDatePicker.Text);
                product.Name = nameTextBox.Text;
                product.Price = Decimal.Parse(priceTextBox.Text);
                product.Weight = Decimal.Parse(weightTextBox.Text);

                entities.SaveChanges();
                ProductsView.datagrid.ItemsSource = entities.Products.ToList();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
