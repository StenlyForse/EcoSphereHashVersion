using NUnit.Framework;

namespace EcoSphereHashVersion.Tests
{
    [TestFixture]
    internal class FileComparator : EcoSphereHashVersion.FileComparator
    {
        [Test]
        public void GetSimularStrings_FilesInputed_ListExpected()
        {
            // Assume
            var hash1 = Bar.ReadCsvHash("test3.1.txt");
            var hash2 = Bar.ReadCsvHash("test3.2.txt");
            var expected = Bar.ReadCsvHash("test3-correct.txt");

            // Act
            var actual = GetSimilarStringsHash(hash1, hash2);

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetNewStrings_FileInputed_FileExpected()
        {
            var hash1 = Bar.ReadCsvHash("test3.1.txt");
            var hash2 = Bar.ReadCsvHash("test3.2.txt");
            var expected = Bar.ReadCsvHash("test4-correct.txt");

            // Act
            GetNewStringsHash(hash1, hash2, "test4-test.txt");
            var actual = Bar.ReadCsvHash("test4-test.txt");

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetLostStrings_FileInputed_FileExpected()
        {
            var hash1 = Bar.ReadCsvHash("test3.1.txt");
            var hash2 = Bar.ReadCsvHash("test3.2.txt");
            var expected = Bar.ReadCsvHash("test5-correct.txt");

            // Act
            GetLostStringsHash(hash1, hash2, "test5-test.txt");
            var actual = Bar.ReadCsvHash("test5-test.txt");

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void GetUniqueStrings_FileInputed_FileExpected()
        {
            var hash1 = Bar.ReadCsvHash("test3.1.txt");
            var hash2 = Bar.ReadCsvHash("test3.2.txt");
            var expected = Bar.ReadCsvHash("test6-correct.txt");

            // Act
            GetUniqueStringsHash(hash1, hash2, "test6-test.txt");
            var actual = Bar.ReadCsvHash("test6-test.txt");

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

    }
}
