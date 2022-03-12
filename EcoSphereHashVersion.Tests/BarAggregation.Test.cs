using NUnit.Framework;

namespace EcoSphereHashVersion.Tests
{
    [TestFixture]
    internal class BarAggregation : EcoSphereHashVersion.BarAggregation
    {
        [Test]
        public void MinMaxDay_FileInputed_test1_correctExpected()
        {
            // Assume
            var hash = Bar.ReadCsvHash("test1.txt");
            var expected = Bar.ReadCsvHash("test1-correct.txt");

            // Act
            MinMaxDay(hash, "test1-test.txt");
            var actual = Bar.ReadCsvHash("test1-test.txt");

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BarByHour_ListInserted_FileExpected()
        {
            // Assume
            var list = Bar.ReadCsvHash("test2.txt");
            var expected = Bar.ReadCsvHash("test2-correct.txt");

            // Act
            BarByHour(list, "test2-test.txt");
            var actual = Bar.ReadCsvHash("test2-test.txt");

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
