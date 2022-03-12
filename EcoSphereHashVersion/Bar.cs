using System.Globalization;

namespace EcoSphereHashVersion
{
    internal class Bar
    {
        internal string? Symbol { get; set; }
        internal string? Description { get; set; }
        internal DateOnly Date { get; set; }
        internal TimeOnly Time { get; set; }
        internal double Open { get; set; }
        internal double High { get; set; }
        internal double Low { get; set; }
        internal double Close { get; set; }
        internal int TotalVolume { get; set; }

        public static HashSet<Bar> ReadCsvHash(string inputFileName)
        {
            HashSet<Bar> hashBar = new HashSet<Bar>();
            string path = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.FullName + "\\" + inputFileName;
            string[] text = File.ReadAllLines(path);

            CultureInfo newCInfo = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            newCInfo.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = newCInfo;

            for (int i = 1; i < text.Length; i++)
            {
                var delimetedLine = text[i].Split(',');
                hashBar.Add(new Bar
                {
                    Symbol = delimetedLine[0],
                    Description = delimetedLine[1],
                    Date = DateOnly.ParseExact(delimetedLine[2], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    Time = TimeOnly.ParseExact(delimetedLine[3], "HH:mm:ss", CultureInfo.InvariantCulture),
                    Open = double.Parse(delimetedLine[4], CultureInfo.InvariantCulture),
                    High = double.Parse(delimetedLine[5], CultureInfo.InvariantCulture),
                    Low = double.Parse(delimetedLine[6], CultureInfo.InvariantCulture),
                    Close = double.Parse(delimetedLine[7], CultureInfo.InvariantCulture),
                    TotalVolume = Convert.ToInt32(delimetedLine[8])
                });
            }

            return hashBar;

        }

        public override bool Equals(object? obj)
        {
            return obj is Bar bar &&
                   Symbol == bar.Symbol &&
                   Description == bar.Description &&
                   Date.Equals(bar.Date) &&
                   Time.Equals(bar.Time) &&
                   Open == bar.Open &&
                   High == bar.High &&
                   Low == bar.Low &&
                   Close == bar.Close &&
                   TotalVolume == bar.TotalVolume;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Open, High, Date, Time, Low, Close);
        }
    }
}
