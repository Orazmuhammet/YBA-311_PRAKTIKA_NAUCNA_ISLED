// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>

namespace Domain.Tests
{
    using System;
    using Domain;
    using NUnit.Framework;

    /// <summary>
    /// The car tests.
    /// </summary>
    [TestFixture]
    public class PhoneTest
    {
        private Carsale carsale;

        [SetUp]
        public void Setup()
        {
            this.carsale = new Carsale(1, DateTime.Now, 60000);
        }

        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var phone = new Phone(1, 2021, "синий", 60000);
            //act
            var result = phone.ToString();
            //assert
            Assert.AreEqual($"2021 синий 60000", result);
        }

        [Test]
        public void AddCarsaleToPhone_ValidData_Success()
        {
            // arrange
            var phone = GetPhone(2021, "синий", 60000);

            // act
            var result = phone.AddCarsale(this.carsale);

            // assert
            Assert.AreEqual(true, result);
        }

        private static Phone GetPhone(int year, string color, double price)
        {
            return new Phone(1, year, color ?? "синий", price);
        }
    }
}
