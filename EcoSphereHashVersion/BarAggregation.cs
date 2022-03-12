namespace EcoSphereHashVersion
{
    internal class BarAggregation : BarTechFunctions
    {
        public static void MinMaxDay(HashSet<Bar> barHash, string outputFileName)
        {
            HashSet <Bar> dayHash = new HashSet<Bar>();
            HashSet<Bar> resultHash = new HashSet<Bar>();

            DateOnly prevDate;

            foreach (Bar bar in barHash)
            {
                prevDate = bar.Date;
                break;
            }
            

            foreach (Bar bar in barHash)
            {
                
                if (bar.Date == prevDate)
                {
                    dayHash.Add(bar);
                }
                else
                {
                    resultHash.Add(GetMinLow(dayHash));
                    resultHash.Add(GetMaxHigh(dayHash));
                    dayHash.Clear();
                    dayHash.Add(bar);
                }

                prevDate = bar.Date;
            }

            if (dayHash.Count > 0)
            {
                resultHash.Add(GetMinLow(dayHash));
                resultHash.Add(GetMaxHigh(dayHash));
                dayHash.Clear();
            }

            WriteToFile(outputFileName, resultHash);
        }

        public static void BarByHour(HashSet<Bar> barHash, string outputFileName)
        {
            HashSet<Bar> hourHash = new HashSet<Bar>();
            HashSet<Bar> resultHash = new HashSet<Bar>();
            int prevHour = 0;

            foreach (Bar bar in barHash)
            {
                prevHour = bar.Time.Hour;
                break;
            }

            foreach (Bar bar in barHash)
            {
                if (bar.Time.Hour == prevHour)
                {
                    hourHash.Add(bar);
                }
                else
                {
                    resultHash.Add(new Bar
                    {
                        Symbol = bar.Symbol,
                        Description = bar.Description,
                        Date = bar.Date,
                        Time = new TimeOnly(prevHour, 0),
                        Open = GetOpenPrice(hourHash),
                        High = GetMaxHigh(hourHash).High,
                        Low = GetMinLow(hourHash).Low,
                        Close = GetClosePrice(hourHash),
                        TotalVolume = GetTotalVolume(hourHash)
                    });
                    hourHash.Clear();
                }
                prevHour = bar.Time.Hour;

            }

            if (hourHash.Count > 0)
            {
                resultHash.Add(new Bar
                {
                    Symbol = GetMaxHigh(hourHash).Symbol,
                    Description = GetMaxHigh(hourHash).Description,
                    Date = GetMaxHigh(hourHash).Date,
                    Time = new TimeOnly(prevHour, 0),
                    Open = GetOpenPrice(hourHash),
                    High = GetMaxHigh(hourHash).High,
                    Low = GetMinLow(hourHash).Low,
                    Close = GetClosePrice(hourHash),
                    TotalVolume = GetTotalVolume(hourHash)
                });
                hourHash.Clear();
            }

            WriteToFile(outputFileName, resultHash);
        }
    }
}
