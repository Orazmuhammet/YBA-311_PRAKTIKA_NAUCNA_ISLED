﻿// <copyright file="Car.cs" company=Лёвин И. Д.">
// Copyright (c) Лёвин И. Д... All rights reserved.
// </copyright>

namespace Domain
{
    using System;
    using System.Collections.Generic;
    using Staff.Extensions;

    /// <summary>
    /// класс Автомобиль.
    /// </summary>
    public class Car
    {
        /// <summary>
        /// конструктор 
        /// </summary>

        public Car(int id_car, int year, string color, double price, Brand brand)
        {
            if (brand == null)
            {
                throw new ArgumentNullException(nameof(brand));
            }

            this.Id_car = id_car;
            this.Year = year;
            this.Color = color;
            this.Price = price;
        }

        public Car(int id_car, int year, string color, double price)
        {
            this.Id_car = id_car;
            this.Year = year;
            this.Color = color;
            this.Price = price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Car"/>.
        /// </summary>
        // в этом месте  protected - только для ORM
        //
        [Obsolete("For ORM only", true)]
        protected Car()
        {
        }


        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public virtual int Id_car { get; protected set; }

        /// <summary>
        /// год выпуска.
        /// </summary>
        public virtual int Year { get; protected set; }
        /// <summary>
        /// цвет автомобиля.
        /// </summary>
        public virtual string Color { get; protected set; }
        /// <summary>
        /// базовая стоимость.
        /// </summary>
        public virtual double Price { get; protected set; }

        public virtual Brand Brand { get; protected set; }
        /// <summary>
        /// переопределение метода ToString
        /// </summary>

        /// <summary>
        /// Коллекция продаж машин.
        /// </summary>
        public virtual ISet<Carsale> Carsales { get; protected set; } = new HashSet<Carsale>();

        /// <summary>
        /// Добавить машину на продажу.
        /// </summary>
        /// <param name="carsale"> Продажа машины. </param>
        /// <returns> <see langword="true"/> если машину поставили на продажу. </returns>
        public virtual bool AddCarsale(Carsale carsale)
        {
            return this.Carsales.TryAdd(carsale) ?? throw new ArgumentNullException(nameof(carsale));
        }

        public override string ToString()
        {
            return $"{this.Year} {this.Color} {this.Price}";
        }

    }
}
