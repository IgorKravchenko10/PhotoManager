using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoManager.ProxyClasses
{
    public enum OrderState
    {
        Виконується = 0,
        Виконаний = 1,
        Скасований = 2
    }

    public class PrxOrder : PrxBaseClass
    {
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
        public int Price { get; set; }

        /// <summary>
        /// Состояние заказа
        /// </summary>
        public OrderState OrderState { get; set; }


    }
}
