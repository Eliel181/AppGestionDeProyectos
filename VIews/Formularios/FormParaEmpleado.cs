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
        int idTarea = 0; //esta variable se usara para modificar el estado de una tarea


        public FormParaEmpleado()
        {
            InitializeComponent();
            cargarDatosDeEmpleadoLogueado();
            cargarLista();
            deshabilitarBotones();
        }

        public void cargarLista()
        {
            this.dgvTareasDeEmpleado.DataSource = tareaController.ListarTareasPorEmpleado(EmpleadoCache.IdEmpleado);
        }

        public void limpiarCampos()
        {
            this.lblIdTarea.Text = ".....";
            this.lblNombre.Text = ".....";
            this.lblDescripcion.Text = ".....";
            this.lblFechaInicio.Text = ".....";
            this.lblFechaVencimiento.Text = ".....";
            this.lblEstado.Text = ".....";
            this.lblPrioridad.Text = ".....";
            this.lblProyecto.Text = ".....";

            deshabilitarBotones();
        }

        public void deshabilitarBotones()
        {
            this.btnNoIniciado.Enabled = false;
            this.btnEnProceso.Enabled = false;
            this.btnFinalizado.Enabled = false;
        }
        public void habilitarBotones()
        {
            this.btnNoIniciado.Enabled = true;
            this.btnEnProceso.Enabled = true;
            this.btnFinalizado.Enabled = true;
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

        //botones para actualizar el estado de una tarea

        private void btnNoIniciado_Click(object sender, EventArgs e)
        {
            if (idTarea != 0)
            {
                tareaController.ActualizarEstadoDeTarea(idTarea, "No iniciado");
                MensajeBox m = new MensajeBox("Actualizo", "El estado de la Tarea");
                DialogResult dg = m.ShowDialog();
                limpiarCampos();
                cargarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una tarea");
            }
        }

        private void btnEnProceso_Click(object sender, EventArgs e)
        {
            if (idTarea != 0)
            {
                tareaController.ActualizarEstadoDeTarea(idTarea, "En proceso");
                MensajeBox m = new MensajeBox("Actualizo", "El estado de la Tarea" );
                DialogResult dg = m.ShowDialog();

                limpiarCampos();
                cargarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una tarea");
            }
        }

        private void btnFinalizado_Click(object sender, EventArgs e)
        {
            if (idTarea != 0)
            {
                tareaController.ActualizarEstadoDeTarea(idTarea, "Finalizado");
                MensajeBox m = new MensajeBox("Actualizo", "El estado de la Tarea");
                DialogResult dg = m.ShowDialog();
                limpiarCampos();
                cargarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una tarea");
            }
        }

        private void dgvTareasDeEmpleado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvTareasDeEmpleado.CurrentRow != null)
                {
                    idTarea = int.Parse(this.dgvTareasDeEmpleado.CurrentRow.Cells[0].Value.ToString());
                    this.lblIdTarea.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[0].Value.ToString();
                    this.lblNombre.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[1].Value.ToString();
                    this.lblDescripcion.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[2].Value.ToString();
                    this.lblFechaInicio.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[3].Value.ToString();
                    this.lblFechaVencimiento.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[4].Value.ToString();
                    this.lblEstado.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[5].Value.ToString();
                    this.lblPrioridad.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[6].Value.ToString();
                    this.lblProyecto.Text = this.dgvTareasDeEmpleado.CurrentRow.Cells[7].Value.ToString();
                    habilitarBotones();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
