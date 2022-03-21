// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>


namespace ORM.Tests
{
    using Domain;
    using FluentNHibernate.Testing;
    using NUnit.Framework;

    /// <summary>
    /// Модульные тесты для класса <see cref="ORM.Mappings.WorkerMap"/>.
    /// </summary>
    public class WorkerMapTest : BaseMapTests
    {
        [Test]
        public void PersistenceSpecification_ValidData_Success()
        {
            // arrange
            var worker = new Worker(1, "Нурмухаммедов О.Б", "Продавец");

            // act & assert
            new PersistenceSpecification<Worker>(this.Session)
                .VerifyTheMappings(worker);

        }
    }
}