// <copyright file="BrandTest.cs" company="Лёвин И. Д">
// Copyright (c) Лёвин И. Д. All rights reserved.
// </copyright>

namespace Domain.Tests
{
    using System;
    using Domain;
    using NUnit.Framework;

    /// <summary>
    /// The brand tests.
    /// </summary>
    [TestFixture]
    public class BrandTest
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            this.car = new Car(1, 1999, "синий", 600000);
        }

        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var brand = new Brand(1, "lada vesta", "Россия");
            //act
            var result = brand.ToString();
            //assert
            Assert.AreEqual($"lada vesta Россия", result);
        }

        [Test]
        public void AddCarToBrand_ValidData_Success()
        {
            // arrange
            var brand = GetBrand("lada vesta", "Россия");

            // act
            var result = brand.AddCar(this.car);

            // assert
            Assert.AreEqual(true, result);
        }

        private static Brand GetBrand(string name_brand, string country)
        {
            return new Brand(1,name_brand ?? "lada vesta", country ?? "Россия");
        }
    }
}
