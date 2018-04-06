using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Common;
using WpfApp.Customers;
using WpfApp.Orders;
using WpfApp.Products;
using WpfApp.WpfCommon;

namespace WpfApp
{
    public class MainWindowViewModel : ViewModel
    {

        private ViewModel currentViewModel;

        public ViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set { SetProperty(ref currentViewModel, value); }
        }


        private CustomersViewModel customersViewModel = new CustomersViewModel();
        private ProductsViewModel productsViewModel = new ProductsViewModel();
        private OrdersViewModel ordersViewModel = new OrdersViewModel();



        public RelayCommand<string> NavigationCommand { get; private set; }


        private void OnNavigate(string destination)
        {
            switch (destination)
            {
                case "customersList":
                    this.CurrentViewModel = customersViewModel;
                    break;
                case "productsList":
                    this.CurrentViewModel = productsViewModel;
                    break;
                case "ordersList":
                    this.CurrentViewModel = ordersViewModel;
                    break;
            }
        }


        public MainWindowViewModel()
        {
            this.NavigationCommand = new RelayCommand<string>(OnNavigate);
        }

    }
}
