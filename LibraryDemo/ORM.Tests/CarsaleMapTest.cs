// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>


namespace ORM.Tests
{
    using Domain;
    using FluentNHibernate.Testing;
    using NUnit.Framework;
    using System;

    /// <summary>
    /// Модульные тесты для класса <see cref="ORM.Mappings.CarsaleMap"/>.
    /// </summary>
    [TestFixture]
    public class CarsaleMapTest : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidSimpleData_Success()
        {
            // arrange
            var carsale = new Carsale(1, DateTime.Now, 60000);

            // act & assert
            new PersistenceSpecification<Carsale>(this.Session)
                .VerifyTheMappings(carsale);
        }

        [Test]
        public void PersistenceSpecification_ValidComplexData_Success()
        {

            // arrange
            var phone = new Phone(1, 2021, "синий", 60000);

            var worker = new Worker(1, "Нурмухаммедов О.Б", "Продавец");

            var carsale = new Carsale(1, DateTime.Now, 60000, phone, worker);

            // act & assert
            new PersistenceSpecification<Carsale>(this.Session)
                .VerifyTheMappings(carsale);
        }
    }
}
