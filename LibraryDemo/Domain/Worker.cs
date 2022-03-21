// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>
namespace Domain
{
    using System;
    using System.Collections.Generic;
    using Staff.Extensions;

    /// <summary>
    ///  класс Сотрудник.
    /// </summary>
    public class Worker
    {
        public Worker(int id_worker, string fio, string working)
        {
            this.Id_worker = id_worker;
            this.FIO = fio;
            this.Working = working;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Worker"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Worker()
        {
        }

        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int Id_worker { get; protected set; }

        /// <summary>
        /// ФИО.
        /// </summary>
        public virtual string FIO { get; protected set; }

        /// <summary>
        /// Роль.
        /// </summary>
        public virtual string Working { get; protected set; }

        /// <summary>
        /// Коллекция машин.
        /// </summary>
        public virtual ISet<Carsale> Carsales { get; protected set; } = new HashSet<Carsale>();


        /// <summary>
        /// Добавить продавца в продажу.
        /// </summary>
        /// <param name="carsale"> Продажа машины. </param>
        /// <returns> <see langword="true"/> если продавца добавили в продажу. </returns>
        public virtual bool AddCarsale(Carsale carsale)
        {
            return this.Carsales.TryAdd(carsale) ?? throw new ArgumentNullException(nameof(carsale));
        }

        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        public override string ToString()
        {
            return $"{this.FIO} {this.Working}";
        }
    }
}
