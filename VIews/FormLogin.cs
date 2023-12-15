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
using VIews.Formularios;

namespace VIews
{
    public partial class FormLogin : Form
    {
        UsuarioController usuarioController = new UsuarioController();
        EmpleadoController empleadoController = new EmpleadoController();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //verifico que los campos no esten vacios
                if (this.txtLoginName.Text != "LoginName" || this.txtPassword.Text != "Password")
                {
                    var validarUsuario = usuarioController.LoginUsuario(this.txtLoginName.Text, this.txtPassword.Text);
                    var validarEmpleado = empleadoController.LoginEmpleado(this.txtLoginName.Text, this.txtPassword.Text);

                    if (validarUsuario)
                    {
                        Form1 formUsuarios = new Form1();

                        MensajeBox m = new MensajeBox("Ingreso", "El Usuario " + UsuarioCache.LoginName);
                        DialogResult dg = m.ShowDialog();

                        formUsuarios.Show();
                        formUsuarios.FormClosed += Logout;
                        this.Hide();
                    }
                    else if (validarEmpleado)
                    {
                        FormParaEmpleado formParaEmpleado = new FormParaEmpleado();
                        MensajeBox m = new MensajeBox("Ingreso", "El empleado " + EmpleadoCache.LoginName);
                        DialogResult dg = m.ShowDialog();

                        formParaEmpleado.Show();
                        formParaEmpleado.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error Datos ingresados Incorrectos");
                    }
                }
                else
                {   
                    MessageBox.Show("Debe Ingresar Sus Datos");
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }


        //Efecto placeHolder en los TextBox's
        //1ro LoginName
        private void txtLoginName_Enter(object sender, EventArgs e)
        {
            if(this.txtLoginName.Text == "LoginName")
            {
                this.txtLoginName.Text = "";
                this.txtLoginName.ForeColor = Color.Black;
            }
        }

        private void txtLoginName_Leave(object sender, EventArgs e)
        {
            if (this.txtLoginName.Text == "")
            {
                this.txtLoginName.Text = "LoginName";
                this.txtLoginName.ForeColor = Color.Silver;
            }
        }

        //2do Password
        private void txtPassword_Enter(object sender, EventArgs e)
        { 
            if (this.txtPassword.Text == "Password")
            {
                this.txtPassword.Text = "";
                this.txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                this.txtPassword.Text = "Password";
                this.txtPassword.ForeColor = Color.Black;
            }
        }

        private void Logout(object sender, EventArgs e)
        {
            try
            { 
                this.txtPassword.Text = "Password";
                this.txtPassword.ForeColor = Color.Silver;   
                this.txtLoginName.Text = "LoginName";
                this.txtLoginName.ForeColor = Color.Silver;
               
                this.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.StackTrace);
            }
        }
    }
}
