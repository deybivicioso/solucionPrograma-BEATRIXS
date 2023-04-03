using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_BEATRIXS
{
    internal class funcionesSistemas
    {
      
        //
        /*este metodo nos permitira bloquear en las casillas cualquier valor que no sea alfabetico.
         lo debemos usar en los textBox enlos que queremos que el usuario solo ingrese letras. */
        //
        public void bloqueoLetras(KeyPressEventArgs e) {
            if (Char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { 
                e.Handled = true;
                MessageBox.Show("solo caracteres alfabeticos", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
            }
        }
        //
        /*este metedo nos permite bloquea la entrada de cualquier caracter que no sea numerico
         en los textBox en los que deseemos aplicar dicho metodo.*/
        //
        public void bloqueoNumeros(KeyPressEventArgs e) {
            if (Char.IsNumber(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo caracteres numericos", "advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
