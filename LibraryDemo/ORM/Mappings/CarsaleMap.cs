// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>


namespace ORM.Mappings
{
    using Domain;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Carsale"/> на таблицу и наоборот.
    /// </summary>
    internal class CarsaleMap : ClassMap<Carsale>
    {
        public CarsaleMap ()
        {
            this.Table("Carsales");

            this.Id(x => x.Id_carsale).Not.Nullable();

            this.Map(x => x.Sale_date).Not.Nullable();
            this.Map(x => x.Total_price).Not.Nullable();

            this.References(x => x.Phone);
            this.References(x => x.Worker);
        }
    }
}
