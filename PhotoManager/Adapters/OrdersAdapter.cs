using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoManager.ProxyClasses;

namespace PhotoManager.Adapters
{
    public class OrdersAdapter
    {
        public static List<PrxOrder> GetList(PmContext pmContext)
        {
            IQueryable<PrxOrder> getList = from qr in pmContext.Orders
                                           select new PrxOrder
                                           {
                                               Id = qr.OrderId,
                                               Name = qr.OrderName,
                                               Note = qr.OrderNote,
                                               OrderDate = qr.OrderDate,
                                               OrderState = (OrderState)qr.OrderState,
                                               Price=qr.Price,
                                               WorkAddress=qr.WorkAddress,
                                               WorkDate=qr.WorkDate,
                                               CustomerName=qr.Customer.CustomerName,
                                               WorkType=qr.WorkType.WorkTypeName
                                           };
            List<PrxOrder> orders = getList.ToList();
            return orders;
        }

        public static List<PrxOrder> GetListSql()
        {
            List<PrxOrder> prxOrders = new List<PrxOrder>();

            using (PmContext pmContext = new PmContext())
            {
                var orders = pmContext.Orders.SqlQuery("select * from dbo.Orders").ToList();
                foreach (var item in orders)
                {
                    prxOrders.Add(item.CopyToProxy());
                }
                return prxOrders;
            }
        }
    }
}
