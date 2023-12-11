using Controller;
using Entities;
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
    public partial class FormProyectos : Form
    {
        ProyectoController proyectoController = new ProyectoController();

        public FormProyectos()
        {
            InitializeComponent();
            cargarLista();
        }

        public void cargarLista()
        {
            this.dgvProyectos.DataSource = proyectoController.ListarProyectosOpcion("%");
        }

        public void limpiarCampos()
        {
            this.txtIdProyecto.Text = "";
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.dtpFechaInicio.Text = "";
            this.dtpFechaFinalizacion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text != "" )
                {
                    String Rpta = "";
                    Proyecto nuevoProyecto = new Proyecto();
                    nuevoProyecto.Nombre = this.txtNombre.Text;
                    nuevoProyecto.Descripcion = this.txtDescripcion.Text;
                    nuevoProyecto.FechaInicio = this.dtpFechaInicio.Value;
                    nuevoProyecto.FechaFinalizacion = this.dtpFechaFinalizacion.Value;
                 
                    Rpta = proyectoController.CrearEmpleado(nuevoProyecto);

                    if (Rpta.Equals("OK"))
                    {
                        MessageBox.Show("Los datos han sido guardados correctamente", "Aviso de sistema", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        cargarLista();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(Rpta, "Aviso de sistema", MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe Ingresar Datos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
