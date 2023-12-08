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
            this.dgvUsuarios.DataSource = usuarioController.ListarUsuarios("%");
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
            //this.btnGuardar.Enabled = true;
           // this.btnEditar.Enabled = false;
            //this.btnEliminar.Enabled = false;
            //this.chkTutorCargado.Checked = false;
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
    }
}
