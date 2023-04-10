using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaBBDD
{
    public class BBDD
    {
       public static string connetionstrings = ConfigurationManager.ConnectionStrings["StringKey"].ConnectionString;

        public static SqlConnection connetion()
        {
            SqlConnection sqlconnetion = new SqlConnection();
            sqlconnetion.ConnectionString = BBDD.connetionstrings;
            sqlconnetion.Open();
            return sqlconnetion;
        }

        public static SqlCommand command(string stringSql, CommandType commandType)
        {
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = connetion();
            sqlcommand.CommandType = commandType;
            sqlcommand.CommandText = stringSql;
            return sqlcommand;
        }
        public static SqlConnection close()
        {
            SqlConnection sqlclose = new SqlConnection();
            sqlclose.ConnectionString = BBDD.connetionstrings;
            sqlclose.Close();
            return sqlclose;
        }


    }
}
