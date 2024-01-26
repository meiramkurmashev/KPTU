using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class CoalSupplier
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
            KOD_POST,
            KM,
            ZOLA,
            VLAGA,
            SERA
                from COAL_SUPPLIER";
        public void Create(ref List<Two> listp)
        {
            string sql3 = @"select 
            KOD,
            NM
           
                from SUPPLIERS";
#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql3;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            bool Eof = !dtr.Read();

            while (!Eof)
            {

                //string[] people = new people;
                decimal id = (decimal)dtr["KOD"];
                string name = (string)dtr["NM"];



                //while (!Eof && id == (decimal)dtr["ID"])
                //{

                //string[] people = array.Append(item);

                listp.Add(new Two(id, name));
                Eof = !dtr.Read();
                //}




            }
            conn.Close();
        }

        public void Name(ref List<FiveForCoalSupplier> listp)
        {
            string sql5 = "select a.kod_post, a.km, b.kod as kod_ug, b.nm as nm_ug, c.kod as kod_post1, c.nm as nm_post from coal_supplier a, coal_grades b, suppliers c where a.kod_post = c.kod and a.km = b.kod";
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
                decimal number1 = (decimal)dtr["KOD_POST"];
                decimal number2 = (decimal)dtr["KM"];

                decimal number3 = (decimal)dtr["kod_post1"];
                string number4 = (string)dtr["NM_post"];
                decimal number5 = (decimal)dtr["KOD_ug"];
                string number6 = (string)dtr["NM_ug"];

                //while (!Eof && id == (decimal)dtr["ID"])
                //{

                //string[] people = array.Append(item);

                listp.Add(new FiveForCoalSupplier(number1, number2, number3, number4, number5, number6));
                Eof = !dtr.Read();
                //}




            }
            conn.Close();
        }
        public void Change(ref List<Seven> listp, decimal kod_post, decimal km)


        {
            string sql5 = "select a.kod_post, a.km, a.zola, a.vlaga, a.sera , b.nm as nm_ug, c.nm as nm_post from coal_supplier a, coal_grades b, suppliers c where " + kod_post + " = c.kod and " + km + " = b.kod";

#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = sql + " WHERE KOD_POST =" + kod_post+ " AND KM = " +km;
            cmd.CommandText = sql5;

            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            dtr.Read();



            //string[] people = new people;
            string name1 = (string)dtr["nm_post"];
            string name2 = (string)dtr["nm_ug"];
            decimal number1 = (decimal)dtr["KOD_POST"];

            decimal number2 = (decimal)dtr["KM"];
            decimal number3 = (decimal)dtr["ZOLA"];
            decimal number4 = (decimal)dtr["VLAGA"];
            decimal number5 = (decimal)dtr["SERA"];


            listp.Add(new Seven(name1, name2, number1, number2, number3, number4, number5));




            conn.Close();
        }
        public void ChangeSave(decimal kod_post, decimal km, decimal zola, decimal vlaga, decimal sera)


        {
            //string date = dt_c.ToString("dd.MM.yyyy");
            string sql1 = "UPDATE COAL_SUPPLIER SET  ZOLA = '" + zola + "', VLAGA = '" + vlaga + "', SERA = '" + sera + "' WHERE KOD_POST = " + kod_post + " AND KM ='" + km + "' ";

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
        public void Delete(decimal kod_post, decimal km)
        {
            string sql2 = "DELETE COAL_SUPPLIER WHERE KOD_POST = " + kod_post + " AND KM =" + km;

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
        public void Load(decimal kod_post, decimal km, decimal zola, decimal vlaga, decimal sera)
        {
            string sql1 = "INSERT INTO COAL_SUPPLIER(KOD_POST,KM  , ZOLA, VLAGA , SERA ) VALUES('" + kod_post + "','" + km + "','" + zola + "','" + vlaga + "','" + sera + "')";
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