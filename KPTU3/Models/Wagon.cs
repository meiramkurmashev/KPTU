using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{

    public class Wagon
    {
        //TO_DATE(a.DATE1, 'dd.MM.YYYY HH24-MI-SS' )
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
            a.ID,
            TO_CHAR(a.DATE1, 'YYYY-MM-DD') as DATE6,
            a.TYPE,
            a.VERT,
            a.CODEST,
            a.CODEROTE,
            a.POTREB,
            a.CODEPOTREB,
            a.TIMEPR,
            a.TIMEDEL,
            a.TIMECLOSE,
            b.ID as TYPE_ID,
            b.NAME as TYPE_NAME,
            c.ID as VERT_ID,
            c.NAME as VERT_NAME,
            d.KOD as CODEST_ID,
            d.NM as CODEST_NAME,
            e.ID as CODEROTE_ID,
            e.NAME as CODEROTE_NAME,
            f.KOD_POT,
            f.NM as POTREB_NAME
                from LOADING a, ROUTE_TYPES b, TURNTABLES c, RAILWAY_STATIONS d, RAILROADS e, CONSUMERS f where b.ID = a.TYPE and c.ID = a.VERT and d.KOD = a.CODEST and e.ID = a.CODEROTE and f.KOD_POT = a.POTREB and STATUS = 1";

        public void Name(ref List<Loading> listp)
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
                decimal id = (decimal)dtr["ID"];
                string date1 = (string)dtr["DATE6"];

                string type = (string)dtr["TYPE"];
                string vert = (string)dtr["VERT"];
                string codest = (string)dtr["CODEST"];
                string coderote = (string)dtr["CODEROTE"];
                string potreb = (string)dtr["POTREB"];
                string codepotreb = (string)dtr["CODEPOTREB"];
                DateTime timepr = (DateTime)dtr["TIMEPR"];
                DateTime timedel = (DateTime)dtr["TIMEDEL"];
                DateTime timeclose = (DateTime)dtr["TIMECLOSE"];
                string type_name = (string)dtr["TYPE_NAME"];
                string vert_name = (string)dtr["VERT_NAME"];
                string codest_name = (string)dtr["CODEST_NAME"];
                string coderote_name = (string)dtr["CODEROTE_NAME"];
                string potreb_name = (string)dtr["POTREB_NAME"];
                while (!Eof && id == (decimal)dtr["ID"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Loading(id.ToString(), date1, type, vert, codest, coderote, potreb, codepotreb, timepr, timedel, timeclose, type_name, vert_name, codest_name, coderote_name, potreb_name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void Load(decimal id, DateTime date1, string type, string vert, string codest, string coderote, string potreb, string codepotreb, DateTime timepr, DateTime timedel, DateTime timeclose)
        {
            string sql1 = "INSERT INTO LOADING ( ID, DATE1,TYPE, VERT, CODEST, CODEROTE, POTREB,CODEPOTREB,TIMEPR,TIMEDEL,TIMECLOSE) VALUES('" + id + "',TO_DATE('" + date1 + "', 'dd.mm.yyyy hh24:mi:ss'),'" + type + "','" + vert + "','" + codest + "','" + coderote + "','" + potreb + "','" + codepotreb + "',TO_DATE('" + timepr + "', 'dd.mm.yyyy hh24:mi:ss'),TO_DATE('" + timedel + "', 'dd.mm.yyyy hh24:mi:ss'),TO_DATE('" + timeclose + "', 'dd.mm.yyyy hh24:mi:ss'))";
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
        public void Change(decimal id, DateTime date1, string type, string vert, string codest, string coderote, string potreb, string codepotreb, DateTime timepr, DateTime timedel, DateTime timeclose)
        {
            string sql1 = "UPDATE LOADING SET DATE1=TO_DATE('" + date1 + "', 'dd.mm.yyyy hh24:mi:ss'), TYPE='" + type + "', VERT='" + vert + "', CODEST='" + codest + "', CODEROTE='" + coderote + "', POTREB='" + potreb + "',CODEPOTREB='" + codepotreb + "',TIMEPR=TO_DATE('" + timepr + "', 'dd.mm.yyyy hh24:mi:ss'),TIMEDEL=TO_DATE('" + timedel + "', 'dd.mm.yyyy hh24:mi:ss'),TIMECLOSE=TO_DATE('" + timeclose + "', 'dd.mm.yyyy hh24:mi:ss') WHERE ID = " + id + "";

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
            string sql2 = "UPDATE LOADING SET STATUS = 0 WHERE ID = " + id + "";

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
        public void Name2(ref List<Loading> listp, DateTime dateFrom, DateTime dateTo)
        {
            string dateFrom1 = dateFrom.ToString("yyyy-MM-dd");
            string dateTo1 = dateTo.ToString("yyyy-MM-dd");
            string sql7 =
    @"select 
            a.ID,
            TO_CHAR(a.DATE1, 'YYYY-MM-DD') as DATE6,
            a.TYPE,
            a.VERT,
            a.CODEST,
            a.CODEROTE,
            a.POTREB,
            a.CODEPOTREB,
            a.TIMEPR,
            a.TIMEDEL,
            a.TIMECLOSE,
            b.ID as TYPE_ID,
            b.NAME as TYPE_NAME,
            c.ID as VERT_ID,
            c.NAME as VERT_NAME,
            d.KOD as CODEST_ID,
            d.NM as CODEST_NAME,
            e.ID as CODEROTE_ID,
            e.NAME as CODEROTE_NAME,
            f.KOD_POT,
            f.NM as POTREB_NAME
                from LOADING a, ROUTE_TYPES b, TURNTABLES c, RAILWAY_STATIONS d, RAILROADS e, CONSUMERS f where b.ID = a.TYPE and c.ID = a.VERT and d.KOD = a.CODEST and e.ID = a.CODEROTE and f.KOD_POT = a.POTREB and TO_CHAR(a.DATE1, 'YYYY-MM-DD') >= '" + dateFrom1 + "' and TO_CHAR(a.DATE1, 'YYYY-MM-DD') <= '" + dateTo1 + "' AND STATUS = 1";
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql7;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            bool Eof = !dtr.Read();

            while (!Eof)
            {

                //string[] people = new people;
                decimal id = (decimal)dtr["ID"];
                string date1 = (string)dtr["DATE6"];

                string type = (string)dtr["TYPE"];
                string vert = (string)dtr["VERT"];
                string codest = (string)dtr["CODEST"];
                string coderote = (string)dtr["CODEROTE"];
                string potreb = (string)dtr["POTREB"];
                string codepotreb = (string)dtr["CODEPOTREB"];
                DateTime timepr = (DateTime)dtr["TIMEPR"];
                DateTime timedel = (DateTime)dtr["TIMEDEL"];
                DateTime timeclose = (DateTime)dtr["TIMECLOSE"];
                string type_name = (string)dtr["TYPE_NAME"];
                string vert_name = (string)dtr["VERT_NAME"];
                string codest_name = (string)dtr["CODEST_NAME"];
                string coderote_name = (string)dtr["CODEROTE_NAME"];
                string potreb_name = (string)dtr["POTREB_NAME"];
                while (!Eof && id == (decimal)dtr["ID"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Loading(id.ToString(), date1, type, vert, codest, coderote, potreb, codepotreb, timepr, timedel, timeclose, type_name, vert_name, codest_name, coderote_name, potreb_name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void Name3(ref List<Loading> listp, int number)
        {

            string sql7 =
    @"select 
            a.ID,
            TO_CHAR(a.DATE1, 'YYYY-MM-DD') as DATE6,
            a.TYPE,
            a.VERT,
            a.CODEST,
            a.CODEROTE,
            a.POTREB,
            a.CODEPOTREB,
            a.TIMEPR,
            a.TIMEDEL,
            a.TIMECLOSE,
            b.ID as TYPE_ID,
            b.NAME as TYPE_NAME,
            c.ID as VERT_ID,
            c.NAME as VERT_NAME,
            d.KOD as CODEST_ID,
            d.NM as CODEST_NAME,
            e.ID as CODEROTE_ID,
            e.NAME as CODEROTE_NAME,
            f.KOD_POT,
            f.NM as POTREB_NAME
                from LOADING a, ROUTE_TYPES b, TURNTABLES c, RAILWAY_STATIONS d, RAILROADS e, CONSUMERS f where b.ID = a.TYPE and c.ID = a.VERT and d.KOD = a.CODEST and e.ID = a.CODEROTE and f.KOD_POT = a.POTREB and a.ID = " + number + " AND STATUS = 1";
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql7;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            bool Eof = !dtr.Read();

            while (!Eof)
            {

                //string[] people = new people;
                decimal id = (decimal)dtr["ID"];
                string date1 = (string)dtr["DATE6"];

                string type = (string)dtr["TYPE"];
                string vert = (string)dtr["VERT"];
                string codest = (string)dtr["CODEST"];
                string coderote = (string)dtr["CODEROTE"];
                string potreb = (string)dtr["POTREB"];
                string codepotreb = (string)dtr["CODEPOTREB"];
                DateTime timepr = (DateTime)dtr["TIMEPR"];
                DateTime timedel = (DateTime)dtr["TIMEDEL"];
                DateTime timeclose = (DateTime)dtr["TIMECLOSE"];
                string type_name = (string)dtr["TYPE_NAME"];
                string vert_name = (string)dtr["VERT_NAME"];
                string codest_name = (string)dtr["CODEST_NAME"];
                string coderote_name = (string)dtr["CODEROTE_NAME"];
                string potreb_name = (string)dtr["POTREB_NAME"];
                while (!Eof && id == (decimal)dtr["ID"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Loading(id.ToString(), date1, type, vert, codest, coderote, potreb, codepotreb, timepr, timedel, timeclose, type_name, vert_name, codest_name, coderote_name, potreb_name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }

        public void Archive(ref List<Loading> listp)
        {
            string sql8 = @"select 
            a.ID,
            TO_CHAR(a.DATE1, 'YYYY-MM-DD') as DATE6,
            a.TYPE,
            a.VERT,
            a.CODEST,
            a.CODEROTE,
            a.POTREB,
            a.CODEPOTREB,
            a.TIMEPR,
            a.TIMEDEL,
            a.TIMECLOSE,
            b.ID as TYPE_ID,
            b.NAME as TYPE_NAME,
            c.ID as VERT_ID,
            c.NAME as VERT_NAME,
            d.KOD as CODEST_ID,
            d.NM as CODEST_NAME,
            e.ID as CODEROTE_ID,
            e.NAME as CODEROTE_NAME,
            f.KOD_POT,
            f.NM as POTREB_NAME
                from LOADING a, ROUTE_TYPES b, TURNTABLES c, RAILWAY_STATIONS d, RAILROADS e, CONSUMERS f where b.ID = a.TYPE and c.ID = a.VERT and d.KOD = a.CODEST and e.ID = a.CODEROTE and f.KOD_POT = a.POTREB and STATUS = 0";
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql8;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            bool Eof = !dtr.Read();

            while (!Eof)
            {

                //string[] people = new people;
                decimal id = (decimal)dtr["ID"];
                string date1 = (string)dtr["DATE6"];

                string type = (string)dtr["TYPE"];
                string vert = (string)dtr["VERT"];
                string codest = (string)dtr["CODEST"];
                string coderote = (string)dtr["CODEROTE"];
                string potreb = (string)dtr["POTREB"];
                string codepotreb = (string)dtr["CODEPOTREB"];
                DateTime timepr = (DateTime)dtr["TIMEPR"];
                DateTime timedel = (DateTime)dtr["TIMEDEL"];
                DateTime timeclose = (DateTime)dtr["TIMECLOSE"];
                string type_name = (string)dtr["TYPE_NAME"];
                string vert_name = (string)dtr["VERT_NAME"];
                string codest_name = (string)dtr["CODEST_NAME"];
                string coderote_name = (string)dtr["CODEROTE_NAME"];
                string potreb_name = (string)dtr["POTREB_NAME"];
                while (!Eof && id == (decimal)dtr["ID"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Loading(id.ToString(), date1, type, vert, codest, coderote, potreb, codepotreb, timepr, timedel, timeclose, type_name, vert_name, codest_name, coderote_name, potreb_name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }

    }
}