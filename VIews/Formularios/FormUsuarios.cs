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
    public partial class FormUsuarios : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        public FormUsuarios()
        {
            InitializeComponent();
            cargarLista();
        }

        public void cargarLista()
        {
            this.dgvUsuarios.DataSource = usuarioController.ListarUsuariosOpcion("%");
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
                //this.pbxFoto.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        public void limpiarCampos()
        {
            this.txtIdUsuario.Text = "";
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
            //this.btnEliminar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNombre.Text != "")
                {
                    String Rpta = "";
                    Usuario nuevoUsuario = new Usuario();
                    nuevoUsuario.Dni = this.txtDni.Text;
                    nuevoUsuario.Apellido = this.txtApellido.Text;
                    nuevoUsuario.Nombre = this.txtNombre.Text;
                    nuevoUsuario.Role = this.cmbRole.Text;
                    nuevoUsuario.Telefono = this.txtTelefono.Text;
                    nuevoUsuario.FechaNacimiento = this.dtpFechaNacimiento.Value;
                    nuevoUsuario.LoginName = this.txtLoginName.Text;
                    nuevoUsuario.Password = this.txtPassword.Text;
                    nuevoUsuario.Estado = this.chkEstado.Checked;
                    nuevoUsuario.Habilidad = this.cmbHabilidad.Text;
                    nuevoUsuario.Foto = imageToBytes(this.pbxFoto);//enviar imagen a DB



                    Rpta = usuarioController.CrearUsuario(nuevoUsuario);

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
                if (this.txtIdUsuario.Text != "")
                {
                    string Rpta = "";
                    Usuario us = new Usuario();
                    us.IdUsuario = int.Parse(this.txtIdUsuario.Text);
                    us.Dni = this.txtDni.Text;
                    us.Nombre = this.txtNombre.Text;
                    us.Apellido = this.txtApellido.Text;
                    us.Role = this.cmbRole.Text;
                    us.Telefono = this.txtTelefono.Text;
                    us.FechaNacimiento = this.dtpFechaNacimiento.Value;
                    us.LoginName = this.txtLoginName.Text;
                    us.Password = this.txtPassword.Text;
                    us.Estado = this.chkEstado.Checked;
                    us.Habilidad = this.cmbHabilidad.Text;
                    us.Foto = imageToBytes(this.pbxFoto);

                    Rpta = usuarioController.EditarUsuario(us);

                    if (Rpta.Equals("OK"))
                    {
                        MensajeBox m = new MensajeBox("Actualizo", "El Usuario: " + us.Nombre + " " + us.Apellido);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUsuarios.CurrentRow != null)
                {
                    this.txtIdUsuario.Text = this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                    this.txtDni.Text = this.dgvUsuarios.CurrentRow.Cells[1].Value.ToString();   
                    this.txtApellido.Text = this.dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                    this.txtNombre.Text = this.dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                    this.cmbRole.Text = this.dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
                    this.txtTelefono.Text = this.dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
                    this.dtpFechaNacimiento.Value = (DateTime)this.dgvUsuarios.CurrentRow.Cells[6].Value;
                    this.txtLoginName.Text = this.dgvUsuarios.CurrentRow.Cells[7].Value.ToString();
                    this.txtPassword.Text = this.dgvUsuarios.CurrentRow.Cells[8].Value.ToString(); 
                    this.chkEstado.Checked = this.dgvUsuarios.CurrentRow.Cells[9].Value.ToString() == "1" ? true : false;
                    this.cmbHabilidad.Text = this.dgvUsuarios.CurrentRow.Cells[10].Value.ToString();
                    this.pbxFoto.Image = byteToImage((byte[])(this.dgvUsuarios.CurrentRow.Cells[11].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //caundo haga click en una columna que no sea la de opEliminar
                if (e.RowIndex < 0 || e.ColumnIndex != dgvUsuarios.Columns["opEliminar"].Index)
                {
                    return;
                }
                else
                {
                    var idUsuario = int.Parse(this.dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                    int nroTareas = usuarioController.ObtenerTotalTareasPorUsuario(idUsuario);
                    
                    if(nroTareas == 0)
                    {
                        DialogResult res = MessageBox.Show("Estas Seguro de querer Eliminar", "Confirmar Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        String Rpta = "";

                        if (res == DialogResult.OK)
                        {
                            Rpta = usuarioController.EliminarUsuario(idUsuario);
                            if (Rpta.Equals("OK"))
                            {

                                MensajeBox m = new MensajeBox("Elimino", "El Usuario " + this.dgvUsuarios.CurrentRow.Cells[2].Value.ToString());
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
                        MessageBox.Show("El usuario tiene tareas", "No se puede borrar");
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
