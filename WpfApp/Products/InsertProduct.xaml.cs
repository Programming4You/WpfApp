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
    /// Interaction logic for InsertProduct.xaml
    /// </summary>
    public partial class InsertProduct : Window
    {
        WpfAppDBEntities entities = new WpfAppDBEntities();

        public InsertProduct()
        {
            InitializeComponent();
            dateDatePicker.SelectedDate = DateTime.Today;
        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product()
                {
                    ModifiedDate = DateTime.Parse(dateDatePicker.Text),
                    Name = nameTextBox.Text,
                    Price = Decimal.Parse(priceTextBox.Text),
                    Weight = Decimal.Parse(weightTextBox.Text)
                };

                entities.Products.Add(product);
                entities.SaveChanges();
                ProductsView.datagrid.ItemsSource = entities.Products.ToList();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
