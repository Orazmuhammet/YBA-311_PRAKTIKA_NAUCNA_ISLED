// <copyright file="CarsaleMapTest.cs" company="Лёвин И. Д.">
// Copyright (c) Лёвин И. Д.. All rights reserved.
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
            var carsale = new Carsale(1, DateTime.Now, 650000);

            // act & assert
            new PersistenceSpecification<Carsale>(this.Session)
                .VerifyTheMappings(carsale);
        }

        [Test]
        public void PersistenceSpecification_ValidComplexData_Success()
        {

            // arrange
            var car = new Car(1, 1999, "синий", 600000);

            var worker = new Worker(1, "Незнайкин О. П.", "Продавец");

            var carsale = new Carsale(1, DateTime.Now, 650000, car, worker);

            // act & assert
            new PersistenceSpecification<Carsale>(this.Session)
                .VerifyTheMappings(carsale);
        }
    }
}
