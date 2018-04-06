using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.WpfCommon;

namespace WpfApp.Common
{
    public class DataObject : BindableBase
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }


        private DateTime modifiedDate;

        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { SetProperty(ref modifiedDate, value); }
        }


        public virtual void CopyTo(DataObject target)
        {
            target.Id = this.Id;
            target.ModifiedDate = this.ModifiedDate;
        }

    }
}
