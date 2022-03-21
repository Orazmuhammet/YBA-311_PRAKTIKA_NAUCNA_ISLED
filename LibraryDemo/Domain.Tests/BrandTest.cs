// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
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
        private Phone phone;

        [SetUp]
        public void Setup()
        {
            this.phone = new Phone(1, 2021, "синий", 60000);
        }

        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var brand = new Brand(1, "Samsung galaxy s21", "Rossiya");
            //act
            var result = brand.ToString();
            //assert
            Assert.AreEqual($"Samsung galaxy s21 Rossiya", result);
        }

        [Test]
        public void AddPhoneToBrand_ValidData_Success()
        {
            // arrange
            var brand = GetBrand("Samsung galaxy s21", "Rossiya");

            // act
            var result = brand.AddPhone(this.phone);

            // assert
            Assert.AreEqual(true, result);
        }

        private static Brand GetBrand(string name_brand, string country)
        {
            return new Brand(1,name_brand ?? "Samsung galaxy s21", country ?? "Rossiya");
        }
    }
}
