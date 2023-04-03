using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_BEATRIXS
{
    public partial class login : Form
    {
        funcionesSistemas bloqueo = new funcionesSistemas();
       
        
        public login()
        {
            InitializeComponent();
             
        }
        //
        /*ESTE EVENto permite la aparicion del formulario registro de Usuario tras presionar el boton registrarse del login*/
        //
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {           
            registroUsuario ventana = new registroUsuario();
            ventana.ShowDialog();          
        }
        //
        /*este evento cierra el formulario login cuando se pulsa el boton aceptar.*/
        private void btnAceptLogin_Click(object sender, EventArgs e)
        {
         
            this.Close(); 
        }
        //
        /*en este evento para textBox nombre cuando el usuario tenga el mouse sobre la casilla esta borrara USUARIO*/
        //
        private void txtbNombre_Enter(object sender, EventArgs e)
        {
            if (txtbNombre.Text == "USUARIO")
            {
                txtbNombre.Text = " ";
                txtbNombre.ForeColor = Color.Black;
            }
           
                    
        }
        //
        /*este evento funciona igual que el eventoque esta sobre el, solo que con el textBox contraseña*/
        //
        private void txtbContraseña_Enter(object sender, EventArgs e)
        {
            if (txtbContraseña.Text == "CONTRASEÑA") {
                txtbContraseña.Text = "";
                txtbContraseña.UseSystemPasswordChar = true;
            }
        }
        //
        /*en este evento cuando el usuario aleje el raton del textBox nombre y este no contenga nada en su interio 
         se rellenara con la palabra USUARIO*/
        private void txtbNombre_Leave(object sender, EventArgs e)
        {
            if (txtbNombre.Text == " ") { 
                txtbNombre.Text="USUARIO";
                txtbNombre.ForeColor = Color.Black;
            }
        }
        //
        /*funciona igual que el evento arriba de este solo que el textBox contraseña se rellenara con la palabra
         CONTRASEñA (este evento se aplica al  textBox contraseña)*/
        //
         
        private void txtbContraseña_Leave(object sender, EventArgs e)
        {
            if (txtbContraseña.Text == "") { 
                txtbContraseña.Text = "CONTRASEÑA ";
                txtbContraseña.ForeColor = Color.Black;
                txtbContraseña.UseSystemPasswordChar = false;
            }
        }
        
        //
        /*ESTE EVENTO impedira que se ingrese en la caja de texto de nombre
         cualquier que no sean letras*/
        private void txtbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo.bloqueoLetras(e);
        }
       
    }
}
