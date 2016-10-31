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
        [ForeignKey("Order")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Note { get; set; }

        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
