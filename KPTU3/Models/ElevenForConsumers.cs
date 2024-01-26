namespace KPTU.Models
{
    public class ElevenForConsumers
    {
        public decimal Id1 { get; }
        public decimal Id2 { get; }
        public decimal Id3 { get; }

        public decimal Id4 { get; }
        public decimal Id5 { get; }
        public decimal Id6 { get; }
        public string Adres { get; }
        public string Nm { get; }
        public string Nme { get; }
        public string Nm_st { get; }
        public string Nm_gr { get; }

        public ElevenForConsumers(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, string adres, string nm, string nme, string nm_st, string nm_gr)
        {
            Id1 = id1;
            Id2 = id2;
            Id3 = id3;
            Id4 = id4;
            Id5 = id5;
            Id6 = id6;
            Adres = adres;
            Nm = nm;
            Nme = nme;
            Nm_st = nm_st;
            Nm_gr = nm_gr;

        }
    }
}