// <copyright file="Book.cs" company="Nurmuhammedow.O">
// Copyright (c) Nurmuhammedow.O.. All rights reserved.
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
            var model = new Model(1, "Samsung galaxy s21", "Rossiya");

            var phone = new Phone(1, 2021, "синий", 60000, model);

            var worker = new Worker(1, "Нурмухаммедов О.Б", "Продавец");

            var phoneSale = new PhoneSale(1, DateTime.Now, 60000, phone, worker);

            Console.WriteLine($"{phone} --> {model}");

            Console.WriteLine($"{phoneSale} --> {phone}");

            Console.WriteLine($"{phoneSale} --> {worker}");

            using var sessionFactory = NHibernateConfigurator.GetSessionFactory(showSql: true);
            using var session = sessionFactory.OpenSession();
            session.Save(model);
            session.Save(phone);
            session.Save(phoneSale);
            session.Save(worker);
            session.Flush();
        }
    }
}
