using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace KPTU.Models
{
    public class ConsumerGroups
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
           
            NAME
                from CONSUMER_GROUPS";

        public void Name(ref List<Two> listp)
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
            decimal id = 1;
            while (!Eof)
            {

                //string[] people = new people;

                string name = (string)dtr["NAME"];

                while (!Eof && name == (string)dtr["NAME"])
                {

                    //string[] people = array.Append(item);

                    listp.Add(new Two(id, name));
                    Eof = !dtr.Read();
                    id++;
                }




            }
            conn.Close();
        }
        public void Change(ref List<Two> listp, decimal id_)
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



            listp.Add(new Two(id, name));




            conn.Close();
        }
        public void ChangeSave(decimal id, string name)


        {
            string sql1 = "UPDATE CONSUMER_GROUPS SET NAME = '" + name + "' WHERE ID = " + id + "";

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
            string sql2 = "DELETE CONSUMER_GROUPS WHERE ID = " + id + "";

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

        public void Load(decimal id, string name)
        {
            string sql1 = "INSERT INTO CONSUMER_GROUPS ( ID, NAME) VALUES('" + id + "','" + name + "')";
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
