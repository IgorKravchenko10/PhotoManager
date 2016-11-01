using PhotoManager.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Adapters
{
    public class ClientsAdapter
    {

        public List<PrxClient> GetList(PmContext pmContext)
        {

            IQueryable<PrxClient> getList = from qr in pmContext.Clients
                                            select new PrxClient
                                            {
                                                Id = qr.ClientId,
                                                Name = qr.ClientName,
                                                Address = qr.Address,
                                                Note = qr.ClientNote,
                                                PhoneNumber = qr.PhoneNumber
                                            };
            List<PrxClient> clients = getList.ToList();
            return clients;
        }

        public List<PrxClient> GetListSql()
        {
            List<PrxClient> prxClients = new List<PrxClient>();

            using (PmContext pmContext=new PmContext())
            {
                var clients = pmContext.Clients.SqlQuery("select * from dbo.Clients").ToList();
                foreach(var item in clients)
                {
                    prxClients.Add(item.CopyToProxy());
                }
                return prxClients;
            }
        }

    }
}
