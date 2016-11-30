using PhotoManager.ProxyClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.DataObjects
{
    public class WorkType
    {

        [Key()]
        public int WorkTypeId { get; set; }

        public string WorkTypeName { get; set; }

        public string WorkTypeNote { get; set; }

        public PrxWorkType CopyToProxy()
        {
            PrxWorkType prxWorkType = new PrxWorkType()
            {
                Id = this.WorkTypeId,
                Name = this.WorkTypeName,
                Note = this.WorkTypeNote
            };
            return prxWorkType;
        }
    }
}
