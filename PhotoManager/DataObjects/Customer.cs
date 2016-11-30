using PhotoManager.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.DataObjects
{
    public class Customer
    {

        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string CustomerNote { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();

        public PrxCustomer CopyToProxy()
        {
            PrxCustomer prxCustomer = new PrxCustomer()
            {
                Id = this.CustomerId,
                Name = this.CustomerName,
                Address = this.Address,
                Note = this.CustomerNote,
                PhoneNumber = this.PhoneNumber
            };
            return prxCustomer;
        }
    }
}
