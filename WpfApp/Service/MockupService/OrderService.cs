using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Orders;
using WpfApp.Service.MockupService.Data;

namespace WpfApp.Service.MockupService
{
    public class OrderService : IOrderService
    {
        WpfAppDBEntities entities = new WpfAppDBEntities();

        public void Add(OrderModel obj)
        {
            entities.Orders.Add(new Order
            {
                Id = obj.Id,
                ModifiedDate = obj.ModifiedDate,
                OrderDate = obj.OrderDate,
                SubTotal = obj.SubTotal,
                TaxAmt = obj.TaxAmt,
                TotalDue = obj.TotalDue,
                Freight = obj.Freight,
                CustomerId = obj.CustomerId
            });
        }

        public void Edit(OrderModel obj)
        {
            Order orderDto = entities.Orders.FirstOrDefault(x => x.Id == obj.Id);
            orderDto.ModifiedDate = obj.ModifiedDate;
            orderDto.OrderDate = obj.OrderDate;
            orderDto.SubTotal = obj.SubTotal;
            orderDto.TaxAmt = obj.TaxAmt;
            orderDto.TotalDue = obj.TotalDue;
            orderDto.Freight = obj.Freight;
            orderDto.CustomerId = obj.CustomerId;
        }

        public OrderModel Get(int id)
        {
            Order orderDto = entities.Orders.FirstOrDefault(x => x.Id == id);
            return new Orders.OrderModel
            {
                Id = orderDto.Id,
                ModifiedDate = orderDto.ModifiedDate,
                OrderDate = orderDto.OrderDate,
                SubTotal = orderDto.SubTotal,
                TaxAmt = orderDto.TaxAmt,
                TotalDue = orderDto.TotalDue,
                Freight = orderDto.Freight,
                CustomerId = orderDto.CustomerId
            };
        }

        public IEnumerable<OrderModel> GetAll()
        {
            return entities.Orders.Select(x => new OrderModel()
            {
                Id = x.Id,
                ModifiedDate = x.ModifiedDate,
                OrderDate = x.OrderDate,
                SubTotal = x.SubTotal,
                TaxAmt = x.TaxAmt,
                TotalDue = x.TotalDue,
                Freight = x.Freight,
                CustomerId = x.CustomerId
            });
        }

        public IEnumerable<OrderModel> GetByCustomerId(int customerId)
        {
            return entities.Orders.Where(x => x.CustomerId == customerId).Select(x => new OrderModel()
            {
                Id = x.Id,
                ModifiedDate = x.ModifiedDate,
                OrderDate = x.OrderDate,
                SubTotal = x.SubTotal,
                TaxAmt = x.TaxAmt,
                TotalDue = x.TotalDue,
                Freight = x.Freight,
                CustomerId = x.CustomerId
            });
        }

        public void Remove(int id)
        {
            var order = entities.Orders.Where(x => x.Id == id).FirstOrDefault();
            entities.Orders.Remove(order);
            entities.SaveChanges();
        }
    }
}
