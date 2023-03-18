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
   
    public partial class registroUsuario : Form
    {
        funcionesSistemas bloque2 = new funcionesSistemas();       
        funcionamiento conetar = new funcionamiento();
        string cadena = "Data Source=localhost;Initial Catalog=BEATRIXS01;Integrated Security=True";
        private SqlConnection conetar01 = new SqlConnection();
        
        public registroUsuario()
        {
            InitializeComponent();
            conetar01.ConnectionString = cadena;
        }
        //
        /*evento click: al oprimir el el boton registrar en el formulario de registro, aparecera un mensaje 
         indicando que el registro fue completado*/
        //
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            conetar.abrir();
            try {
                string cadena01 = "insert into registro ([nombre],[apellido], [telefono],[email],[contraseña])+" +
                " values ('" + txtbRegistroNombre.Text + "','" + txtbRegistroApellido.Text + "','" + txtbRegistroTelefono.Text + "','" + txtbRegistroEmail.Text + "','" + txtbRegistroContraseña.Text + "')";
                SqlCommand realizar = new SqlCommand(cadena01, conetar01);
                MessageBox.Show("logramos insertando datos");
            }
            catch (Exception ex) {
                MessageBox.Show("fallamos insertando datos" + ex.Message);
            }
            
            if (txtbRegistroNombre.Text == "NOMBRE") { 
                MessageBox.Show("Completar Solicitud de registro.", "registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (txtbRegistroApellido.Text == "APELLIDO")
            {
                MessageBox.Show("Completar Solicitud de registro.", "registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbRegistroTelefono.Text == "TELEFONO")
            {
                MessageBox.Show("Completar Solicitud de registro.", "registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbRegistroEmail.Text == "E-MAIL")
            {
                MessageBox.Show("Completar Solicitud de registro.", "registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtbRegistroContraseña.Text == "CONTRASEÑA")
            {
                MessageBox.Show("Completar Solicitud de registro.", "registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Solicitud de registro confirmada.", "registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
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
    }
}
