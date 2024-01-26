namespace KPTU.Models
{
    public class TenForRailwayStations
    {

        public decimal Id1 { get; }


        public string Name1 { get; }

        public string Name2 { get; }

        public string Name3 { get; }

        public decimal Id2 { get; }

        public decimal Id3 { get; }

        public decimal Id4 { get; }

        public string Name4 { get; }

        public decimal Id5 { get; }

        public string Name5 { get; }
        public TenForRailwayStations(decimal id1, string name1, string name2, string name3, decimal id2, decimal id3, decimal id4, string name4, decimal id5, string name5)
        {
            Id1 = id1;
            Id2 = id2;
            Id3 = id3;
            Id4 = id4;
            Id5 = id5;

            Name1 = name1;
            Name2 = name2;
            Name3 = name3;
            Name4 = name4;
            Name5 = name5;

        }
    }
}