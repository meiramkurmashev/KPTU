namespace KPTU.Models
{
    public class TenForSuppliers
    {
        public decimal Id1 { get; }
        public decimal Id2 { get; }
        public decimal Id3 { get; }
        public decimal Id4 { get; }
        public decimal Id5 { get; }
        public decimal Id6 { get; }
        public decimal Id7 { get; }
        public string Name { get; }
        public string Name2 { get; }
        public string Name3 { get; }


        public TenForSuppliers(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, decimal id7, string name, string name2, string name3)
        {
            Id1 = id1;
            Id2 = id2;
            Id3 = id3;
            Id4 = id4;
            Id5 = id5;
            Id6 = id6;
            Id7 = id7;
            Name = name;
            Name2 = name2;
            Name3 = name3;


        }
    }
}