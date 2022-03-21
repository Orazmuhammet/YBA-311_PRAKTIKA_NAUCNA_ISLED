// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
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
            var carsale = new Carsale(1, DateTime.Now, 60000);
            //act
            var result = carsale.ToString();
            //assert
            Assert.AreEqual($"{DateTime.Now} 60000", result);
        }
    }
}