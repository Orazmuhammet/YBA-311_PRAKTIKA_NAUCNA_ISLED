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
    /// Модульные тесты для класса <see cref="ORM.Mappings.CarMap"/>.
    /// </summary>
    public class CarMapTest : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var phone = new Phone(1,2021, "синий", 60000);

            // act & assert
            new PersistenceSpecification<Phone>(this.Session)
                .VerifyTheMappings(phone);
        }
        [Test]
        public void PersistenceSpecification_ValidComplexData_Success()
        {
            // arrange

            var brand = new Brand(1, "Samsung galaxy s21", "Rossiya");

            var phone = new Phone(1, 2021, "синий", 60000, brand);

            // act & assert
            new PersistenceSpecification<Phone>(this.Session)
                .VerifyTheMappings(phone);
        }
    }
}
