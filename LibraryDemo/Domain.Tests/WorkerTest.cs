// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
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
        private PhoneSale phoneSale;

        [SetUp]
        public void Setup()
        {
            this.phoneSale = new PhoneSale(1, DateTime.Now, 60000);
        }

        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var worker = new Worker(1, "Нурмухаммедов О.Б", "Продавец");
            //act
            var result = worker.ToString();
            //assert
            Assert.AreEqual($"Нурмухаммедов О.Б Продавец", result);
        }

        [Test]
        public void AddCarsaleToWorker_ValidData_Success()
        {
            // arrange
            var worker = GetWorker("Нурмухаммедов О.Б", "Продавец");

            // act
            var result = worker.AddPhoneSale(this.phoneSale);

            // assert
            Assert.AreEqual(true, result);
        }

        private static Worker GetWorker(string fio, string working)
        {
            return new Worker(1, fio ?? "Нурмухаммедов О.Б", working ?? "Продавец");
        }
    }
}
