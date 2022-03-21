// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>


namespace ORM.Mappings
{
    using Domain;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Model"/> на таблицу и наоборот.
    /// </summary>
    internal class ModelMap : ClassMap<Model>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="BrandMap"/>.
        /// </summary>
        public ModelMap()
        {
            // this.Schema("dbo");

            this.Table("Models");

            this.Id(x => x.Id_model).Not.Nullable();

            this.Map(x => x.Name_model).Not.Nullable();
            this.Map(x => x.Country).Not.Nullable();

            this.HasMany(x => x.Phons);
        }
    }
}
