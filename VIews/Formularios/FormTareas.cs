﻿using Controller;
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
            this.cmbEmpleado.DataSource = controller.ListarEmpleados("%");
            this.cmbEmpleado.ValueMember = "IdEmpleado";//el valor que se selecciona
            this.cmbEmpleado.DisplayMember = "AyN";//el valor que se mostrara en la vista
        }

        public void cargarListaUsuarios()
        {
            UsuarioController controller = new UsuarioController();
            this.cmbAdministrador.DataSource = controller.ListarUsuarios("%");
            this.cmbAdministrador.ValueMember = "IdUsuario";//el valor que se selecciona
            this.cmbAdministrador.DisplayMember = "AyN";//el valor que se mostrara en la vista
        }

        public void cargarLista()
        {
            this.dgvTareas.DataSource = tareaController.ListarTareas("%");
        }

        public void limpiarCampos()
        {

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

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
