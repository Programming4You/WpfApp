using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Common;
using WpfApp.Service;
using WpfApp.Service.MockupService;

namespace WpfApp.Orders
{
    public class OrdersViewModel : ViewModel
    {
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


        public OrdersViewModel()
        {
            this.LoadOrders();
        }


        public void LoadOrders()
        {
            IOrderService orderService = new OrderService();
            IEnumerable<OrderModel> orders = orderService.GetAll();
            this.Orders = new ObservableCollection<OrderModel>(orders);
        }
    }
}
