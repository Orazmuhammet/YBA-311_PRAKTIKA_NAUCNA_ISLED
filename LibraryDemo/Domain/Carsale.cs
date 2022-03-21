// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>

namespace Domain
{
    using System;
    using System.Collections.Generic;

    using Staff.Extensions;

    /// <summary>
    /// класс Продажа Телефонов.
    /// </summary>
    public class PhoneSale
    {
        public PhoneSale(int id_phoneSale, DateTime sale_date, double total_price, Phone phone, Worker worker)
        {
            if (phone == null)
            {
                throw new ArgumentNullException(nameof(phone));
            }

            if (worker == null)
            {
                throw new ArgumentNullException(nameof(worker));
            }
            this.Id_phoneSale = id_phoneSale;
            this.Sale_date = sale_date;
            this.Total_price = total_price;
        }

        public PhoneSale(int id_phoneSale, DateTime sale_date, double total_price)
        {
            this.Id_phoneSale = id_phoneSale;
            this.Sale_date = sale_date;
            this.Total_price = total_price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PhoneSale"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected PhoneSale()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int Id_phoneSale { get; protected set; }


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
