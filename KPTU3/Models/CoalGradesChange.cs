using System;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class CoalGradesChange
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
            NANE
                from COAL_GRADES";
        public void Get(decimal id, string name)
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
                // decimal id = (decimal)dtr["ID"];

                //string name = (string)dtr["TYPE"];
                string vert = (string)dtr["VERT"];

                while (!Eof && id == (decimal)dtr["ID"])
                {

                    //string[] people = array.Append(item);

                    //        listp.Add(new Loading(id.ToString(), date1, type, vert, codest, coderote, potreb, codepotreb, timepr, timedel, timeclose));
                    Eof = !dtr.Read();
                }




            }
            conn.Close();
        }

        public void ChangeSave(decimal id, string name)


        {
            string sql1 = "UPDATE COAL_GRADES SET NAME=" + name + " WHERE ID = " + id + "";

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
