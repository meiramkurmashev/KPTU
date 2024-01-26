using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class Suppliers
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
            KOD,
            KOD_ST,
            KOD_PP,
            TIP,
            KOD_STOR_P,
            KP,
            PUNKT,
            NM,
            NME
                from SUPPLIERS";

        public void Name(ref List<Four> listp)
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
                decimal id1 = (decimal)dtr["KOD"];
                decimal id2 = (decimal)dtr["KP"];
                decimal id3 = (decimal)dtr["PUNKT"];

                string name = (string)dtr["NM"];



                while (!Eof && id1 == (decimal)dtr["KOD"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Four(id1, id2, id3, name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void Change(ref List<TenForSuppliers> listp, decimal id_)
        {
            string sql5 =
                 @"select  a.KOD , a.KOD_ST,  a.KOD_PP,    a.TIP,    a.KOD_STOR_P, a.KP,  a.PUNKT,  a.NM, a.NME, b.KOD, b.NM as STNM FROM SUPPLIERS a , RAILWAY_STATIONS b WHERE b.KOD = a.KOD_ST and " + id_ + " = a.KOD";

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
            decimal id1 = (decimal)dtr["KOD"];
            decimal id2 = (decimal)dtr["KOD_ST"];
            decimal id3 = (decimal)dtr["KOD_PP"];
            decimal id4 = (decimal)dtr["TIP"];
            decimal id5 = (decimal)dtr["KOD_STOR_P"];
            decimal id6 = (decimal)dtr["KP"];
            decimal id7 = (decimal)dtr["PUNKT"];
            string name = (string)dtr["NM"];
            string name2;
            if (dtr["NME"] is DBNull) { name2 = ""; }
            else { name2 = (string)dtr["NME"]; }
            string name3 = (string)dtr["STNM"];

            listp.Add(new TenForSuppliers(id1, id2, id3, id4, id5, id6, id7, name, name2, name3));




            conn.Close();
        }
        public void Railstations(ref List<Two> listAt)
        {
            string sql5 =
       @"select 
            KOD,
            NM
            
                from RAILWAY_STATIONS order by KOD";

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

            bool Eof = !dtr.Read();

            while (!Eof)
            {

                //string[] people = new people;
                decimal id = (decimal)dtr["KOD"];
                string name = (string)dtr["NM"];







                while (!Eof && id == (decimal)dtr["KOD"])
                {

                    //string[] people = array.Append(item);

                    listAt.Add(new Two(id, name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void ChangeSave(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, decimal id7, string name, string name2)


        {
            string sql1 = "UPDATE SUPPLIERS SET KOD_ST = '" + id2 + "', KOD_PP = '" + id3 + "', TIP = '" + id4 + "', KOD_STOR_P = '" + id5 + "',KP = '" + id6 + "',PUNKT = '" + id7 + "',NM = '" + name + "',NME = '" + name2 + "' WHERE KOD = '" + id1 + "'";

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
        public void Delete(decimal id1)
        {
            string sql2 = "DELETE SUPPLIERS WHERE KOD = " + id1 + "";

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

        public void Load(decimal id1, decimal id2, decimal id3, decimal id4, decimal id5, decimal id6, decimal id7, string name, string name2)
        {
            string sql1 = "INSERT INTO SUPPLIERS ( KOD, KOD_ST, KOD_PP, TIP, KOD_STOR_P ,KP ,PUNKT ,NM , NME) VALUES('" + id1 + "','" + id2 + "','" + id3 + "','" + id4 + "','" + id5 + "','" + id6 + "','" + id7 + "','" + name + "','" + name2 + "')";
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