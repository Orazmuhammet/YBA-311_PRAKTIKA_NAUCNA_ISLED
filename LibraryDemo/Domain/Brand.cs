// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>

namespace Domain
{
    using System;
    using System.Collections.Generic;
    using Staff.Extensions;

    /// <summary>
    ///  класс Бренд (марка автомобиля).
    /// </summary>
    public class Brand
    {

        /// <summary>
        /// Конструктор инициализации 
        /// </summary>

        public Brand(int id_brand, string name_brand, string country)
        {
            this.Id_brand = id_brand;
            this.Name_brand = name_brand ?? throw new ArgumentOutOfRangeException(nameof(name_brand));
            this.Country = country ?? throw new ArgumentOutOfRangeException(nameof(country));
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Brand"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Brand()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int Id_brand { get; protected set; }


        /// <summary>
        /// Брэнд.
        /// </summary>
        public virtual string Name_brand { get; protected set; }

        /// <summary>
        /// Страна.
        /// </summary>
        public virtual string Country { get; protected set; }


        /// <summary>
        /// Коллекция машин.
        /// </summary>
        public virtual ISet<Phone> Phons { get; protected set; } = new HashSet<Phone>();

        
        /// <summary>
        /// Добавить машине бренд.
        /// </summary>
        /// <param name="phone"> Машина. </param>
        /// <returns> <see langword="true"/> если машине был добавлен бренд. </returns>
        public virtual bool AddPhone(Phone phone)
        {
            return this.Phons.TryAdd(phone) ?? throw new ArgumentNullException(nameof(phone));
        }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.Name_brand} {this.Country}";
        }

    }
}
