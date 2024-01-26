using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class RailwayStations
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
            a.KOD,
            a.NM,
            a.NME,
            a.NM_R,
            a.KOD_DOR,
            a.PAR,
            a.RAST,
            a.PRIM,
            a.KOD_ST_POG,
            b.ID,
            b.ABOUT as ID_NAME
                from RAILWAY_STATIONS a, RAILROADS b where b.ID = a.KOD_DOR";

        public void Name(ref List<Three> listp)
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
                decimal id = (decimal)dtr["KOD"];
                string name = (string)dtr["NM"];
                string about = (string)dtr["ID_NAME"];


                while (!Eof && id == (decimal)dtr["KOD"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Three(id, name, about.ToString()));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }


        public void Change(ref List<TenForRailwayStations> listp, decimal id_)
        {
            string sql5 =
        @"select 
            a.KOD,
            a.NM,
            a.NME,
            a.NM_R,
            a.KOD_DOR,
            a.PAR,
            a.RAST,
            a.PRIM,
            a.KOD_ST_POG,
            b.ID,
            b.ABOUT as ID_NAME
                from RAILWAY_STATIONS a, RAILROADS b where b.ID = a.KOD_DOR and " + id_ + " = a.KOD  ";
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
            decimal id = (decimal)dtr["KOD"];

            //[Required(ErrorMessage = "Поле должно быть установлено")]
            decimal kod_dor = (decimal)dtr["KOD_DOR"];

            decimal par = (decimal)dtr["PAR"];
            decimal rast = (decimal)dtr["RAST"];
            decimal kod_st_pog = (decimal)dtr["KOD_ST_POG"];
            string name = (string)dtr["NM"];
            string nme;
            if (dtr["NME"] is System.DBNull)
            {
                nme = " ";
            }
            else { nme = (string)dtr["NME"]; }
            string nm_r;
            if (dtr["NM_R"] is System.DBNull)
            {
                nm_r = " ";
            }
            else { nm_r = (string)dtr["NM_R"]; }


            string prim;
            if (dtr["PRIM"] is System.DBNull)
            {
                prim = " ";
            }
            else
            {
                prim = (string)dtr["PRIM"];
            }
            string name_dor = (string)dtr["ID_NAME"];


            listp.Add(new TenForRailwayStations(id, name, nme, nm_r, kod_dor, par, rast, prim, kod_st_pog, name_dor));




            conn.Close();
        }
        public void Roads(ref List<Two> listAt)
        {
            string sql5 =
       @"select 
            ID,
            NAME
            
                from RAILROADS order by ID";

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
                decimal id = (decimal)dtr["ID"];
                string name = (string)dtr["NAME"];







                while (!Eof && id == (decimal)dtr["ID"])
                {

                    //string[] people = array.Append(item);

                    listAt.Add(new Two(id, name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void ChangeSave(decimal id, string name, string nme, string nm_r, decimal kod_dor, decimal par, decimal rast, string prim, decimal kod_st_pog)


        {

            string sql1 = "UPDATE RAILWAY_STATIONS SET NM = '" + name + "', NME = '" + nme + "',NM_R = '" + nm_r + "',KOD_DOR = '" + kod_dor + "',PAR = '" + par + "',RAST = '" + rast + "',PRIM = '" + prim + "',KOD_ST_POG = '" + kod_st_pog + "' WHERE KOD = " + id + "";

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
            string sql2 = "DELETE RAILWAY_STATIONS WHERE KOD = " + id + "";

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

        public void Load(decimal id, string name, string nme, string nm_r, decimal kod_dor, decimal par, decimal rast, string prim, decimal kod_st_pog)
        {


            string sql1 = "INSERT INTO RAILWAY_STATIONS ( KOD, NM, NME, NM_R, KOD_DOR,  PAR,  RAST,  PRIM,  KOD_ST_POG) VALUES('" + id + "','" + name + "', '" + nme + "' ,  '" + nm_r + "' , '" + kod_dor + "'  , '" + par + "'  , '" + rast + "'  , '" + prim + "'  ,  '" + kod_st_pog + "')";
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