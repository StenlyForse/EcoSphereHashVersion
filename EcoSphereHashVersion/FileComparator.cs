namespace EcoSphereHashVersion
{
    internal class FileComparator : BarTechFunctions
    {
        public static HashSet<Bar> GetSimilarStringsHash(HashSet<Bar> first, HashSet<Bar> second)
        {
            HashSet<Bar> similarStrings = new HashSet<Bar>(first);
            similarStrings.IntersectWith(second);

            return similarStrings;
        }

        public static void GetNewStringsHash(HashSet<Bar> first, HashSet<Bar> second, string outputFileName)
        {
            HashSet<Bar> newStrings = new HashSet<Bar>(second);
            newStrings.ExceptWith(first);

            WriteToFile(outputFileName, newStrings);
        }

        public static void GetLostStringsHash(HashSet<Bar> first, HashSet<Bar> second, string outputFileName)
        {
            HashSet<Bar> lostStrings = new HashSet<Bar>(first);
            lostStrings.ExceptWith(second);

            WriteToFile(outputFileName, lostStrings);
        }

        public static void GetUniqueStringsHash(HashSet<Bar> first, HashSet<Bar> second, string outputFileName)
        {
            HashSet<Bar> fullHash = new HashSet<Bar>(first);
            fullHash.UnionWith(second);

            WriteToFile(outputFileName, fullHash);
        }
    }
}
