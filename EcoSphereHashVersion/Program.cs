using EcoSphereHashVersion;

HashSet<Bar> hash1 = Bar.ReadCsvHash("AAPL-IQFeed-SMART-Stocks-Minute-Trade.txt");
HashSet<Bar> hash2 = Bar.ReadCsvHash("AAPL-IQFeed-SMART-Stocks-Minute-Trade-corrupted.txt");


BarAggregation.MinMaxDay(hash1, "MinMaxDay.txt");
BarAggregation.BarByHour(hash1, "BarByHour.txt");

FileComparator.GetNewStringsHash(hash1, hash2, "NewStrings.txt");
FileComparator.GetLostStringsHash(hash1, hash2, "LostStrings.txt");
FileComparator.GetUniqueStringsHash(hash1, hash2, "UniqueStrings.txt");

Console.WriteLine("Done! All files you can find in the project folder");