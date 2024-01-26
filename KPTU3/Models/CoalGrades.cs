using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class CoalGrades
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
            NM,
            NME,
            GR_KM,
            ZOLA,
            VLAGA,
            SERA,
            CENA,
            DT_C
                from COAL_GRADES";


        public void Name(ref List<Nine> listp)
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
                decimal number1 = (decimal)dtr["KOD"];
                string number2 = (string)dtr["NM"];
                string number3 = (string)dtr["NME"];
                decimal number4 = (decimal)dtr["GR_KM"];
                decimal number5 = (decimal)dtr["ZOLA"];
                decimal number6 = (decimal)dtr["VLAGA"];
                decimal number7 = (decimal)dtr["SERA"];
                decimal number8 = (decimal)dtr["CENA"];
                DateTime? number9 = null;
                if (!number9.HasValue)
                {
                    number9 = (DateTime)dtr["DT_C"];
                }






                while (!Eof && number1 == (decimal)dtr["KOD"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Nine(number1, number2, number3, number4, number5, number6, number7, number8, (DateTime)number9));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }

        public void CoalTypes(ref List<Two> listCT)
        {
            string sql5 =
       @"select 
            ID,
            NAME
            
                from COAL_TYPES";

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

                    listCT.Add(new Two(id, name));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void Change(ref List<Nine> listp, decimal id)


        {

#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql + " WHERE KOD =" + id;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            dtr.Read();



            //string[] people = new people;
            decimal number1 = (decimal)dtr["KOD"];
            string number2 = (string)dtr["NM"];
            string number3 = (string)dtr["NME"];
            decimal number4 = (decimal)dtr["GR_KM"];
            decimal number5 = (decimal)dtr["ZOLA"];
            decimal number6 = (decimal)dtr["VLAGA"];
            decimal number7 = (decimal)dtr["SERA"];
            decimal number8 = (decimal)dtr["CENA"];
            DateTime? number9 = null;
            if (!number9.HasValue)
            {
                number9 = (DateTime)dtr["DT_C"];
            }

            listp.Add(new Nine(number1, number2, number3, number4, number5, number6, number7, number8, (DateTime)number9));




            conn.Close();
        }
        public void ChangeSave(decimal id, string nm, string nme, decimal gr_km, decimal zola, decimal vlaga, decimal sera, decimal cena, string dt_c)


        {
            //string date = dt_c.ToString("dd.MM.yyyy");
            string sql1 = "UPDATE COAL_GRADES SET NM = '" + nm + "', NME = '" + nme + "', GR_KM = '" + gr_km + "', ZOLA = '" + zola + "', VLAGA = '" + vlaga + "', SERA = '" + sera + "', CENA = '" + cena + "', DT_C = TO_DATE('" + dt_c + "', 'dd.MM.yyyy hh24:mi:ss') WHERE KOD = " + id + "";

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
            string sql2 = "DELETE COAL_GRADES WHERE KOD = " + id + "";

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
        public void Load(decimal id, string nm, string nme, decimal gr_km, decimal zola, decimal vlaga, decimal sera, decimal cena, DateTime dt_c)
        {
            string sql1 = "INSERT INTO COAL_GRADES(KOD,NM, NME , GR_KM , ZOLA, VLAGA , SERA , CENA , DT_C ) VALUES('" + id + "','" + nm + "','" + nme + "','" + gr_km + "','" + zola + "','" + vlaga + "','" + sera + "','" + cena + "',TO_DATE('" + dt_c + "', 'dd.MM.YYYY hh24:mi:ss'))";
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
