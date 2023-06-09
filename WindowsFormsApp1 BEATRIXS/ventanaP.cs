﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1_BEATRIXS
{
    public partial class ventanaP : Form
    {
        
        funcionesSistemas bloqueo1=new funcionesSistemas();
       
        public ventanaP()
        {
            InitializeComponent();          

        }

        private void ventanaP_Load(object sender, EventArgs e)
        {
            //
            /*la siguientes lineas de codigos corresponden al combo box del apartado de material del producto
              y su correspondiente informacion almacenada en un array.*/
            //
            string[] materialesProductos = {"Cristal", "Madera", "Plastico", "Metal", "Papel" };            
            cmbbMaterialProucto.Items.AddRange(materialesProductos);
            //
            /*la siguientes lineas de codigos corresponden al combo box del apartado de precauciones
              y su correspondiente informacion almacenada en un array.*/
            //
            string[] precauciones = { "Inflamable", "toxico" };
            cmbbPrecauciones.Items.AddRange(precauciones);
        }
        //
        /*PRIMER evento visual para la casilla nombre.cuando el raton esta encima de la casilla 
         borrara el nombre para permitir al usuario escribir su propio nombre*/
        //
        private void txtbNombreProducto_Enter(object sender, EventArgs e)
        {
            if (txtbNombreProducto.Text == "NOMBRE") {
                txtbNombreProducto.Text = "";
                txtbNombreProducto.ForeColor = Color.Black;
            }

        }
        //
        /*segundo evento visual para la casilla nombre. cuando el raton sale de la casilla, si esta
         vacia vuelve a escribir NOMBRE*/
        //
        private void txtbNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtbNombreProducto.Text == "") {
                txtbNombreProducto.Text = "NOMBRE";
                txtbNombreProducto.ForeColor = Color.Black;
            }
        }
        //
        /*PRIMER evento visual para la casilla Material del prodructo.cuando el raton esta encima de la casilla 
         borrara el nombre para permitir al usuario escribir  none*/
        //
        private void cmbbMaterialProucto_Enter(object sender, EventArgs e)
        {
            if (cmbbMaterialProucto.Text == "NONE") {
                cmbbMaterialProucto.Text = "";
                cmbbMaterialProucto.ForeColor = Color.Black;

            }
        }
        //
        /*segundo evento visual para la casilla material del prosucto. cuando el raton sale de la casilla, 
         * si esta vacia vuelve a escribir NONE*/
        //
        private void cmbbMaterialProucto_Leave(object sender, EventArgs e)
        {
            if (cmbbMaterialProucto.Text == "") {
                cmbbMaterialProucto.Text = "NONE";
                cmbbMaterialProucto.ForeColor = Color.Black;

            }

        }
        //
        /*PRIMER evento visual para la casilla Peso del paquete.cuando el raton esta encima de la casilla 
          se borrara el NONE*/
        //
        private void txtbPesomaterial_Enter(object sender, EventArgs e)
        {
            if (txtbPesomaterial.Text == "PESO")
            {
                txtbPesomaterial.Text = "";
                txtbPesomaterial.ForeColor = Color.Black;

            }

        }
        //
        /*SEGUNDO evento visual para la casilla Peso del paquete.cuando el raton salga de la casilla 
          se vuelve a escribir el NONE*/
        //
        private void txtbPesomaterial_Leave(object sender, EventArgs e)
        {

            if (txtbPesomaterial.Text == "")
            {
                txtbPesomaterial.Text = "PESO";
                txtbPesomaterial.ForeColor = Color.Black;
            }

        } 
        //
        /*este evento impedira que en el textBox nombre del producto si ingrese caracteres numericos*/
        //
        private void txtbNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo1.bloqueoLetras(e);
        }
        //
        /*este evento impedira que en el textBox peso material se ingrese caracteres alfabeticos.*/
        //
        private void txtbPesomaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo1.bloqueoNumeros(e);
        }
       //
        /*este evento nos permitira guardar lo que ingresemos en el form ventanaP en la base de datos*/
        //
        private void btnVentanaPAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena1 = ("insert into envioPaquete(nombreProducto,materialProducto,pesoMaterial,precaucion )" +
                    " values('" + txtbNombreProducto.Text + "','" + cmbbMaterialProucto.Text + "','" + txtbPesomaterial.Text + "'" +
                    ",'" + cmbbPrecauciones.Text + "')");
                libreriaBBDD.BBDD.command(cadena1, CommandType.Text).ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error de tipo: " + ex.Message, "atencion sqlexcepcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DataException ex)
            {
                MessageBox.Show("error de tipo: " + ex.Message, "atencion dataexcepcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error de tipo: " + ex.Message, "atencion excepcion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                libreriaBBDD.BBDD.close();
                this.Close();
                this.Dispose();
            }
        }
        //
        /*configuracion del booton cerrar del formulario ventanaP.*/
        //
        private void pctrbCerrar4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        /*configuracion del boton minimizar del formulario ventanaP.*/
        //
        private void pctrbMinimizar4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        /*primer evento visual para la casilla precauciones cuando el raton entre ne la casilla 
          se vaciara.*/
        //
        private void cmbbPrecauciones_Enter(object sender, EventArgs e)
        {
              if (cmbbPrecauciones.Text == "None")
                {
                    cmbbPrecauciones.Text = "";
                    cmbbPrecauciones.ForeColor = Color.Black;

                }
        }
        //
        /*SEGUNDO evento visual para la casilla precauciones cuando el raton salga de la casilla 
          se vuelve a escribir el NONE*/
        //
        private void cmbbPrecauciones_Leave(object sender, EventArgs e)
        {
            if (cmbbPrecauciones.Text == "")
            {
                cmbbPrecauciones.Text = "None";
                cmbbPrecauciones.ForeColor = Color.Black;

            }
        }
    }
}
