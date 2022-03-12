using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EcoSphereHashVersion.Tests
{
    [TestFixture]
    internal class BarTechFunctions : EcoSphereHashVersion.BarTechFunctions
    {
        [Test]
        public void GetMaxHigh_ListInputed_300Returned()
        {
            // Assume
            HashSet<Bar> hash = new HashSet<Bar>();
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:01:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("296.190", CultureInfo.InvariantCulture),
                Low = double.Parse("295.435", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2517")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:02:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("300.000", CultureInfo.InvariantCulture),
                Low = double.Parse("290.000", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2500")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:03:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("294.890", CultureInfo.InvariantCulture),
                High = double.Parse("294.530", CultureInfo.InvariantCulture),
                Low = double.Parse("297.030", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2650")
            });

            double expected = 300.000;

            // Act
            var actual = GetMaxHigh(hash).High;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void GetMinLow_ListInputed_290Expected()
        {
            // Assume
            HashSet<Bar> hash = new HashSet<Bar>();
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:01:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("296.190", CultureInfo.InvariantCulture),
                Low = double.Parse("295.435", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2517")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:02:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("300.000", CultureInfo.InvariantCulture),
                Low = double.Parse("290.000", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2500")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:03:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("294.890", CultureInfo.InvariantCulture),
                High = double.Parse("294.530", CultureInfo.InvariantCulture),
                Low = double.Parse("297.030", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2650")
            });

            double expected = 290.000;

            // Act
            var actual = GetMinLow(hash).Low;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetOpenPrice_ListInputed_295Expected()
        {
            // Assume
            HashSet<Bar> hash = new HashSet<Bar>();
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:01:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("296.190", CultureInfo.InvariantCulture),
                Low = double.Parse("295.435", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2517")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:02:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("300.000", CultureInfo.InvariantCulture),
                Low = double.Parse("290.000", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2500")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:03:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("294.890", CultureInfo.InvariantCulture),
                High = double.Parse("294.530", CultureInfo.InvariantCulture),
                Low = double.Parse("297.030", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2650")
            });

            double expected = 295.890;

            // Act
            var actual = GetOpenPrice(hash);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetClosePrice_ListInputed_296Expected()
        {
            // Assume
            HashSet<Bar> hash = new HashSet<Bar>();
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:01:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("296.190", CultureInfo.InvariantCulture),
                Low = double.Parse("295.435", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2517")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:02:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("300.000", CultureInfo.InvariantCulture),
                Low = double.Parse("290.000", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2500")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:03:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("294.890", CultureInfo.InvariantCulture),
                High = double.Parse("294.530", CultureInfo.InvariantCulture),
                Low = double.Parse("297.030", CultureInfo.InvariantCulture),
                Close = double.Parse("296.099", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2650")
            });

            double expected = 296.099;

            // Act
            var actual = GetClosePrice(hash);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetTotalVolume_ListInserted_7667Expected()
        {
            // Assume
            HashSet<Bar> hash = new HashSet<Bar>();
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:01:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("296.190", CultureInfo.InvariantCulture),
                Low = double.Parse("295.435", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2517")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:02:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("295.890", CultureInfo.InvariantCulture),
                High = double.Parse("300.000", CultureInfo.InvariantCulture),
                Low = double.Parse("290.000", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2500")
            });
            hash.Add(new Bar
            {
                Symbol = "AAPL",
                Description = "NASDAQ",
                Date = DateOnly.ParseExact("02.01.2020", "dd.MM.yyyy", CultureInfo.InvariantCulture),
                Time = TimeOnly.ParseExact("08:03:00", "HH:mm:ss", CultureInfo.InvariantCulture),
                Open = double.Parse("294.890", CultureInfo.InvariantCulture),
                High = double.Parse("294.530", CultureInfo.InvariantCulture),
                Low = double.Parse("297.030", CultureInfo.InvariantCulture),
                Close = double.Parse("296.098", CultureInfo.InvariantCulture),
                TotalVolume = Convert.ToInt32("2650")
            });

            int expected = 7667;

            // Act
            var actual = GetTotalVolume(hash);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
