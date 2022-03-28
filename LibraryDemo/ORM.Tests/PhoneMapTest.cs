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
    /// Модульные тесты для класса <see cref="ORM.Mappings.PhoneMap"/>.
    /// </summary>
    public class PhoneMapTest : BaseMapTests
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

            var model = new Model(1, "Samsung galaxy s21", "Rossiya");

            var phone = new Phone(1, 2021, "синий", 60000, model);

            // act & assert
            new PersistenceSpecification<Phone>(this.Session)
                .VerifyTheMappings(phone);
        }
    }
}
