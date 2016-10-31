﻿using System;
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
        private string _OrderName;

        [Key()]
        public int OrderId { get; set; }

        /// <summary>
        /// Название заказа
        /// </summary>
        public string OrderName
        {
            get
            {
                return _OrderName;
            }
            set
            {
                _OrderName = WorkType.Name + Client.ClientName;
            }
        }

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
        public int Price { get; set; }

        /// <summary>
        /// Состояние заказа
        /// </summary>
        public int OrderState { get; set; }

        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        public virtual WorkType WorkType { get; set; }
    }
}