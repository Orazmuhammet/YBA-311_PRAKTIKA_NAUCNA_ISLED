// <copyright file="CarsaleTest.cs" company="Лёвин И. Д">
// Copyright (c) Лёвин И. Д. All rights reserved.
// </copyright>

namespace Domain.Tests
{
    using System;
    using Domain;
    using NUnit.Framework;

    /// <summary>
    /// The carsale tests.
    /// </summary>
    [TestFixture]
    public class CarsaleTest
    { 

        [Test]
        public void ToString_ValidData_Success()
        {
            //arrange
            var carsale = new Carsale(1, DateTime.Now, 650000);
            //act
            var result = carsale.ToString();
            //assert
            Assert.AreEqual($"{DateTime.Now} 650000", result);
        }
    }
}