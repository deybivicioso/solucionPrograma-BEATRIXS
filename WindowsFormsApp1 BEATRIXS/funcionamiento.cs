using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_BEATRIXS
{
   
    public class funcionamiento
    {
        string cadena = "Data Source=localhost;Initial Catalog=BEATRIXS01;Integrated Security=True";
        public SqlConnection conectarbd=new SqlConnection();
        public funcionamiento() {
            conectarbd.ConnectionString = cadena;
        }
        public void abrir()
        {
            try {
                conectarbd.Open();
                Console.WriteLine("SE LOGRO COñOOOO");
            }
            catch (Exception ex) { 
                MessageBox.Show("error EN LA CONEXION DE LA BASE DE DATOS "+ex.Message);
            }
        }

        public void cerrar() {
            try
            {
                conectarbd.Close();
                Console.WriteLine("SE CERRO ESTA VAINA");
            }
            catch (Exception ex) {
                MessageBox.Show("ERRO al cerrar la base de datos" + ex.Message);
            }
           
        }

    }
}
