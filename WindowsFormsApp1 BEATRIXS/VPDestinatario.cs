
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1_BEATRIXS
{
    public partial class VPDestinatario : Form
    {
        funcionesSistemas bloqueo1=new funcionesSistemas();
        public VPDestinatario()
        {
            InitializeComponent();
        }
        //
        /*en este evento de la caja de texto del destinatario cada vez que el teclado este encima de la caja de texto, su 
         contenido inicial se vaciara.*/
        //
        private void txtbxDestinatario_Enter(object sender, EventArgs e)
        {
            if (txtbxDestinatario.Text == "NOMBRE")
            {
                txtbxDestinatario.Text = "";
                txtbxDestinatario.ForeColor = Color.Black;
            }
        }
        //
        /*con este evento la caja de texto del destinatario se llenara con texto una vez el mouse salga de ella.*/
        //
        private void txtbxDestinatario_Leave(object sender, EventArgs e)
        {

            if (txtbxDestinatario.Text == "")
            {
                txtbxDestinatario.Text = "DESTINATARIO";
                txtbxDestinatario.ForeColor = Color.Black;
            }
        }
        //
        /*este evento impide que en la caja de texto del destinatario se ingrese numeros.*/
        //
        private void txtbxDestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo1.bloqueoLetras(e);
        }
        //
        /*con este evento la caja de texto de direccion se vaciara su contenido inicial cuando se ingrese datos  */
        //
        private void txtbxDireccion_Enter(object sender, EventArgs e)
        {
            if (txtbxDireccion.Text == "DIRECCION")
            {
                txtbxDireccion.Text = "";
                txtbxDireccion.ForeColor = Color.Black;
            }

        }
        //
        /*con este evento cunado la caja de texto de direccion este vacia volvera a tener su contenido inicial.*/
        //
        private void txtbxDireccion_Leave(object sender, EventArgs e)
        {
            if (txtbxDireccion.Text == "")
            {
                txtbxDireccion.Text = "DIRECCION";
                txtbxDireccion.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento al llenar la caja de texto del codigo postal este vaciara su contenido inicial.*/
        //
        private void txtbxCodigo_Enter(object sender, EventArgs e)
        {
            if (txtbxCodigo.Text == "CODIGO")
            {
                txtbxCodigo.Text = "";
                txtbxCodigo.ForeColor = Color.Black;
            }
        }
        //
        /*cuando la caja de texto del codigo postal este vacia este volvera a tener su mensaje inicial. */
        //
        private void txtbxCodigo_Leave(object sender, EventArgs e)
        {
            if (txtbxCodigo.Text == "")
            {
                txtbxCodigo.Text = "CODIGO";
                txtbxCodigo.ForeColor = Color.Black;
            }
        }
        //
        /*con este evento impedimos que en el cuadro de texto de la casilla "codigo postal se 
         * ingrese valores alfanumericos, solo numeros."*/
        //
        private void txtbxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo1.bloqueoNumeros(e);
        }
        //
        /*cuando la caja de texto del telefono sea llenada su texto inicial sera borrado. */
        //
        private void txtbxTelefono_Enter(object sender, EventArgs e)
        {
            if (txtbxTelefono.Text == "TELEFONO") {
                txtbxTelefono.Text = "";
                txtbxTelefono.ForeColor=Color.Black;
            }
        }
        //
        /*cuando la caja de texto de la casilla telefono este vacia, se llenara con el 
         texto inicial.*/
        //
        private void txtbxTelefono_Leave(object sender, EventArgs e)
        {
            if (txtbxTelefono.Text == "")
            {
                txtbxTelefono.Text = "TELEFONO";
                txtbxTelefono.ForeColor = Color.Black;
            }
        }
        //
        /*con este evento se evitara que en la caja de texto del apartado de telefono, se 
         ingrese elementos diferentes a los alfanumericos.*/
        //
        private void txtbxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo1.bloqueoNumeros(e);
        }
        //
        /*con este evento la caja de texto de la casilla E-Mail vaciara su texto inicial a la hora de rellenarla.*/
        //
        private void txtbEmail_Enter(object sender, EventArgs e)
        {
            if (txtbEmail.Text == "E-MAIL") {
                txtbEmail.Text = "";
                txtbEmail.ForeColor = Color.Black;  
            }
        }
        //
        /*con este evento cuando la casilla correspondiente al email este vacia, se rellenara con
         el texto inicial.*/
        //
        private void txtbEmail_Leave(object sender, EventArgs e)
        {
            if (txtbEmail.Text == "")
            {
                txtbEmail.Text = "E-MAIL";
                txtbEmail.ForeColor = Color.Black;
            }
        }
        //
        /*configuracion del boton cerrar del formulario VPDestinatario.*/
        //
        private void pctrbCerrar5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        /*configuracion del boton minimizar del formulario VPDestinatario. */
        //
        private void pctrbMinimizar5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        /*en este evento guardaremos la informacion del formulario en la BBDD*/
         // 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena2 = ("insert into destinatario (direccion,codigoPostal,telefono,email)" +
                    " values ('" + txtbxDestinatario.Text + "','" + txtbxDireccion.Text + "'," +
                    "'" + txtbxCodigo.Text + "','" + txtbxTelefono.Text + "','" + txtbEmail.Text + "')");
                libreriaBBDD.BBDD.command(cadena2, CommandType.Text).ExecuteNonQuery();
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
        /*con este evento retornaremos al formulario ventanaP.*/
        //
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ventanaP nueva=new ventanaP();
            nueva.ShowDialog();
        }
    }
}
