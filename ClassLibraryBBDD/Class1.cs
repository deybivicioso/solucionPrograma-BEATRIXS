using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;



namespace ClassLibraryBBDD
{
    public static class Class1
    {
        public static string connetionstrings = ConfigurationManager.ConnectionStrings["StringKey"].ConnectionString;


        public static SqlConnection sqlconnection()
        {
            SqlConnection sqlconnetion = new SqlConnection();
            sqlconnetion.ConnectionString = Class1.connetionstrings;
            sqlconnetion.Open();
            return sqlconnetion;
        }

        public static SqlCommand sqlcommand(string stringSql, CommandType commandType)
        {
            SqlCommand sqlcommand= new SqlCommand();
            sqlcommand.Connection = sqlconnection();
            sqlcommand.CommandType = commandType;
            sqlcommand.CommandText = stringSql;
            return sqlcommand;
        }
        public static SqlConnection sqlclose() {
            SqlConnection sqlclose = new SqlConnection();
            sqlclose.ConnectionString = Class1.connetionstrings;
            sqlclose.Close();
            return sqlclose;
        }
    }
}
