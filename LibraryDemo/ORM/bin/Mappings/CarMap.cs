// <copyright file="Car.cs" company="Лёвин И. Д.">
// Copyright (c) Лёвин И. Д.. All rights reserved.
// </copyright>

namespace ORM.Mappings
{
    using Domain;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Car"/> на таблицу и наоборот.
    /// </summary>
    internal class CarMap : ClassMap<Car>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CarMap"/>.
        /// </summary>
        public CarMap()
        {
            // this.Schema("dbo");

            this.Table("Cars");

            this.Id(x => x.Id_car).Not.Nullable();

            this.Map(x => x.Year).Not.Nullable();
            this.Map(x => x.Color).Not.Nullable();
            this.Map(x => x.Price).Not.Nullable();

            this.HasMany(x => x.Carsales);
            this.References(x => x.Brand);
        }
    }
}
