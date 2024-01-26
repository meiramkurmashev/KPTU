using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class Consumers
    {
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
        static OracleConnection conn = new OracleConnection("Data Source = *****;Persist Security Info = True;User ID = *****;Password = *****;Unicode = True");
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
        static OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
        const String sql =
        @"select 
            KOD_MIN,
            KOD_REP,
            KOD_POT,
            NM,
            NME,
            KOD_ST,
            KOD_GR,
            KOD_POTR4,
            ADRES
                from CONSUMERS";

        public void Name(ref List<FiveForConsumers> listp)
        {

#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            bool Eof = !dtr.Read();

            while (!Eof)
            {

                //string[] people = new people;
                decimal id1 = (decimal)dtr["KOD_MIN"];
                decimal id2 = (decimal)dtr["KOD_REP"];
                decimal id3 = (decimal)dtr["KOD_POT"];
                string nm = (string)dtr["NM"];
                decimal id4 = (decimal)dtr["KOD_POTR4"];



                while (!Eof && id3 == (decimal)dtr["KOD_POT"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new FiveForConsumers(id1, id2, id3, nm, id4));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void Change(ref List<ElevenForConsumers> listp, decimal id_)
        {
            string sql5 =
        @"select 
            a.KOD_MIN,
            a.KOD_REP,
            a.KOD_POT,
            a.NM,
            a.NME,
            a.KOD_ST,
            a.KOD_GR,
            a.KOD_POTR4,
            a.ADRES, 
            b.KOD,
            b.NM as NM_ST,
            c.ID,
            c.NAME as NM_GR

                from CONSUMERS a, RAILWAY_STATIONS b, CONSUMER_GROUPS c WHERE     b.KOD = a.KOD_ST   and c.ID=a.KOD_GR and " + id_ + "= a.KOD_POT ";
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql5;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            dtr.Read();



            //string[] people = new people;
            decimal id1 = (decimal)dtr["KOD_MIN"];

            decimal id2 = (decimal)dtr["KOD_REP"];
            decimal id3 = (decimal)dtr["KOD_POT"];
            decimal id4 = (decimal)dtr["KOD_ST"];
            decimal id5 = (decimal)dtr["KOD_GR"];
            decimal id6 = (decimal)dtr["KOD_POTR4"];
            string adres;
            if (dtr["ADRES"] is DBNull) { adres = ""; }
            else { adres = (string)dtr["ADRES"]; }
            string nm = (string)dtr["NM"];
            string nme;
            if (dtr["NME"] is DBNull) { nme = ""; }
            else { nme = (string)dtr["NME"]; }
            string nm_st = (string)dtr["NM_ST"];
            string nm_gr = (string)dtr["NM_GR"];
            listp.Add(new ElevenForConsumers(id1, id2, id3, id4, id5, id6, adres, nm, nme, nm_st, nm_gr));




            conn.Close();
        }
        public void ChangeSave(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, string adres, string nm, string nme)


        {
            string sql1 = "UPDATE CONSUMERS SET   KOD_REP = '" + id2 + "', KOD_MIN= '" + id1 + "', KOD_ST= '" + id4 + "',KOD_GR= '" + id5 + "',KOD_POTR4= '" + id6 + "',ADRES= '" + adres + "', NM= '" + nm + "', NME  = '" + nme + "' WHERE KOD_POT = " + id3 + "";

#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql1;


            conn.Open();
            cmd.ExecuteReader();

            conn.Close();
        }
        public void Delete(decimal id)
        {
            string sql2 = "DELETE CONSUMERS WHERE KOD_POT = " + id + "";

#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql2;


            conn.Open();
            cmd.ExecuteReader();

            conn.Close();
        }

        public void Load(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, string adres, string nm, string nme)
        {
            string sql1 = "INSERT INTO CONSUMERS ( KOD_MIN, KOD_REP, KOD_POT,KOD_ST, KOD_GR, KOD_POTR4, ADRES,  NM,  NME) VALUES('" + id1 + "','" + id2 + "','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + adres + "','" + nm + "','" + nme + "')";
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql1;


            conn.Open();
            cmd.ExecuteReader();

            conn.Close();
        }
    }
}