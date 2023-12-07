using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VIews.Formularios;

namespace VIews
{
    public partial class Form1 : Form
    {
        private Form formularioActualHijo;//contener las ventanas
        private GunaGradientButton botonActual;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActualHijo != null)
            {
                //si el formulario esta vacio lo cerramos
                formularioActualHijo.Close();
            }

            formularioActualHijo = formularioHijo;
            formularioActualHijo.TopLevel = false;
            formularioActualHijo.FormBorderStyle = FormBorderStyle.None;//le quiamos el borde que trae por defecto
            formularioActualHijo.Dock = DockStyle.Fill;//para que rellene todo el panel central
            this.panelCentral.Controls.Add(formularioActualHijo);
            panelCentral.Tag = formularioActualHijo;

            formularioActualHijo.BringToFront();
            formularioActualHijo.Show();
            this.lblTituloDeFormularioHijo.Text = formularioActualHijo.Text;// este sera el titulo del formulario
        }

        public void DesactivarBoton()
        {
            if (botonActual != null)
            {
                botonActual.BaseColor1 = Color.Transparent;
                botonActual.BaseColor2 = Color.Transparent;
            }
        }

        public void ActivarBoton(object sender)
        {
            //desactivamos el boton que se halla activado previamente
            DesactivarBoton();
            botonActual = (GunaGradientButton)sender;//transformo el sender a un boton guna y lo almaceno en boton actual
            botonActual.BaseColor1 = Color.MediumSeaGreen;
            botonActual.BaseColor2 = Color.Lime;
        }

        private void btnProyectos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new FormProyectos());
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new FormTareas());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new FormEmpleados());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new FormUsuarios());
        }
    }
}
