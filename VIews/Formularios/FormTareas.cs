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
    public partial class FormTareas : Form
    {
        TareaController tareaController = new TareaController();
        



        public FormTareas()
        {
            InitializeComponent();


            cargarListaProyectos();
            cargarListaEmpleados();
            cargarListaUsuarios();
            cargarLista();//cargar el dataGridView

            
        }

        public void cargarListaProyectos()
        {
            ProyectoController controller = new ProyectoController();   
            this.cmbProyecto.DataSource = controller.ListarProyectosOpcion("%");
            this.cmbProyecto.ValueMember = "IdProyecto";//el valor que se selecciona
            this.cmbProyecto.DisplayMember = "Nombre";//el valor que se mostrara en la vista
        }

        public void cargarListaEmpleados()
        {
            EmpleadoController controller = new EmpleadoController();
            this.cmbEmpleado.DataSource = controller.ListarEmpleadosActivos("%");
            this.cmbEmpleado.ValueMember = "IdEmpleado";//el valor que se selecciona
            this.cmbEmpleado.DisplayMember = "Apellido";//el valor que se mostrara en la vista
        }

        public void cargarListaUsuarios()
        {
            UsuarioController controller = new UsuarioController();
            this.cmbAdministrador.DataSource = controller.ListarUsuariosActivos("%");
            this.cmbAdministrador.ValueMember = "IdUsuario";//el valor que se selecciona
            this.cmbAdministrador.DisplayMember = "Apellido";//el valor que se mostrara en la vista
        }

        public void cargarLista()
        {
            this.dgvTareas.DataSource = tareaController.ListarTareas("%");
        }

        public void limpiarCampos()
        {
            this.txtIdTarea.Text = "";
            this.txtNombre.Text = "";
            this.txtDescripcion.Text = "";
            this.dtpFechaInicio.Text = "";
            this.dtpFechaVencimiento.Text = "";
            this.cmbPrioridad.SelectedIndex = -1; 
            this.cmbEmpleado.SelectedIndex = -1;
            this.cmbAdministrador.SelectedIndex = -1;
            this.cmbProyecto.SelectedIndex = -1;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text != "")
                {
                    String Rpta = "";
                    Tarea nuevaTarea = new Tarea();
                    nuevaTarea.Nombre = this.txtNombre.Text;
                    nuevaTarea.Descripcion = this.txtDescripcion.Text;
                    nuevaTarea.FechaInicio = this.dtpFechaInicio.Value;
                    nuevaTarea.FechaVencimiento = this.dtpFechaVencimiento.Value;
                    nuevaTarea.Prioridad = this.cmbPrioridad.Text;
                    nuevaTarea.IdEmpleado = int.Parse(this.cmbEmpleado.SelectedValue.ToString());
                    nuevaTarea.IdUsuario = int.Parse(this.cmbAdministrador.SelectedValue.ToString());
                    nuevaTarea.IdProyecto = int.Parse(this.cmbProyecto.SelectedValue.ToString());

                    Rpta = tareaController.CrearTarea(nuevaTarea);

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
            try
            {
                if (this.txtIdTarea.Text != "")
                {
                    string Rpta = "";
                    Tarea tra = new Tarea();
                    tra.IdTarea = int.Parse(this.txtIdTarea.Text);
                    tra.Nombre = this.txtNombre.Text;
                    tra.Descripcion = this.txtDescripcion.Text;
                    tra.FechaInicio = this.dtpFechaInicio.Value;
                    tra.FechaVencimiento = this.dtpFechaVencimiento.Value;
                    tra.Prioridad = this.cmbPrioridad.Text;
                    tra.IdEmpleado = int.Parse(this.cmbEmpleado.SelectedValue.ToString());
                    tra.IdUsuario = int.Parse(this.cmbAdministrador.SelectedValue.ToString());
                    tra.IdProyecto = int.Parse(this.cmbProyecto.SelectedValue.ToString());


                    Rpta = tareaController.EditarTarea(tra);

                    if (Rpta.Equals("OK"))
                    {
                        MensajeBox m = new MensajeBox("Actualizo", "El Proyecto: " + tra.Nombre);
                        DialogResult dg = m.ShowDialog();

                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(Rpta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    cargarLista();

                }
                else
                {
                    MessageBox.Show("Debe Seleccionar una Tarea", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIdTarea.Text != "")
                {
                    var rta = tareaController.EliminarTarea(int.Parse(this.txtIdTarea.Text));
                    if (rta.Equals("OK"))
                    {
                        MensajeBox m = new MensajeBox("Eliminó", "La Tarea: " + this.txtNombre.Text );
                        DialogResult dg = m.ShowDialog();
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(rta,
                                        "Aviso del Sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    cargarLista();
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar Una Tarea para eliminar", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar registro: " + ex.StackTrace,
                    "Error");
            }
        }

        private void dgvTareas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvTareas.CurrentRow != null)
                {
                    int idTarea = int.Parse(this.dgvTareas.CurrentRow.Cells[0].Value.ToString());
                    this.txtIdTarea.Text = this.dgvTareas.CurrentRow.Cells[0].Value.ToString();
                    this.txtNombre.Text = this.dgvTareas.CurrentRow.Cells[1].Value.ToString();
                    this.txtDescripcion.Text = this.dgvTareas.CurrentRow.Cells[2].Value.ToString();
                    this.dtpFechaInicio.Value = (DateTime)this.dgvTareas.CurrentRow.Cells[3].Value;
                    this.dtpFechaVencimiento.Value = (DateTime)this.dgvTareas.CurrentRow.Cells[4].Value;
                    //this.lblNroTareas.Text = this.dgvTareas.CurrentRow.Cells[5].Value.ToString();
                    this.cmbPrioridad.Text = this.dgvTareas.CurrentRow.Cells[6].Value.ToString();
                    

                    this.dgvUsuario.DataSource = tareaController.ListarUsuarioPorTarea(idTarea);
                    this.dgvEmpleado.DataSource = tareaController.ListarEmpleadoPorTarea(idTarea);
                    this.dgvProyecto.DataSource = tareaController.ListarProyectoPorTarea(idTarea);

                    this.cmbEmpleado.Text = this.dgvTareas.CurrentRow.Cells[7].Value.ToString();
                    this.cmbAdministrador.Text = this.dgvTareas.CurrentRow.Cells[8].Value.ToString();
                    this.cmbProyecto.SelectedValue = this.dgvTareas.CurrentRow.Cells[9].Value.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void cmbProyecto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbProyecto.SelectedValue.ToString() != null)
                {
                    int idProyecto = int.Parse(cmbProyecto.SelectedValue.ToString());
                    int numTareas = tareaController.ObtenerTareasPorProyecto(idProyecto);
                    this.lblNroTareas.Text = Convert.ToString(numTareas);

                    if (numTareas == 10)
                    {
                        this.btnGuardar.Enabled = false;
                        this.lblMensaje.Visible = true;
                    }
                    else
                    {
                        this.btnGuardar.Enabled = true;
                        this.lblMensaje.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gunaGroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //caundo haga click en una columna que no sea la de op
                if (e.RowIndex < 0 || e.ColumnIndex != dgvTareas.Columns["op"].Index)
                {
                    return;
                }
                else
                {
                    var idTarea = int.Parse(this.dgvTareas.CurrentRow.Cells[0].Value.ToString());
                    
                    this.dgvUsuario.DataSource = tareaController.ListarUsuarioPorTarea(idTarea);
                    this.dgvEmpleado.DataSource = tareaController.ListarEmpleadoPorTarea(idTarea);
                    this.dgvProyecto.DataSource = tareaController.ListarProyectoPorTarea(idTarea);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
