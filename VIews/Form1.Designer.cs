namespace VIews
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelDrag = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.panelCentral = new Guna.UI.WinForms.GunaElipsePanel();
            this.panelSuperior = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblNyADelUsuarioActual = new System.Windows.Forms.Label();
            this.lblRoleUsuarioActual = new System.Windows.Forms.Label();
            this.pbxFotoUsuarioActual = new Guna.UI.WinForms.GunaPictureBox();
            this.lblTituloDeFormularioHijo = new System.Windows.Forms.Label();
            this.panelBotones = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnLogout = new Guna.UI.WinForms.GunaGradientButton();
            this.btnEmpleados = new Guna.UI.WinForms.GunaGradientButton();
            this.btnTareas = new Guna.UI.WinForms.GunaGradientButton();
            this.btnUsuarios = new Guna.UI.WinForms.GunaGradientButton();
            this.btnProyectos = new Guna.UI.WinForms.GunaGradientButton();
            this.panelDrag.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoUsuarioActual)).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.Black;
            this.panelDrag.Controls.Add(this.panel1);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(1000, 34);
            this.panelDrag.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(839, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 34);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.AnimationHoverSpeed = 0.07F;
            this.btnCerrar.AnimationSpeed = 0.03F;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BaseColor1 = System.Drawing.Color.Crimson;
            this.btnCerrar.BaseColor2 = System.Drawing.Color.Red;
            this.btnCerrar.BorderColor = System.Drawing.Color.Black;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.FocusedColor = System.Drawing.Color.Empty;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = global::VIews.Properties.Resources.cerrarX;
            this.btnCerrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCerrar.Location = new System.Drawing.Point(113, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBaseColor1 = System.Drawing.Color.Gold;
            this.btnCerrar.OnHoverBaseColor2 = System.Drawing.Color.Yellow;
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnCerrar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnHoverImage = null;
            this.btnCerrar.OnPressedColor = System.Drawing.Color.Black;
            this.btnCerrar.Radius = 10;
            this.btnCerrar.Size = new System.Drawing.Size(36, 31);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panelDrag;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.panelCentral);
            this.gunaGradientPanel1.Controls.Add(this.panelSuperior);
            this.gunaGradientPanel1.Controls.Add(this.panelBotones);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.DarkOrchid;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.Indigo;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 34);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1000, 530);
            this.gunaGradientPanel1.TabIndex = 1;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.Transparent;
            this.panelCentral.BaseColor = System.Drawing.Color.Transparent;
            this.panelCentral.Location = new System.Drawing.Point(64, 83);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Radius = 10;
            this.panelCentral.Size = new System.Drawing.Size(924, 435);
            this.panelCentral.TabIndex = 4;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.Transparent;
            this.panelSuperior.BaseColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.lblNyADelUsuarioActual);
            this.panelSuperior.Controls.Add(this.lblRoleUsuarioActual);
            this.panelSuperior.Controls.Add(this.pbxFotoUsuarioActual);
            this.panelSuperior.Controls.Add(this.lblTituloDeFormularioHijo);
            this.panelSuperior.Location = new System.Drawing.Point(64, 6);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Radius = 10;
            this.panelSuperior.Size = new System.Drawing.Size(924, 71);
            this.panelSuperior.TabIndex = 3;
            // 
            // lblNyADelUsuarioActual
            // 
            this.lblNyADelUsuarioActual.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNyADelUsuarioActual.Location = new System.Drawing.Point(544, 34);
            this.lblNyADelUsuarioActual.Name = "lblNyADelUsuarioActual";
            this.lblNyADelUsuarioActual.Size = new System.Drawing.Size(258, 21);
            this.lblNyADelUsuarioActual.TabIndex = 3;
            this.lblNyADelUsuarioActual.Text = "NyA";
            this.lblNyADelUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRoleUsuarioActual
            // 
            this.lblRoleUsuarioActual.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleUsuarioActual.Location = new System.Drawing.Point(608, 9);
            this.lblRoleUsuarioActual.Name = "lblRoleUsuarioActual";
            this.lblRoleUsuarioActual.Size = new System.Drawing.Size(194, 21);
            this.lblRoleUsuarioActual.TabIndex = 2;
            this.lblRoleUsuarioActual.Text = "Role";
            this.lblRoleUsuarioActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbxFotoUsuarioActual
            // 
            this.pbxFotoUsuarioActual.BackColor = System.Drawing.Color.Transparent;
            this.pbxFotoUsuarioActual.BaseColor = System.Drawing.Color.White;
            this.pbxFotoUsuarioActual.Image = global::VIews.Properties.Resources._default;
            this.pbxFotoUsuarioActual.Location = new System.Drawing.Point(825, 0);
            this.pbxFotoUsuarioActual.Name = "pbxFotoUsuarioActual";
            this.pbxFotoUsuarioActual.Radius = 10;
            this.pbxFotoUsuarioActual.Size = new System.Drawing.Size(99, 71);
            this.pbxFotoUsuarioActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFotoUsuarioActual.TabIndex = 1;
            this.pbxFotoUsuarioActual.TabStop = false;
            // 
            // lblTituloDeFormularioHijo
            // 
            this.lblTituloDeFormularioHijo.AutoSize = true;
            this.lblTituloDeFormularioHijo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDeFormularioHijo.Location = new System.Drawing.Point(25, 20);
            this.lblTituloDeFormularioHijo.Name = "lblTituloDeFormularioHijo";
            this.lblTituloDeFormularioHijo.Size = new System.Drawing.Size(87, 32);
            this.lblTituloDeFormularioHijo.TabIndex = 0;
            this.lblTituloDeFormularioHijo.Text = "Titulo";
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.BaseColor = System.Drawing.Color.White;
            this.panelBotones.Controls.Add(this.btnLogout);
            this.panelBotones.Controls.Add(this.btnEmpleados);
            this.panelBotones.Controls.Add(this.btnTareas);
            this.panelBotones.Controls.Add(this.btnUsuarios);
            this.panelBotones.Controls.Add(this.btnProyectos);
            this.panelBotones.Location = new System.Drawing.Point(12, 6);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Radius = 10;
            this.panelBotones.Size = new System.Drawing.Size(46, 512);
            this.panelBotones.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BaseColor1 = System.Drawing.Color.Crimson;
            this.btnLogout.BaseColor2 = System.Drawing.Color.Red;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::VIews.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(3, 474);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor1 = System.Drawing.Color.Gold;
            this.btnLogout.OnHoverBaseColor2 = System.Drawing.Color.Yellow;
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Radius = 10;
            this.btnLogout.Size = new System.Drawing.Size(40, 35);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.AnimationHoverSpeed = 0.07F;
            this.btnEmpleados.AnimationSpeed = 0.03F;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnEmpleados.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnEmpleados.BorderColor = System.Drawing.Color.Black;
            this.btnEmpleados.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEmpleados.FocusedColor = System.Drawing.Color.Empty;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Image = global::VIews.Properties.Resources.empleado2;
            this.btnEmpleados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmpleados.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmpleados.Location = new System.Drawing.Point(0, 102);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.OnHoverBaseColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnEmpleados.OnHoverBaseColor2 = System.Drawing.Color.Lime;
            this.btnEmpleados.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnEmpleados.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEmpleados.OnHoverImage = null;
            this.btnEmpleados.OnPressedColor = System.Drawing.Color.Black;
            this.btnEmpleados.Radius = 10;
            this.btnEmpleados.Size = new System.Drawing.Size(46, 35);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.AnimationHoverSpeed = 0.07F;
            this.btnTareas.AnimationSpeed = 0.03F;
            this.btnTareas.BackColor = System.Drawing.Color.Transparent;
            this.btnTareas.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnTareas.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnTareas.BorderColor = System.Drawing.Color.Black;
            this.btnTareas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTareas.FocusedColor = System.Drawing.Color.Empty;
            this.btnTareas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTareas.ForeColor = System.Drawing.Color.White;
            this.btnTareas.Image = global::VIews.Properties.Resources.tarea1;
            this.btnTareas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTareas.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTareas.Location = new System.Drawing.Point(0, 61);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.OnHoverBaseColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnTareas.OnHoverBaseColor2 = System.Drawing.Color.Lime;
            this.btnTareas.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnTareas.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTareas.OnHoverImage = null;
            this.btnTareas.OnPressedColor = System.Drawing.Color.Black;
            this.btnTareas.Radius = 10;
            this.btnTareas.Size = new System.Drawing.Size(46, 35);
            this.btnTareas.TabIndex = 5;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AnimationHoverSpeed = 0.07F;
            this.btnUsuarios.AnimationSpeed = 0.03F;
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnUsuarios.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnUsuarios.BorderColor = System.Drawing.Color.Black;
            this.btnUsuarios.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsuarios.FocusedColor = System.Drawing.Color.Empty;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::VIews.Properties.Resources.User;
            this.btnUsuarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUsuarios.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUsuarios.Location = new System.Drawing.Point(0, 143);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.OnHoverBaseColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnUsuarios.OnHoverBaseColor2 = System.Drawing.Color.Lime;
            this.btnUsuarios.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnUsuarios.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUsuarios.OnHoverImage = null;
            this.btnUsuarios.OnPressedColor = System.Drawing.Color.Black;
            this.btnUsuarios.Radius = 10;
            this.btnUsuarios.Size = new System.Drawing.Size(46, 35);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnProyectos
            // 
            this.btnProyectos.AnimationHoverSpeed = 0.07F;
            this.btnProyectos.AnimationSpeed = 0.03F;
            this.btnProyectos.BackColor = System.Drawing.Color.Transparent;
            this.btnProyectos.BaseColor1 = System.Drawing.Color.Transparent;
            this.btnProyectos.BaseColor2 = System.Drawing.Color.Transparent;
            this.btnProyectos.BorderColor = System.Drawing.Color.Black;
            this.btnProyectos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnProyectos.FocusedColor = System.Drawing.Color.Empty;
            this.btnProyectos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProyectos.ForeColor = System.Drawing.Color.White;
            this.btnProyectos.Image = global::VIews.Properties.Resources.Maletin;
            this.btnProyectos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProyectos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProyectos.Location = new System.Drawing.Point(0, 20);
            this.btnProyectos.Name = "btnProyectos";
            this.btnProyectos.OnHoverBaseColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnProyectos.OnHoverBaseColor2 = System.Drawing.Color.Lime;
            this.btnProyectos.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnProyectos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProyectos.OnHoverImage = null;
            this.btnProyectos.OnPressedColor = System.Drawing.Color.Black;
            this.btnProyectos.Radius = 10;
            this.btnProyectos.Size = new System.Drawing.Size(46, 35);
            this.btnProyectos.TabIndex = 3;
            this.btnProyectos.Click += new System.EventHandler(this.btnProyectos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 564);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.panelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelDrag.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFotoUsuarioActual)).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton btnCerrar;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaElipsePanel panelBotones;
        private Guna.UI.WinForms.GunaElipsePanel panelSuperior;
        private Guna.UI.WinForms.GunaElipsePanel panelCentral;
        private Guna.UI.WinForms.GunaGradientButton btnLogout;
        private Guna.UI.WinForms.GunaGradientButton btnEmpleados;
        private Guna.UI.WinForms.GunaGradientButton btnTareas;
        private Guna.UI.WinForms.GunaGradientButton btnUsuarios;
        private Guna.UI.WinForms.GunaGradientButton btnProyectos;
        private System.Windows.Forms.Label lblTituloDeFormularioHijo;
        private Guna.UI.WinForms.GunaPictureBox pbxFotoUsuarioActual;
        private System.Windows.Forms.Label lblNyADelUsuarioActual;
        private System.Windows.Forms.Label lblRoleUsuarioActual;
    }
}

