using Controller;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIews.Formularios
{
    public partial class FormParaEmpleado : Form
    {
        TareaController tareaController = new TareaController();


        public FormParaEmpleado()
        {
            InitializeComponent();
            cargarDatosDeEmpleadoLogueado();
            cargarLista();
        }

        public void cargarLista()
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorEmpleado(EmpleadoCache.IdEmpleado);
        }

        //convertir byte[] a Imagen
        private Image byteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);//automaticamente obtiene la inf
            Image foto = Image.FromStream(ms);
            return foto;
        }

        public void cargarDatosDeEmpleadoLogueado()
        {
            this.lblNombreEmpleado.Text = EmpleadoCache.Nombre;
            this.lblApellido.Text = EmpleadoCache.Apellido;
            this.lblRol.Text = EmpleadoCache.Role;
            this.pbxFoto.Image = byteToImage(EmpleadoCache.Foto);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = null;
        }

        private void gunaRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void rbtnSinFiltro_CheckedChanged(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void rbtnNoIniciado_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorEstado(EmpleadoCache.IdEmpleado, "No iniciado");
        }

        private void rbtnEnProceso_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorEstado(EmpleadoCache.IdEmpleado, "En proceso");
        }

        private void rbtnFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorEstado(EmpleadoCache.IdEmpleado, "Finalizado");
        }

        private void rbtnVencimiento_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorVencimiento(EmpleadoCache.IdEmpleado);
        }

        private void rbtnBaja_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorPrioridad(EmpleadoCache.IdEmpleado, "BAJA");
        }

        private void rbtnNormal_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorPrioridad(EmpleadoCache.IdEmpleado, "NORMAL");
        }

        private void rbtnUrgente_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorPrioridad(EmpleadoCache.IdEmpleado, "URGENTE");
        }

        private void rbtnCritico_CheckedChanged(object sender, EventArgs e)
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorPrioridad(EmpleadoCache.IdEmpleado, "CRITICA");
        }
    }
}
