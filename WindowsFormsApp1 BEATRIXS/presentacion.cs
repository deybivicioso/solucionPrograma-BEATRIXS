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
    public partial class presentacion : Form
    {
       
        public presentacion()
        {
            InitializeComponent();           
            
        }
        //
        /*evento: cuando inicie la aplicacion el timer que controla la barra de carga iniciara
         * tambien*/
        //
        private void presentacion_Load(object sender, EventArgs e)
        {            
            tmrPresentacion.Start();
        }
        //
        /*evento:cuando la aplicacion sea cerrada el timer de la barra de carga
         * se detendra*/
        //
        private void presentacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrPresentacion.Stop();           
        }
        //
        /*evento: controla la carga de la barra de carga, esta debe llegar al 100% tambien
         * detendra el timer que controla la barra de carga*/
        //
        private void tmrPresentacion_Tick(object sender, EventArgs e)
        {
            if (prgrbCarga.Value < 100) {
                prgrbCarga.Value++;
                lblPocertajeCarga.Text = prgrbCarga.Value.ToString();
            }

            if (prgrbCarga.Value == 100) {
                tmrPresentacion.Stop();            
                this.Close();                   

            }          
            
        }
        //
        /*con este evento el boton cerrar, podra cerrar la aplicacion*/
        //
        private void pctrbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        /*con este evento configuramos el boton minimizar, para que cumpla su funcion.*/
        //
        private void pctrbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
