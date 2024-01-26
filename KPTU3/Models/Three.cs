namespace KPTU.Models
{
    public class Three
    {


        public decimal Id { get; }
        public string Name { get; }

        public string About { get; }



        public Three(decimal id, string name, string about)
        {
            Id = id;
            Name = name;
            About = about;



        }
    }
}