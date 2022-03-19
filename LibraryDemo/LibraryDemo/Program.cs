// <copyright file="Program.cs" company="Васильева М.А.">
// Copyright (c) Васильева М.А.. All rights reserved.
// </copyright>

namespace LibraryDemo
{
    using System;
    using Domain;
    using ORM;

    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        private static void Main()
        {
            var brand = new Brand(1, "lada vesta", "Россия");

            var car = new Car(1, 1999, "синий", 600000, brand);

            var worker = new Worker(1, "Лёвин И. Д.", "Продавец");

            var carsale = new Carsale(1, DateTime.Now, 650000, car, worker);

            Console.WriteLine($"{car} --> {brand}");

            Console.WriteLine($"{carsale} --> {car}");

            Console.WriteLine($"{carsale} --> {worker}");

            using var sessionFactory = NHibernateConfigurator.GetSessionFactory(showSql: true);
            using var session = sessionFactory.OpenSession();
            session.Save(brand);
            session.Save(car);
            session.Save(carsale);
            session.Save(worker);
            session.Flush();
        }
    }
}
