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
    public class Order
    {

        [Key()]
        public int OrderId { get; set; }

        /// <summary>
        /// Название заказа
        /// </summary>
        public string OrderName { get; set; }

        /// <summary>
        /// Дата заказа работы
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Дата проведения работы
        /// </summary>
        public DateTime WorkDate { get; set; }

        /// <summary>
        /// Место выполнения работы
        /// </summary>
        public string WorkAddress { get; set; }

        /// <summary>
        /// Цена заказа
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Состояние заказа
        /// </summary>
        public int OrderState { get; set; }

        public string OrderNote { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public int WorkTypeId { get; set; }

        public virtual WorkType WorkType { get; set; }

        public PrxOrder CopyToProxy()
        {
            PrxOrder prxOrder = new PrxOrder()
            {
                Id = this.OrderId,
                Name = this.OrderName,
                Note = this.OrderNote,
                OrderDate = this.OrderDate,
                OrderState = (OrderState)this.OrderState,
                Price = this.Price,
                WorkAddress = this.WorkAddress,
                WorkDate = this.WorkDate

            };
            return prxOrder;
        }
    }
}
