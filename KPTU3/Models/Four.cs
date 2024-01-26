namespace KPTU.Models
{
    public class Four
    {
        public decimal Id1 { get; }
        public decimal Id2 { get; }
        public decimal Id3 { get; }

        public string Name { get; }


        public Four(decimal id1, decimal id2, decimal id3, string name)
        {
            Id1 = id1;
            Id2 = id2;
            Id3 = id3;
            Name = name;



        }
    }
}