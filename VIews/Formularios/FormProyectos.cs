using Controller;
using Entities;
using Model;
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
        TareaController tareaController = new TareaController();

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

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //caundo haga click en una columna que no sea la de opEliminar
                if (e.RowIndex < 0 || e.ColumnIndex != dgvProyectos.Columns["Op"].Index)
                {
                    return;
                }
                else
                {
                    var idProyecto = int.Parse(this.dgvProyectos.CurrentRow.Cells[0].Value.ToString());
                    this.dgvListaTareas.DataSource = tareaController.ListarTareasPorProyecto(idProyecto);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        public void mostrarPorcentaje(int idProyecto)
        {
            /*this.dgvPorcentaje.DataSource = proyectoController.ObtenerPorcentajeDeProyecto(idProyecto);
            this.gunaCircleProgressPorcentaje.Value = Convert.ToInt32(this.dgvPorcentaje.Rows[0].Cells[0].Value) ;*/
            int porcentaje = proyectoController.ObtenerPorcentajeDeProyecto(idProyecto);
            this.gunaCircleProgressPorcentaje.Value = porcentaje;
        }

        private void dgvProyectos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProyectos.CurrentRow != null)
                {
                    int idProyecto = int.Parse(this.dgvProyectos.CurrentRow.Cells[0].Value.ToString());
                    this.txtIdProyecto.Text = this.dgvProyectos.CurrentRow.Cells[0].Value.ToString();
                    this.txtNombre.Text = this.dgvProyectos.CurrentRow.Cells[1].Value.ToString();
                    this.txtDescripcion.Text = this.dgvProyectos.CurrentRow.Cells[2].Value.ToString();
                    this.dtpFechaInicio.Value = (DateTime)this.dgvProyectos.CurrentRow.Cells[3].Value;
                    this.dtpFechaFinalizacion.Value = (DateTime)this.dgvProyectos.CurrentRow.Cells[4].Value;
                    mostrarPorcentaje(idProyecto);
               
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
