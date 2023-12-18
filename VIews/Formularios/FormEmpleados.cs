using Controller;
using Entities;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIews.Formularios
{
    public partial class FormEmpleados : Form
    {
        EmpleadoController empleadoController = new EmpleadoController();

        public FormEmpleados()
        {
            InitializeComponent();
            cargarLista();
        }

        public void cargarLista()
        {
            this.dgvEmpleados.DataSource = empleadoController.ListarEmpleadosOpcion("%");
        }

        //Convertir Imagen a Vector de byts
        private byte[] imageToBytes(PictureBox foto)//es diferente al pbxFoto de la vista
        {
            MemoryStream ms = new MemoryStream();
            foto.Image.Save(ms, ImageFormat.Jpeg);
            byte[] imagenbyte = ms.ToArray();
            return imagenbyte;
        }

        //convertir byte[] a Imagen
        private Image byteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes);//automaticamente obtiene la inf
            Image foto = Image.FromStream(ms);
            return foto;
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen JPG y PNG|*.jpg;*.png|PNG(*.png)|*.png|All Files(*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Seleccione Imagen para el Articulo";

            DialogResult rs = openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                this.pbxFoto.BackgroundImage = null;
                //  direImagen = openFileDialog.FileName.ToString();
                // nombreImagen = System.IO.Path.GetFileName(direImagen);

                this.pbxFoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        public void limpiarCampos()
        {
            this.txtIdEmpleado.Text = "";
            this.txtDni.Text = "";
            this.txtApellido.Text = "";
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtLoginName.Text = "";
            this.txtPassword.Text = "";
            this.chkEstado.Checked = false;
            this.dtpFechaNacimiento.Text = "";
            this.cmbRole.SelectedIndex = -1;
            this.cmbHabilidad.SelectedIndex = -1;
            this.pbxFoto.Image = null;
            //this.btnGuardar.Enabled = true;
            // this.btnEditar.Enabled = false;
        }


        //metodo para cambiar el color del checkbox
        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEstado.Checked == true)
            {
                this.chkEstado.Text = "Activo";
                this.chkEstado.ForeColor = Color.Green;
            }
            else
            {
                this.chkEstado.Text = "Inactivo";
                this.chkEstado.ForeColor = Color.Red;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text != "")
                {
                    String Rpta = "";
                    Empleado nuevoEmpleado = new Empleado();
                    nuevoEmpleado.Dni = this.txtDni.Text;
                    nuevoEmpleado.Apellido = this.txtApellido.Text;
                    nuevoEmpleado.Nombre = this.txtNombre.Text;
                    nuevoEmpleado.Role = this.cmbRole.Text;
                    nuevoEmpleado.Telefono = this.txtTelefono.Text;
                    nuevoEmpleado.FechaNacimiento = this.dtpFechaNacimiento.Value;
                    nuevoEmpleado.LoginName = this.txtLoginName.Text;
                    nuevoEmpleado.Password = this.txtPassword.Text;
                    nuevoEmpleado.Estado = this.chkEstado.Checked;
                    nuevoEmpleado.Habilidad = this.cmbHabilidad.Text;
                    nuevoEmpleado.Foto = imageToBytes(this.pbxFoto);//enviar imagen a DB



                    Rpta = empleadoController.CrearEmpleado(nuevoEmpleado);

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIdEmpleado.Text != "")
                {
                    string Rpta = "";
                    Empleado em = new Empleado();
                    em.IdEmpleado = int.Parse(this.txtIdEmpleado.Text);
                    em.Dni = this.txtDni.Text;
                    em.Nombre = this.txtNombre.Text;
                    em.Apellido = this.txtApellido.Text;
                    em.Role = this.cmbRole.Text;
                    em.Telefono = this.txtTelefono.Text;
                    em.FechaNacimiento = this.dtpFechaNacimiento.Value;
                    em.LoginName = this.txtLoginName.Text;
                    em.Password = this.txtPassword.Text;
                    em.Estado = this.chkEstado.Checked;
                    em.Habilidad = this.cmbHabilidad.Text;
                    em.Foto = imageToBytes(this.pbxFoto);

                    Rpta = empleadoController.EditarEmpleado(em);

                    if (Rpta.Equals("OK"))
                    {
                        MensajeBox m = new MensajeBox("Actualizo", "El Empleado " + em.Nombre + " " + em.Apellido);
                        DialogResult dg = m.ShowDialog();

                        //cargarLista();
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
                    MessageBox.Show("Debe Seleccionar Fotografia", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving the file." +
                    "Check the file permissions.");
            }
        }

        private void dgvEmpleados_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEmpleados.CurrentRow != null)
                {
                    this.txtIdEmpleado.Text = this.dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                    this.txtDni.Text = this.dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                    this.txtApellido.Text = this.dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                    this.txtNombre.Text = this.dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                    this.cmbRole.Text = this.dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                    this.txtTelefono.Text = this.dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                    this.dtpFechaNacimiento.Value = (DateTime)this.dgvEmpleados.CurrentRow.Cells[6].Value;
                    this.txtLoginName.Text = this.dgvEmpleados.CurrentRow.Cells[7].Value.ToString();
                    this.txtPassword.Text = this.dgvEmpleados.CurrentRow.Cells[8].Value.ToString();
                    this.chkEstado.Checked = this.dgvEmpleados.CurrentRow.Cells[9].Value.ToString() == "1" ? true : false;
                    this.cmbHabilidad.Text = this.dgvEmpleados.CurrentRow.Cells[10].Value.ToString();
                    this.pbxFoto.Image = byteToImage((byte[])(this.dgvEmpleados.CurrentRow.Cells[11].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //caundo haga click en una columna que no sea la de opEliminar
                if (e.RowIndex < 0 || e.ColumnIndex != dgvEmpleados.Columns["opEliminar"].Index)
                {
                    return;
                }
                else
                {
                    var idEmpleado = int.Parse(this.dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
                    int nroTareas = empleadoController.ObtenerTotalTareasPorEmpleado(idEmpleado);
                    

                    if(nroTareas == 0)
                    {
                        DialogResult res = MessageBox.Show("Estas Seguro de querer Eliminar", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        String Rpta = "";

                        if (res == DialogResult.OK)
                        {
                            Rpta = empleadoController.EliminarEmpleado(idEmpleado);
                            if (Rpta.Equals("OK"))
                            {

                                MensajeBox m = new MensajeBox("Elimino", "El Empleado " + this.dgvEmpleados.CurrentRow.Cells[2].Value.ToString());
                                DialogResult dg = m.ShowDialog();

                                limpiarCampos();
                                cargarLista();
                            }
                            else
                            {
                                MessageBox.Show(Rpta, "Aviso de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El empleado tiene tareas", "No se puede borrar");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
