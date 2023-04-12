using libreriaBBDD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_BEATRIXS
{
    public class dataBase
    {
       /* public dataBase() {
            connetionstrings();
            conecion();
            orden("", CommandType.Text);
            cerrardata();
        }*/
        public string connetionstrings()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["StringKey"].ConnectionString;
            return connectionString;
        }

        public SqlConnection conecion()
        {
            SqlConnection sqlconnetion = new SqlConnection();
            sqlconnetion.ConnectionString = connetionstrings();
            sqlconnetion.Open();
            return sqlconnetion;
        }

        public SqlCommand orden(string stringSql, CommandType commandType)
        {
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = conecion();
            sqlcommand.CommandType = commandType;
            sqlcommand.CommandText = stringSql;
            return sqlcommand;
        }
        public SqlConnection cerrardata()
        {
            SqlConnection sqlclose = new SqlConnection();
            sqlclose.ConnectionString = connetionstrings();
            sqlclose.Close();
            return sqlclose;
        }
    }
}
       

       
    

