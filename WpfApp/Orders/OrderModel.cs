using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Common;

namespace WpfApp.Orders
{
    public class OrderModel : DataObject
    {
        private DateTime orderDate;

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { SetProperty(ref orderDate, value); }
        }


        private decimal subTotal;

        public decimal SubTotal
        {
            get { return subTotal; }
            set { SetProperty(ref subTotal, value); }
        }



        private decimal taxAmt;

        public decimal TaxAmt
        {
            get { return taxAmt; }
            set { SetProperty(ref taxAmt, value); }
        }

        private decimal freight;

        public decimal Freight
        {
            get { return freight; }
            set { SetProperty(ref freight, value); }
        }


        private decimal totalDue;

        public decimal TotalDue
        {
            get { return totalDue; }
            set { SetProperty(ref totalDue, value); }
        }

        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set { SetProperty(ref customerId, value); }
        }
    }
}
