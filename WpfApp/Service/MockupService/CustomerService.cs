using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Customers;
using WpfApp.Service.MockupService.Data;

namespace WpfApp.Service.MockupService
{
    public class CustomerService : ICustomerService
    {
        WpfAppDBEntities entities = new WpfAppDBEntities();

        public void Add(CustomerModel obj)
        {
            entities.Customers.Add(new Customer
            {
                Id = obj.Id,
                ModifiedDate = obj.ModifiedDate,
                FirstName = obj.FirstName,
                LastName = obj.LastName
            });
        }

        public void Edit(CustomerModel obj)
        {
            Customer customerDto = entities.Customers.FirstOrDefault(x => x.Id == obj.Id);
            customerDto.ModifiedDate = obj.ModifiedDate;
            customerDto.FirstName = obj.FirstName;
            customerDto.LastName = obj.LastName;
        }

        public CustomerModel Get(int id)
        {
            Customer customerDto = entities.Customers.FirstOrDefault(x => x.Id == id);
            return new CustomerModel
            {
                Id = customerDto.Id,
                ModifiedDate = customerDto.ModifiedDate,
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName
            };
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            return entities.Customers.Select(x => new Customers.CustomerModel()
            {
                Id = x.Id,
                ModifiedDate = x.ModifiedDate,
                FirstName = x.FirstName,
                LastName = x.LastName
            });
        }

        public void Remove(int id)
        {
            var customer = entities.Customers.Where(x => x.Id == id).FirstOrDefault();
            entities.Customers.Remove(customer);
            entities.SaveChanges();
        }
    }
}
