using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("EcoSphereHashVersion.Tests")]

namespace EcoSphereHashVersion
{
    internal class BarTechFunctions
    {
        protected static Bar GetMaxHigh(HashSet<Bar> hash)
        {
            Bar high = new Bar();
            double maxElem = 0;

            foreach (Bar bar in hash)
            {
                if (bar.High > maxElem)
                {
                    high = bar;
                    maxElem = bar.High;
                }
            }

            return high;
        }

        protected static Bar GetMinLow(HashSet<Bar> hash)
        {
            Bar low = new Bar();
            double minElem = double.MaxValue;

            foreach (Bar bar in hash)
            {
                if (bar.Low < minElem)
                {
                    low = bar;
                    minElem = bar.Low;
                }
            }

            return low;
        }

        protected static double GetOpenPrice(HashSet<Bar> hash)
        {
            double open = 0;

            foreach (Bar bar in hash)
            {
                open = bar.Open;
                break;
            }
            return open;
        }

        protected static double GetClosePrice(HashSet<Bar> hash)
        {
            double close = 0;
            foreach (Bar bar in hash)
            {
                close = bar.Close;
            }
            return close;
        }

        protected static int GetTotalVolume(HashSet<Bar> hash)
        {
            int total = 0;

            foreach (var bar in hash)
                total += bar.TotalVolume;
            return total;
        }

        protected static void WriteToFile(string fileName, HashSet<Bar> hash)
        {
            string writePath = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.FullName + "\\" + fileName;
            using (StreamWriter sw = new StreamWriter(writePath))
            {
                sw.WriteLine("\"Symbol\"" + "," + "\"Description\""
                    + "," + "\"Date\"" + "," + "\"Time\""
                    + "," + "\"Open\"" + "," + "\"High\""
                    + "," + "\"Low\"" + "," + "\"Close\""
                    + "," + "\"TotalVolume\"");
                foreach (var line in hash)
                {
                    sw.WriteLine($"{line.Symbol},{line.Description},{line.Date},{line.Time:HH:mm:ss},{line.Open:F3},{line.High:F3},{line.Low:F3},{line.Close:F3},{line.TotalVolume}");
                }
            }
        }
    }
}
