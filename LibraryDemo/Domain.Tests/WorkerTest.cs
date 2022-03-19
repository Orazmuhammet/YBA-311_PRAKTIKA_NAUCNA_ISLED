// <copyright file="WorkerTest.cs" company="Лёвин И. Д">
// Copyright (c) Лёвин И. Д. All rights reserved.
// </copyright>

namespace Domain.Tests
{
    using System;
    using Domain;
    using NUnit.Framework;

    /// <summary>
    /// The worker tests.
    /// </summary>
    [TestFixture]
    public class WorkerTest
    {
        private Carsale carsale;

        [SetUp]
        public void Setup()
        {
            this.carsale = new Carsale(1, DateTime.Now, 650000);
        }

        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var worker = new Worker(1, "Лёвин И. Д.", "Продавец");
            //act
            var result = worker.ToString();
            //assert
            Assert.AreEqual($"Лёвин И. Д. Продавец", result);
        }

        [Test]
        public void AddCarsaleToWorker_ValidData_Success()
        {
            // arrange
            var worker = GetWorker("Лёвин И. Д.", "Продавец");

            // act
            var result = worker.AddCarsale(this.carsale);

            // assert
            Assert.AreEqual(true, result);
        }

        private static Worker GetWorker(string fio, string working)
        {
            return new Worker(1, fio ?? "Лёвин И.Д.", working ?? "Продавец");
        }
    }
}
