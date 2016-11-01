using PhotoManager.ProxyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.Adapters
{
    public class WorkTypesAdapter
    {
        public List<PrxWorkType> GetList(PmContext pmContext)
        {

            IQueryable<PrxWorkType> getList = from qr in pmContext.WorkTypes
                                            select new PrxWorkType
                                            {
                                                Id = qr.WorkTypeId,
                                                Name = qr.WorkTypeName,
                                                Note=qr.WorkTypeNote
                                            };
            List<PrxWorkType> workTypes = getList.ToList();
            return workTypes;
        }

        public List<PrxWorkType> GetListSql()
        {
            List<PrxWorkType> prxWorkTypes = new List<PrxWorkType>();

            using (PmContext pmContext = new PmContext())
            {
                var workTypes = pmContext.WorkTypes.SqlQuery("select * from dbo.WorkTypes").ToList();
                foreach (var item in workTypes)
                {
                    prxWorkTypes.Add(item.CopyToProxy());
                }
                return prxWorkTypes;
            }
        }
    }
}
