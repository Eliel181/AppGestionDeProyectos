using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIews.Formularios
{
    public partial class MensajeBox : Form
    {
        public string Accion { get; set; }


        //constructor sin parametros
        public MensajeBox()
        {
            InitializeComponent();
        }

        //constructor con parametros
        public MensajeBox(string accion, string msj)
        {
            this.Accion = accion;
            InitializeComponent();
            if (this.Accion != null)
            {
                this.lblMensaje.Text = $"{msj} se {accion} correctamente!";
            }
            else
            {
                this.lblMensaje.Text = "Error al recibir el mensaje";
            }

        }

        //boton para cerrar 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
