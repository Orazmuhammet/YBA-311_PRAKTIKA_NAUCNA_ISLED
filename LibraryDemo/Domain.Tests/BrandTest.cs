// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
// </copyright>

namespace Domain.Tests
{
    using System;
    using Domain;
    using NUnit.Framework;

    /// <summary>
    /// The model tests.
    /// </summary>
    [TestFixture]
    public class ModelTest
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
            var model = new Model(1, "Samsung galaxy s21", "Rossiya");
            //act
            var result = model.ToString();
            //assert
            Assert.AreEqual($"Samsung galaxy s21 Rossiya", result);
        }

        [Test]
        public void AddPhoneToModel_ValidData_Success()
        {
            // arrange
            var model = GetModel("Samsung galaxy s21", "Rossiya");

            // act
            var result = model.AddPhone(this.phone);

            // assert
            Assert.AreEqual(true, result);
        }

        private static Model GetModel(string name_model, string country)
        {
            return new Model(1,name_model ?? "Samsung galaxy s21", country ?? "Rossiya");
        }
    }
}
