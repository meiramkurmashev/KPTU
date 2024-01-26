using System;

namespace KPTU.Models
{
    public class Loading
    {
        public string Id { get; }
        public string Date1 { get; }
        public string Type { get; }
        public string Vert { get; }

        public string Codest { get; }
        public string Coderote { get; }
        public string Potreb { get; }
        public string Codepotreb { get; }
        public string Timepr { get; }
        public string Timedel { get; }
        public string Timeclose { get; }
        public string TypeName { get; }
        public string VertName { get; }

        public string CodestName { get; }
        public string CoderoteName { get; }
        public string PotrebName { get; }

        public Loading(string id, string date1, string type, string vert, string codest, string coderote, string potreb, string codepotreb, DateTime timepr, DateTime timedel, DateTime timeclose, string type_name, string vert_name, string codest_name, string coderote_name, string potreb_name)
        {
            Id = id;
            Type = type;

            //Date1 = date1.ToString("MM-dd-yyyy");
            Date1 = date1;// ToString("dd/MM/yyyy H:G").Substring(0, date1.ToString().Length - 7);
            Vert = vert;
            Codest = codest;


            Coderote = coderote;
            Potreb = potreb;
            Codepotreb = codepotreb;
            Timepr = timepr.ToString().Substring(11);
            Timedel = timedel.ToString().Substring(11);
            Timeclose = timeclose.ToString().Substring(11);
            TypeName = type_name;
            VertName = vert_name;
            CodestName = codest_name;
            CoderoteName = coderote_name;

            PotrebName = potreb_name;


        }

    }
}