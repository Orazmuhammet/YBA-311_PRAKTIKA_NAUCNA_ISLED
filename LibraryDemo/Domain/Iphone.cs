// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>

namespace Domain
{
    using System;
    using System.Collections.Generic;
    using Staff.Extensions;

    /// <summary>
    /// класс Phone.
    /// </summary>
    public class Phone
    {
        /// <summary>
        /// конструктор 
        /// </summary>

        public Phone(int id_phone, int year, string color, double price, Model model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            this.Id_phone = id_phone;
            this.Year = year;
            this.Color = color;
            this.Price = price;
        }

        public Phone(int id_phone, int year, string color, double price)
        {
            this.Id_phone = id_phone;
            this.Year = year;
            this.Color = color;
            this.Price = price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Phone"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Phone()
        {
        }


        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int Id_phone { get; protected set; }

        /// <summary>
        /// год выпуска.
        /// </summary>
        public virtual int Year { get; protected set; }
        /// <summary>
        /// цвет .
        /// </summary>
        public virtual string Color { get; protected set; }
        /// <summary>
        /// базовая стоимость.
        /// </summary>
        public virtual double Price { get; protected set; }

        public virtual Model Model { get; protected set; }
        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        /// <summary>
        /// Коллекция продаж телефона.
        /// </summary>
        public virtual ISet<PhoneSale> PhoneSales { get; protected set; } = new HashSet<PhoneSale>();

        /// <summary>
        /// Добавить телефону на продажу.
        /// </summary>
        /// <param name="phoneSale"> Продажа телефоны. </param>
        /// <returns> <see langword="true"/> если телефону поставили на продажу. </returns>
        public virtual bool AddPhoneSale(PhoneSale phoneSale)
        {
            return this.PhoneSales.TryAdd(phoneSale) ?? throw new ArgumentNullException(nameof(phoneSale));
        }

        public override string ToString()
        {
            return $"{this.Year} {this.Color} {this.Price}";
        }

    }
}
