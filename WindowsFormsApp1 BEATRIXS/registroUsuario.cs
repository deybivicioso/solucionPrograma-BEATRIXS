
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
   
    public partial class registroUsuario : Form
    {
       
        funcionesSistemas bloque2 = new funcionesSistemas();       
       
        
        public registroUsuario()
        {
            InitializeComponent();
            
        }
        //
        /*evento click: al oprimir el el boton registrar en el formulario de registro, aparecera un mensaje 
         indicando que el registro fue completado*/
        //
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
            //
            //control de regostro
            //
            if (txtbRegistroNombre.Text == "NOMBRE" & txtbRegistroApellido.Text == "APELLIDO" & txtbRegistroTelefono.Text == "TELEFONO" &
                txtbRegistroEmail.Text == "E-MAIL" & txtbRegistroContraseña.Text == "CONTRASEÑA")
            {
                MessageBox.Show("completar el formulario", "mesage", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtbRegistroNombre.Text != "NOMBRE" & txtbRegistroApellido.Text != "APELLIDO" & txtbRegistroTelefono.Text != "TELEFONO" &
                txtbRegistroEmail.Text != "E-MAIL" & txtbRegistroContraseña.Text != "CONTRASEÑA") {
                

                try
                {
                    string cadena = ("insert into usuario (nombreUusuario, apellido, telefono, email,contraseña)" +
                        " values ('" + txtbRegistroNombre.Text + "','" + txtbRegistroApellido.Text + "',"
                        + "'" + txtbRegistroTelefono.Text + "','" + txtbRegistroEmail.Text + "','" + txtbRegistroContraseña.Text + "')");
                    libreriaBBDD.BBDD.command(cadena, CommandType.Text).ExecuteNonQuery();
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
            
                
            
            
        }
        //
        /*evento enter: efecto visual para la casilla donde el usuario ingresa su nombre*/
        //
        private void txtbRegistroNombre_Enter(object sender, EventArgs e)
        {
            if (txtbRegistroNombre.Text == "NOMBRE")
            {
                txtbRegistroNombre.Text = "";
                txtbRegistroNombre.ForeColor = Color.Black;
            }


        }
        //
        /*evento leave: segundo efecto visual para la casilla donde el usuario ingresa su nombre*/
        //
        private void txtbRegistroNombre_Leave(object sender, EventArgs e)
        {
            if (txtbRegistroNombre.Text == "")
            {
                txtbRegistroNombre.Text = "NOMBRE";
                txtbRegistroNombre.ForeColor = Color.Black;
            }
        }
        //
        /*evento enter: efecto visual para la casilla donde el usuario ingresa su apellido*/
        //
        private void txtbRegistroApellido_Enter(object sender, EventArgs e)
        {
            if (txtbRegistroApellido.Text == "APELLIDO")
            {
                txtbRegistroApellido.Text = " ";
                txtbRegistroApellido.ForeColor = Color.Black;
            }

        }
        //
        /*evento leave: segundo efecto visual para la casilla donde el usuario ingresa su apellido*/
        //
        private void txtbRegistroApellido_Leave(object sender, EventArgs e)
        {
            if (txtbRegistroApellido.Text == " ")
            {
                txtbRegistroApellido.Text = "APELLIDO";
                txtbRegistroApellido.ForeColor = Color.Black;
            }

        }
        //
        /*evento enter: efecto visual para la casilla de telefono*/
        //
        private void txtbRegistroTelefono_Enter(object sender, EventArgs e)
        {
            if (txtbRegistroTelefono.Text == "TELEFONO")
            {
                txtbRegistroTelefono.Text = "";
                txtbRegistroTelefono.ForeColor = Color.Black;
            }

        }
        //
        /*Evento leave: segundo visual para la casilla tefelono*/
        //
        private void txtbRegistroTelefono_Leave(object sender, EventArgs e)
        {
            if (txtbRegistroTelefono.Text == "")
            {
                txtbRegistroTelefono.Text = "TELEFONO";
                txtbRegistroTelefono.ForeColor = Color.Black;
            }

        }
        //
        /*evento enter: efecto visual para la casilla de E-MAIL*/
        //
        private void txtbRegistroEmail_Enter(object sender, EventArgs e)
        {
            if (txtbRegistroEmail.Text == "E-MAIL") {
                txtbRegistroEmail.Text = "";
                txtbRegistroEmail.ForeColor = Color.Black;
            }
        }
        //
        /*Evento leave: segundo visual para la casilla E-mail*/
        //
        private void txtbRegistroEmail_Leave(object sender, EventArgs e)
        {
            if (txtbRegistroEmail.Text == "") 
            {
                txtbRegistroEmail.Text = "E-MAIL";
                txtbRegistroEmail.ForeColor = Color.Black;
            }
        }
        //
        /*evento enter: efecto visual para la casilla de CONTRASEÑA*/
        //
        private void txtbRegistroContraseña_Enter(object sender, EventArgs e)
        {
            if (txtbRegistroContraseña.Text == "CONTRASEÑA") {
                txtbRegistroContraseña.Text = "";
                txtbRegistroContraseña.ForeColor = Color.Black;
            }
        }
        //
        /*Evento leave: segundo visual para la casilla CONTRASEÑA*/
        //
        private void txtbRegistroContraseña_Leave(object sender, EventArgs e)
        {
            if (txtbRegistroContraseña.Text == "")
            {
                txtbRegistroContraseña.Text = "CONTRASEÑA";
                txtbRegistroContraseña.ForeColor = Color.Black;
            }

        }
        //
        /*en este evento restringiremos el textBox registroNombre para que solo
         se puedan ingresar caracteres alfabeticos.*/
        //
        private void txtbRegistroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloque2.bloqueoLetras(e);
        }
        //
        /*en este evento restringiremos el textBox registroApellido para que solo
         se puedan ingresar caracteres alfabeticos.*/
        //
        private void txtbRegistroApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloque2.bloqueoLetras(e);
        }
        //
        /*en este evento restringiremos el textBox registroTelefono para que solo
         se puedan ingresar caracteres alfanumericos.*/
        //
        private void txtbRegistroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloque2.bloqueoNumeros(e);
        }
        //
        /*con este evento configuramos el boton de cerrar el programa desde el formulario registro usuario.*/
        //
        private void pctrbCerrar3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        /*con este evento configuramos la funcion del boton de minimizar del formulario registro usiario.*/
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //
        /*con el evento del boton regresar del formulario registro, cerraremos el formaulario en cuestion y volveremos al
         formulario principal.*/
        //
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
