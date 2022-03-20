// <copyright file="CarMapTests.cs" company="Лёвин И. Д.">
// Copyright (c) Лёвин И. Д.. All rights reserved.
// </copyright>

namespace ORM.Tests
{
    using Domain;
    using FluentNHibernate.Testing;
    using NUnit.Framework;
    using System;

    /// <summary>
    /// Модульные тесты для класса <see cref="ORM.Mappings.CarMap"/>.
    /// </summary>
    public class CarMapTest : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var car = new Car(1,1999, "синий", 600000);

            // act & assert
            new PersistenceSpecification<Car>(this.Session)
                .VerifyTheMappings(car);
        }
        [Test]
        public void PersistenceSpecification_ValidComplexData_Success()
        {
            // arrange

            var brand = new Brand(1, "lada vesta", "Россия");

            var car = new Car(1, 1999, "синий", 600000, brand);

            // act & assert
            new PersistenceSpecification<Car>(this.Session)
                .VerifyTheMappings(car);
        }
    }
}
