// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>

namespace Domain
{
    using System;
    using System.Collections.Generic;
    using Staff.Extensions;

    /// <summary>
    ///  класс Model (марка автомобиля).
    /// </summary>
    public class Model
    {

        /// <summary>
        /// Конструктор инициализации 
        /// </summary>

        public Model(int id_model, string name_model, string country)
        {
            this.Id_model = id_model;
            this.Name_model = name_model ?? throw new ArgumentOutOfRangeException(nameof(name_model));
            this.Country = country ?? throw new ArgumentOutOfRangeException(nameof(country));
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Model"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Model()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int Id_model { get; protected set; }


        /// <summary>
        /// Model
        /// </summary>
        public virtual string Name_model { get; protected set; }

        /// <summary>
        /// Страна.
        /// </summary>
        public virtual string Country { get; protected set; }


        /// <summary>
        /// Коллекция Model.
        /// </summary>
        public virtual ISet<Phone> Phons { get; protected set; } = new HashSet<Phone>();

        
        /// <summary>
        /// Добавить phone model.
        /// </summary>
        /// <param name="phone"> Phone. </param>
        /// <returns> <see langword="true"/> если телефоне был добавлен model. </returns>
        public virtual bool AddPhone(Phone phone)
        {
            return this.Phons.TryAdd(phone) ?? throw new ArgumentNullException(nameof(phone));
        }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.Name_model} {this.Country}";
        }

    }
}
