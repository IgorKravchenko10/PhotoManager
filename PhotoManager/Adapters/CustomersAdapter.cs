using PhotoManager.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Adapters
{
    public class CustomersAdapter
    {

        public static List<PrxCustomer> GetList(PmContext pmContext)
        {

            IQueryable<PrxCustomer> getList = from qr in pmContext.Customers
                                            select new PrxCustomer
                                            {
                                                Id = qr.CustomerId,
                                                Name = qr.CustomerName,
                                                Address = qr.Address,
                                                Note = qr.CustomerNote,
                                                PhoneNumber = qr.PhoneNumber
                                            };
            List<PrxCustomer> customers = getList.ToList();
            return customers;
        }

        public static List<PrxCustomer> GetListSql()
        {
            List<PrxCustomer> prxCustomers = new List<PrxCustomer>();

            using (PmContext pmContext=new PmContext())
            {
                var customers = pmContext.Customers.SqlQuery("select * from dbo.Customers").ToList();
                foreach(var item in customers)
                {
                    prxCustomers.Add(item.CopyToProxy());
                }
                return prxCustomers;
            }
        }

    }
}
