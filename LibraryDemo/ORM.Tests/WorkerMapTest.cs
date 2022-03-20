// <copyright file="WorkerMapTests.cs" company="Лёвин И. Д.">
// Copyright (c) Лёвин И. Д.. All rights reserved.
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
            var worker = new Worker(1, "Лёвин И. Д.", "Продавец");

            // act & assert
            new PersistenceSpecification<Worker>(this.Session)
                .VerifyTheMappings(worker);

        }
    }
}