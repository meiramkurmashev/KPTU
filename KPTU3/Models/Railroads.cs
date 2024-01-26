using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class Railroads
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
            ID,
            NAME,
            ABOUT
                from RAILROADS";

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
                decimal id = (decimal)dtr["ID"];
                string name = (string)dtr["NAME"];
                string about;
                if ((string)dtr["ABOUT"] == (null)) { about = " "; }
                else { about = (string)dtr["ABOUT"]; }

                while (!Eof && id == (decimal)dtr["ID"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Three(id, name, about));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }
        public void Change(ref List<Three> listp, decimal id_)
        {

#pragma warning disable CS0618 // Тип или член устарел
#pragma warning disable CS0618 // Тип или член устарел
            OracleCommand cmd = new OracleCommand();
#pragma warning restore CS0618 // Тип или член устарел
#pragma warning restore CS0618 // Тип или член устарел
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql + " WHERE ID =" + id_;


            conn.Open();
            OracleDataReader dtr = cmd.ExecuteReader();

            dtr.Read();



            //string[] people = new people;
            decimal id = (decimal)dtr["ID"];
            string name = (string)dtr["NAME"];
            string about = (string)dtr["ABOUT"];



            listp.Add(new Three(id, name, about));




            conn.Close();
        }
        public void ChangeSave(decimal id, string name, string about)


        {
            string sql1 = "UPDATE RAILROADS SET NAME = '" + name + "', ABOUT = '" + about + "' WHERE ID = " + id + "";

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
            string sql2 = "DELETE RAILROADS WHERE ID = " + id + "";

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

        public void Load(decimal id, string name, string about)
        {
            string sql1 = "INSERT INTO RAILROADS ( ID, NAME, ABOUT) VALUES('" + id + "','" + name + "', '" + about + "')";
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