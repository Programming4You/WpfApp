using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Common;

namespace WpfApp.Products
{
    public class ProductModel : DataObject
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }


        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { SetProperty(ref price, value); }
        }


        private decimal? weight;

        public decimal? Weight
        {
            get { return weight; }
            set { SetProperty(ref weight, value); }
        }
    }
}
