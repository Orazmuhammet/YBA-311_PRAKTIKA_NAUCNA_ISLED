// <copyright file="BrandMapTest.cs" company="Лёвин И. Д.">
// Copyright (c) Лёвин И. Д.. All rights reserved.
// </copyright>

namespace ORM.Tests
{
    using Domain;
    using FluentNHibernate.Testing;
    using NUnit.Framework;

    /// <summary>
    /// Модульные тесты для класса <see cref="ORM.Mappings.CarsaleMap"/>.
    /// </summary>
    public class BrandMapTest : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var brand = new Brand(1, "lada vesta", "Россия");

            // act & assert
            new PersistenceSpecification<Brand>(this.Session)
                .VerifyTheMappings(brand);

        }
    }
}
