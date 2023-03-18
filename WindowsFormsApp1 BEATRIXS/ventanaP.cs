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
    public partial class ventanaP : Form
    {
       funcionesSistemas bloqueo1=new funcionesSistemas();
        funcionamiento conetar = new funcionamiento();
        string cadena = "Data Source=localhost;Initial Catalog=BEATRIXS01;Integrated Security=True";
        private SqlConnection conetar01 = new SqlConnection();
        public ventanaP()
        {
            InitializeComponent();
            conetar01.ConnectionString = cadena;

        }

        private void ventanaP_Load(object sender, EventArgs e)
        {
            //
            /*la siguientes lineas de codigos corresponden al combo box del apartado de material del producto
              y su correspondiente informacion almacenada en un array.*/
            //
            string[] materialesProductos = {"Cristal", "Madera", "Plastico", "Metal", "Papel" };            
            cmbbMaterialProucto.Items.AddRange(materialesProductos);       
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
        /*en este evento enter, cuando el usuario tenga el mouse encima de la casilla Destinatio 
         al exprtesion destinatario se borrara*/
        //
        private void txtbDestinatario_Enter(object sender, EventArgs e)
        {
            if (txtbDestinatario.Text == "DESTINATARIO")
            {
                txtbDestinatario.Text = "";
                txtbDestinatario.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento LEAVE, cuando el usuario aleje el mouse de la casilla Destinatio 
         al exprtesion destinatario se vera otra vez*/
        //
        private void txtbDestinatario_Leave(object sender, EventArgs e)
        {
            if (txtbDestinatario.Text == "")
            {
                txtbDestinatario.Text = "DESTINATARIO";
                txtbDestinatario.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento ENTER, cuando el usuario acerque el mouse de la casilla Direccion
          la expresion DIrreccion se vera vacia*/
        //
        private void txtbDireccion_Enter(object sender, EventArgs e)
        {
            if (txtbDireccion.Text == "DIRRECCION")
            {
                txtbDireccion.Text = "";
                txtbDireccion.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento leave, cuando el usuario aleje el mouse de la casilla Direccion
         la expresion DIrreccion se vera */
        //
        private void txtbDireccion_Leave(object sender, EventArgs e)
        {
            if (txtbDireccion.Text == "")
            {
                txtbDireccion.Text = "DIRRECCION";
                txtbDireccion.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento ENTER, cuando el usuario acerque el mouse de la casilla CODIGO POSTAL
          la expresion CODE se vera vacia*/
        //
        private void txtbCodePostal_Enter(object sender, EventArgs e)
        {
            if (txtbCodePostal.Text == "CODE")
            {
                txtbCodePostal.Text = "";
                txtbCodePostal.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento leave, cuando el usuario aleje el mouse de la casilla CODIGO POSTAL
         la expresion CODE se vera  */
        //
        private void txtbCodePostal_Leave(object sender, EventArgs e)
        {
            if (txtbCodePostal.Text == "")
            {
                txtbCodePostal.Text = "CODE";
                txtbCodePostal.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento ENTER, cuando el usuario acerque el mouse de la casilla NUMERO TELEFONICO
          la expresion telefono se vera vacia*/
        //
        private void txtbNumeroTelefonico_Enter(object sender, EventArgs e)
        {
            if (txtbNumeroTelefonico.Text == "TELEFONO")
            {
                txtbNumeroTelefonico.Text = "";
                txtbNumeroTelefonico.ForeColor = Color.Black;
            }

        }
        //
        /*en este evento leave, cuando el usuario aleje el mouse de la casilla NUMERO TELEFONICO
         la expresion TELEFONO se vera  */
        //
        private void txtbNumeroTelefonico_Leave(object sender, EventArgs e)
        {
            if (txtbNumeroTelefonico.Text == "")
            {
                txtbNumeroTelefonico.Text = "TELEFONO";
                txtbNumeroTelefonico.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento ENTER, cuando el usuario acerque el mouse de la casilla EMAIL
          la expresion E-MAIL se vera vacia*/
        //
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "E-MAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }
        //
        /*en este evento leave, cuando el usuario aleje el mouse de la casilla NUMERO EMAIL
         la expresion E-MAIL se vera  */
        //
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "E-MAIL";
                txtEmail.ForeColor = Color.Black;
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
        /*este evento impedira que en el textBox destinatario se ingrese caracteres numericos*/
        //
        private void txtbDestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo1.bloqueoLetras(e);
        }
        //
        /*este evento impedira que en el textBox numero telefonico se ingrese caracteres alfabeticos.*/
        //
        private void txtbNumeroTelefonico_KeyPress(object sender, KeyPressEventArgs e)
        {
            bloqueo1.bloqueoNumeros(e);
        }
        //
        /*este evento nos permitira guardar lo que ingresemos en el form ventanaP en la base de datos*/
        //
        private void btnVentanaPAceptar_Click(object sender, EventArgs e)
        {
            conetar.abrir();
            try
            {
                string cadena01 = "insert into [producto] ([material],[apellido], [peso])+" +
                " values ('" + txtbNombreProducto.Text + "','" + cmbbMaterialProucto.Text + "','" + txtbPesomaterial.Text + ")";
                SqlCommand realizar = new SqlCommand(cadena01, conetar01);
                MessageBox.Show("logramos insertando datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("fallamos insertando datos" + ex.Message);
            }

            try
            {
                string cadena01 = "insert into [destinatario] ([destinatario],[dirreccion],[codigoPostal],[telefono],[email]) " +
                    " values ('"+txtbDestinatario.Text+"','"+txtbDireccion.Text+"','"+txtbCodePostal.Text+"','"+txtbNumeroTelefonico+"','"+txtEmail.Text+"')";
                SqlCommand realizar = new SqlCommand(cadena01, conetar01);
                MessageBox.Show("logramos insertando datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("fallamos insertando datos" + ex.Message);
            }


        }
    }
}
