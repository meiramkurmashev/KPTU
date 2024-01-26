namespace KPTU.Models
{
    public class FiveForConsumers
    {
        public decimal Id1 { get; }
        public decimal Id2 { get; }
        public decimal Id3 { get; }

        public string Name { get; }

        public decimal Id4 { get; }

        public FiveForConsumers(decimal id1, decimal id2, decimal id3, string name, decimal id4)
        {
            Id1 = id1;
            Id2 = id2;
            Id3 = id3;
            Name = name;
            Id4 = id4;
        }
    }
}