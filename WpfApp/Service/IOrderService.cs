using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Orders;

namespace WpfApp.Service
{
    public interface IOrderService : IService<OrderModel>
    {
        IEnumerable<OrderModel> GetByCustomerId(int customerId);
    }
}
