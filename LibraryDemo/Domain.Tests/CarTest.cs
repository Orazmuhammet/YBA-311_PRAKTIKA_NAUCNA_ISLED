// <copyright file="CarTest.cs" company="Лёвин И. Д">
// Copyright (c) Лёвин И. Д. All rights reserved.
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
    public class CarTest
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
            var car = new Car(1, 1999, "синий", 600000);
            //act
            var result = car.ToString();
            //assert
            Assert.AreEqual($"1999 синий 600000", result);
        }

        [Test]
        public void AddCarsaleToCar_ValidData_Success()
        {
            // arrange
            var car = GetCar(1999, "синий", 600000);

            // act
            var result = car.AddCarsale(this.carsale);

            // assert
            Assert.AreEqual(true, result);
        }

        private static Car GetCar(int year, string color, double price)
        {
            return new Car(1, year, color ?? "синий", price);
        }
    }
}
