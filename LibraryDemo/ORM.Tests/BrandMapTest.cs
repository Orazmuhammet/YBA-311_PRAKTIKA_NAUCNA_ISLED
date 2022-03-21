// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
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
            var brand = new Brand(1, "Samsung galaxy s21", "Rossiya");

            // act & assert
            new PersistenceSpecification<Brand>(this.Session)
                .VerifyTheMappings(brand);

        }
    }
}
