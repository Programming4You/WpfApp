using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Common;
using WpfApp.Orders;
using WpfApp.Service;
using WpfApp.Service.MockupService;
using WpfApp.WpfCommon;

namespace WpfApp.Customers
{
    public class CustomersViewModel : ViewModel
    {
        private ObservableCollection<CustomerModel> customers;

        public ObservableCollection<CustomerModel> Customers
        {
            get { return customers; }
            set { SetProperty(ref customers, value); }
        }


        private CustomerModel selectedCustomer;

        public CustomerModel SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                SetProperty(ref selectedCustomer, value);

                if (this.selectedCustomer != null)
                {
                    this.CustomerEdit = new CustomerModel();
                    this.SelectedCustomer.CopyTo(this.CustomerEdit);
                }
                else
                    this.CustomerEdit = null;

                this.SaveCommand.RaiseCanExecuteChanged();
                this.CancelCommand.RaiseCanExecuteChanged();

                this.LoadOrdersOfSelectedCustomers();
            }
        }



        private CustomerModel customerEdit;

        public CustomerModel CustomerEdit
        {
            get { return customerEdit; }
            set { SetProperty(ref customerEdit, value); }
        }




        public CustomersViewModel()
        {
            this.LoadCustomers();
            this.InitializeCommands();
        }

        public void InitializeCommands()
        {
            this.DeleteCommand = new RelayCommand<CustomerModel>(DeleteExecute);
            this.SaveCommand = new RelayCommand(SaveExecute, CanSave);
            this.CancelCommand = new RelayCommand(CancelExecute, CanCancel);
        }


        public void LoadCustomers()
        {
            ICustomerService customerService = new CustomerService();
            IEnumerable<CustomerModel> customers = customerService.GetAll();
            this.Customers = new ObservableCollection<CustomerModel>(customers);
        }




        public RelayCommand<CustomerModel> DeleteCommand { get; set; }

        private void DeleteExecute(CustomerModel customer)
        {
            ICustomerService customerService = new CustomerService();
            customerService.Remove(customer.Id);
            this.LoadCustomers(); 
        }



        public RelayCommand SaveCommand { get; set; }
        public RelayCommand CancelCommand { get; set; }


        private void SaveExecute()
        {
            this.CustomerEdit.CopyTo(this.SelectedCustomer);
        }

        private void CancelExecute()
        {
            this.SelectedCustomer.CopyTo(this.CustomerEdit);
        }


        private bool CanSave()
        {
            return this.SelectedCustomer != null;
        }

        private bool CanCancel()
        {
            return this.SelectedCustomer != null;
        }




        //Orders

        private ObservableCollection<OrderModel> orders;

        public ObservableCollection<OrderModel> Orders
        {
            get { return orders; }
            set { SetProperty(ref orders, value); }
        }


        private OrderModel selectedOrder;

        public OrderModel SelectedOrder
        {
            get { return selectedOrder; }
            set { SetProperty(ref selectedOrder, value); }
        }


        public void LoadOrdersOfSelectedCustomers()
        {
            IOrderService orderService = new OrderService();
            IEnumerable<OrderModel> orders = orderService.GetByCustomerId(this.SelectedCustomer.Id);
            this.Orders = new ObservableCollection<OrderModel>(orders);
        }

    }
}
