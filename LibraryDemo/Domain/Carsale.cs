// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>

namespace Domain
{
    using System;
    using System.Collections.Generic;

    using Staff.Extensions;

    /// <summary>
    /// класс Продажа автомобиля.
    /// </summary>
    public class Carsale
    {
        public Carsale(int id_carsale, DateTime sale_date, double total_price, Phone phone, Worker worker)
        {
            if (phone == null)
            {
                throw new ArgumentNullException(nameof(phone));
            }

            if (worker == null)
            {
                throw new ArgumentNullException(nameof(worker));
            }
            this.Id_carsale = id_carsale;
            this.Sale_date = sale_date;
            this.Total_price = total_price;
        }

        public Carsale(int id_carsale, DateTime sale_date, double total_price)
        {
            this.Id_carsale = id_carsale;
            this.Sale_date = sale_date;
            this.Total_price = total_price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Carsale"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Carsale()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int Id_carsale { get; protected set; }


        /// <summary>
        /// Дата продажи.
        /// </summary>
        public virtual DateTime Sale_date { get; protected set; }

        /// <summary>
        /// итоговая стоимость.
        /// </summary>
        public virtual double Total_price { get; protected set; }

        public virtual Phone Phone { get; protected set; }

        public virtual Worker Worker { get; protected set; }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.Sale_date} {this.Total_price}";
        }
    }
}
