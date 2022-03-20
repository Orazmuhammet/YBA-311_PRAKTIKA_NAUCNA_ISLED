// <copyright file="BrandMap.cs" company="Лёвин И. Д.">
// Copyright (c) Лёвин И. Д.. All rights reserved.
// </copyright>

namespace ORM.Mappings
{
    using Domain;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Brand"/> на таблицу и наоборот.
    /// </summary>
    internal class BrandMap : ClassMap<Brand>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BrandMap"/>.
        /// </summary>
        public BrandMap()
        {
            // this.Schema("dbo");

            this.Table("Brands");

            this.Id(x => x.Id_brand).Not.Nullable();

            this.Map(x => x.Name_brand).Not.Nullable();
            this.Map(x => x.Country).Not.Nullable();

            this.HasMany(x => x.Cars);
        }
    }
}
