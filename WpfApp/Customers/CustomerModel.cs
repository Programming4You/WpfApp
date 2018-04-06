using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Common;

namespace WpfApp.Customers
{
    public class CustomerModel : DataObject
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { SetProperty(ref firstName, value); }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { SetProperty(ref lastName, value); }
        }


        public override void CopyTo(DataObject target)
        {
            base.CopyTo(target);
            CustomerModel customer = target as CustomerModel;
            customer.FirstName = this.FirstName;
            customer.LastName = this.LastName;
        }
    }
}
