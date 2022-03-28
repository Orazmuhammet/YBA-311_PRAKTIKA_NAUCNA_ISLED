// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>


namespace ORM.Mappings
{
    using Domain;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Phone"/> на таблицу и наоборот.
    /// </summary>
    internal class PhoneMap : ClassMap<Phone>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PhoneMap"/>.
        /// </summary>
        public PhoneMap()
        {
            // this.Schema("dbo");

            this.Table("Phone");

            this.Id(x => x.Id_phone).Not.Nullable();

            this.Map(x => x.Year).Not.Nullable();
            this.Map(x => x.Color).Not.Nullable();
            this.Map(x => x.Price).Not.Nullable();

            this.HasMany(x => x.PhoneSales);
            this.References(x => x.Model);
        }
    }
}
