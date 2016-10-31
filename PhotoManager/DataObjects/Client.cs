using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.DataObjects
{
    public class Client
    {

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Note { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
