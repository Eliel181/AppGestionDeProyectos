namespace VIews.Formularios
{
    partial class FormTareas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panelTareas = new Guna.UI.WinForms.GunaGroupBox();
            this.lblNroTareas = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.cmbPrioridad = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.cmbEmpleado = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.cmbAdministrador = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.cmbProyecto = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnEliminar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaGradientButton();
            this.btnEditar = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnGuardar = new Guna.UI.WinForms.GunaGradientButton();
            this.dtpFechaVencimiento = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dtpFechaInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtIdTarea = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvTareas = new Guna.UI.WinForms.GunaDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new Guna.UI.WinForms.GunaLabel();
            this.panelTareas.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panelTareas
            // 
            this.panelTareas.BackColor = System.Drawing.Color.Transparent;
            this.panelTareas.BaseColor = System.Drawing.Color.White;
            this.panelTareas.BorderColor = System.Drawing.Color.Gainsboro;
            this.panelTareas.Controls.Add(this.lblMensaje);
            this.panelTareas.Controls.Add(this.lblNroTareas);
            this.panelTareas.Controls.Add(this.gunaLabel10);
            this.panelTareas.Controls.Add(this.cmbPrioridad);
            this.panelTareas.Controls.Add(this.gunaLabel11);
            this.panelTareas.Controls.Add(this.gunaLabel9);
            this.panelTareas.Controls.Add(this.cmbEmpleado);
            this.panelTareas.Controls.Add(this.gunaLabel8);
            this.panelTareas.Controls.Add(this.cmbAdministrador);
            this.panelTareas.Controls.Add(this.gunaLabel7);
            this.panelTareas.Controls.Add(this.cmbProyecto);
            this.panelTareas.Controls.Add(this.gunaLabel6);
            this.panelTareas.Controls.Add(this.btnEliminar);
            this.panelTareas.Controls.Add(this.btnNuevo);
            this.panelTareas.Controls.Add(this.btnEditar);
            this.panelTareas.Controls.Add(this.gunaLabel5);
            this.panelTareas.Controls.Add(this.btnGuardar);
            this.panelTareas.Controls.Add(this.dtpFechaVencimiento);
            this.panelTareas.Controls.Add(this.gunaLabel3);
            this.panelTareas.Controls.Add(this.dtpFechaInicio);
            this.panelTareas.Controls.Add(this.gunaLabel4);
            this.panelTareas.Controls.Add(this.txtDescripcion);
            this.panelTareas.Controls.Add(this.gunaLabel2);
            this.panelTareas.Controls.Add(this.txtNombre);
            this.panelTareas.Controls.Add(this.gunaLabel1);
            this.panelTareas.Controls.Add(this.txtIdTarea);
            this.panelTareas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTareas.ForeColor = System.Drawing.Color.White;
            this.panelTareas.LineColor = System.Drawing.Color.RoyalBlue;
            this.panelTareas.LineTop = 20;
            this.panelTareas.Location = new System.Drawing.Point(0, 0);
            this.panelTareas.Name = "panelTareas";
            this.panelTareas.Size = new System.Drawing.Size(924, 200);
            this.panelTareas.TabIndex = 1;
            this.panelTareas.Text = "Datos de Tarea";
            this.panelTareas.TextLocation = new System.Drawing.Point(430, 4);
            // 
            // lblNroTareas
            // 
            this.lblNroTareas.AutoSize = true;
            this.lblNroTareas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroTareas.ForeColor = System.Drawing.Color.Black;
            this.lblNroTareas.Location = new System.Drawing.Point(754, 111);
            this.lblNroTareas.Name = "lblNroTareas";
            this.lblNroTareas.Size = new System.Drawing.Size(15, 17);
            this.lblNroTareas.TabIndex = 40;
            this.lblNroTareas.Text = "0";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel11.Location = new System.Drawing.Point(651, 111);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(97, 17);
            this.gunaLabel11.TabIndex = 39;
            this.gunaLabel11.Text = "Nro de Tareas:";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel10.Location = new System.Drawing.Point(285, 164);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(0, 17);
            this.gunaLabel10.TabIndex = 38;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.BackColor = System.Drawing.Color.Transparent;
            this.cmbPrioridad.BaseColor = System.Drawing.Color.White;
            this.cmbPrioridad.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmbPrioridad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPrioridad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPrioridad.ForeColor = System.Drawing.Color.Black;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "BAJA",
            "NORMAL",
            "URGENTE",
            "CRITICA"});
            this.cmbPrioridad.Location = new System.Drawing.Point(370, 116);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbPrioridad.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbPrioridad.Radius = 5;
            this.cmbPrioridad.Size = new System.Drawing.Size(155, 26);
            this.cmbPrioridad.TabIndex = 37;
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel9.Location = new System.Drawing.Point(285, 122);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(79, 17);
            this.gunaLabel9.TabIndex = 36;
            this.gunaLabel9.Text = "PRIORIDAD";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEmpleado.BaseColor = System.Drawing.Color.White;
            this.cmbEmpleado.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmbEmpleado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FocusedColor = System.Drawing.Color.Empty;
            this.cmbEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(370, 161);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbEmpleado.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbEmpleado.Radius = 5;
            this.cmbEmpleado.Size = new System.Drawing.Size(155, 26);
            this.cmbEmpleado.TabIndex = 35;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel8.Location = new System.Drawing.Point(289, 161);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(78, 17);
            this.gunaLabel8.TabIndex = 34;
            this.gunaLabel8.Text = "EMPLEADO";
            // 
            // cmbAdministrador
            // 
            this.cmbAdministrador.BackColor = System.Drawing.Color.Transparent;
            this.cmbAdministrador.BaseColor = System.Drawing.Color.White;
            this.cmbAdministrador.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmbAdministrador.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAdministrador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdministrador.FocusedColor = System.Drawing.Color.Empty;
            this.cmbAdministrador.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAdministrador.ForeColor = System.Drawing.Color.Black;
            this.cmbAdministrador.FormattingEnabled = true;
            this.cmbAdministrador.Location = new System.Drawing.Point(616, 33);
            this.cmbAdministrador.Name = "cmbAdministrador";
            this.cmbAdministrador.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbAdministrador.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbAdministrador.Radius = 5;
            this.cmbAdministrador.Size = new System.Drawing.Size(155, 26);
            this.cmbAdministrador.TabIndex = 33;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel7.Location = new System.Drawing.Point(557, 38);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(53, 17);
            this.gunaLabel7.TabIndex = 32;
            this.gunaLabel7.Text = "ADMIN";
            // 
            // cmbProyecto
            // 
            this.cmbProyecto.BackColor = System.Drawing.Color.Transparent;
            this.cmbProyecto.BaseColor = System.Drawing.Color.White;
            this.cmbProyecto.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cmbProyecto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProyecto.FocusedColor = System.Drawing.Color.Empty;
            this.cmbProyecto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProyecto.ForeColor = System.Drawing.Color.Black;
            this.cmbProyecto.FormattingEnabled = true;
            this.cmbProyecto.Items.AddRange(new object[] {
            "--seleccionar"});
            this.cmbProyecto.Location = new System.Drawing.Point(616, 82);
            this.cmbProyecto.Name = "cmbProyecto";
            this.cmbProyecto.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbProyecto.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbProyecto.Radius = 5;
            this.cmbProyecto.Size = new System.Drawing.Size(155, 26);
            this.cmbProyecto.TabIndex = 31;
            this.cmbProyecto.SelectedIndexChanged += new System.EventHandler(this.cmbProyecto_SelectedIndexChanged);
            this.cmbProyecto.SelectedValueChanged += new System.EventHandler(this.cmbProyecto_SelectedValueChanged);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(535, 82);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(75, 17);
            this.gunaLabel6.TabIndex = 30;
            this.gunaLabel6.Text = "PROYECTO";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor1 = System.Drawing.Color.Crimson;
            this.btnEliminar.BaseColor2 = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(805, 148);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor1 = System.Drawing.Color.Crimson;
            this.btnEliminar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 7;
            this.btnEliminar.Size = new System.Drawing.Size(92, 28);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.AnimationHoverSpeed = 0.07F;
            this.btnNuevo.AnimationSpeed = 0.03F;
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BaseColor1 = System.Drawing.Color.HotPink;
            this.btnNuevo.BaseColor2 = System.Drawing.Color.Plum;
            this.btnNuevo.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNuevo.FocusedColor = System.Drawing.Color.Empty;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Black;
            this.btnNuevo.Image = null;
            this.btnNuevo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNuevo.Location = new System.Drawing.Point(805, 71);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.OnHoverBaseColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnNuevo.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnNuevo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNuevo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNuevo.OnHoverImage = null;
            this.btnNuevo.OnPressedColor = System.Drawing.Color.Black;
            this.btnNuevo.Radius = 7;
            this.btnNuevo.Size = new System.Drawing.Size(92, 28);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BaseColor1 = System.Drawing.Color.DarkOrange;
            this.btnEditar.BaseColor2 = System.Drawing.Color.Gold;
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = null;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(805, 105);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBaseColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEditar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEditar.OnHoverImage = null;
            this.btnEditar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEditar.Radius = 7;
            this.btnEditar.Size = new System.Drawing.Size(92, 28);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(251, 82);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(142, 17);
            this.gunaLabel5.TabIndex = 25;
            this.gunaLabel5.Text = "FECHA VENCIMIENTO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.BaseColor2 = System.Drawing.Color.LimeGreen;
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(805, 27);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBaseColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGuardar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGuardar.OnHoverImage = null;
            this.btnGuardar.OnPressedColor = System.Drawing.Color.Black;
            this.btnGuardar.Radius = 7;
            this.btnGuardar.Size = new System.Drawing.Size(92, 28);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaVencimiento.BaseColor = System.Drawing.Color.White;
            this.dtpFechaVencimiento.BorderColor = System.Drawing.Color.RoyalBlue;
            this.dtpFechaVencimiento.CustomFormat = null;
            this.dtpFechaVencimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaVencimiento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaVencimiento.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(400, 73);
            this.dtpFechaVencimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaVencimiento.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaVencimiento.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaVencimiento.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaVencimiento.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaVencimiento.Radius = 5;
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(125, 30);
            this.dtpFechaVencimiento.TabIndex = 24;
            this.dtpFechaVencimiento.Text = "8/12/2023";
            this.dtpFechaVencimiento.Value = new System.DateTime(2023, 12, 8, 1, 33, 48, 596);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(301, 36);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(93, 17);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "FECHA INICIO";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaInicio.BaseColor = System.Drawing.Color.White;
            this.dtpFechaInicio.BorderColor = System.Drawing.Color.RoyalBlue;
            this.dtpFechaInicio.CustomFormat = null;
            this.dtpFechaInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaInicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(400, 27);
            this.dtpFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaInicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaInicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaInicio.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaInicio.Radius = 5;
            this.dtpFechaInicio.Size = new System.Drawing.Size(125, 30);
            this.dtpFechaInicio.TabIndex = 22;
            this.dtpFechaInicio.Text = "8/12/2023";
            this.dtpFechaInicio.Value = new System.DateTime(2023, 12, 8, 1, 33, 48, 596);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(48, 82);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(63, 17);
            this.gunaLabel4.TabIndex = 17;
            this.gunaLabel4.Text = "NOMBRE";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.txtDescripcion.BaseColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcion.FocusedBorderColor = System.Drawing.Color.Indigo;
            this.txtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(117, 126);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.Radius = 5;
            this.txtDescripcion.Size = new System.Drawing.Size(107, 67);
            this.txtDescripcion.TabIndex = 14;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel2.Location = new System.Drawing.Point(19, 135);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(92, 17);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "DESCRIPCION";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNombre.FocusedBorderColor = System.Drawing.Color.Indigo;
            this.txtNombre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(117, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.Radius = 5;
            this.txtNombre.Size = new System.Drawing.Size(107, 26);
            this.txtNombre.TabIndex = 12;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(89, 36);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(22, 17);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "ID";
            // 
            // txtIdTarea
            // 
            this.txtIdTarea.BackColor = System.Drawing.Color.Transparent;
            this.txtIdTarea.BaseColor = System.Drawing.Color.White;
            this.txtIdTarea.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtIdTarea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdTarea.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdTarea.FocusedBorderColor = System.Drawing.Color.Indigo;
            this.txtIdTarea.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdTarea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdTarea.ForeColor = System.Drawing.Color.Black;
            this.txtIdTarea.Location = new System.Drawing.Point(117, 27);
            this.txtIdTarea.Name = "txtIdTarea";
            this.txtIdTarea.PasswordChar = '\0';
            this.txtIdTarea.Radius = 5;
            this.txtIdTarea.Size = new System.Drawing.Size(107, 26);
            this.txtIdTarea.TabIndex = 10;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvTareas);
            this.gunaGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.LineTop = 20;
            this.gunaGroupBox2.Location = new System.Drawing.Point(0, 210);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(924, 240);
            this.gunaGroupBox2.TabIndex = 2;
            this.gunaGroupBox2.Text = "Lista de Tareas";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(426, 5);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTareas.ColumnHeadersHeight = 21;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.FecIni,
            this.Vencimiento,
            this.Estado,
            this.Prioridad,
            this.Empleado,
            this.Admin,
            this.Proyecto,
            this.idUsuario,
            this.idEmpleado,
            this.idProyecto});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTareas.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTareas.EnableHeadersVisualStyles = false;
            this.dgvTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvTareas.Location = new System.Drawing.Point(0, 19);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(921, 218);
            this.dgvTareas.TabIndex = 0;
            this.dgvTareas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTareas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTareas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.dgvTareas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.dgvTareas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTareas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTareas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTareas.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvTareas.ThemeStyle.ReadOnly = true;
            this.dgvTareas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.dgvTareas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTareas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTareas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTareas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTareas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.dgvTareas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTareas.DoubleClick += new System.EventHandler(this.dgvTareas_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdTarea";
            this.Id.FillWeight = 20F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.FillWeight = 96.8818F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 96.8818F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // FecIni
            // 
            this.FecIni.DataPropertyName = "FechaInicio";
            this.FecIni.FillWeight = 96.8818F;
            this.FecIni.HeaderText = "Inicio";
            this.FecIni.Name = "FecIni";
            this.FecIni.ReadOnly = true;
            // 
            // Vencimiento
            // 
            this.Vencimiento.DataPropertyName = "FechaVencimiento";
            this.Vencimiento.FillWeight = 96.8818F;
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Prioridad
            // 
            this.Prioridad.DataPropertyName = "Prioridad";
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // Empleado
            // 
            this.Empleado.DataPropertyName = "Empleado";
            this.Empleado.FillWeight = 96.8818F;
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Administrador";
            this.Admin.FillWeight = 96.8818F;
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.ReadOnly = true;
            // 
            // Proyecto
            // 
            this.Proyecto.DataPropertyName = "Proyecto";
            this.Proyecto.FillWeight = 96.8818F;
            this.Proyecto.HeaderText = "Proyecto";
            this.Proyecto.Name = "Proyecto";
            this.Proyecto.ReadOnly = true;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "IdUsuario";
            this.idUsuario.HeaderText = "IdUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "IdEmpleado";
            this.idEmpleado.HeaderText = "IdEmpleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            // 
            // idProyecto
            // 
            this.idProyecto.DataPropertyName = "IdProyecto";
            this.idProyecto.HeaderText = "IdProyecto";
            this.idProyecto.Name = "idProyecto";
            this.idProyecto.ReadOnly = true;
            this.idProyecto.Visible = false;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(580, 142);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(191, 46);
            this.lblMensaje.TabIndex = 41;
            this.lblMensaje.Text = "Este proyecto alcanzo el maximo de tareas posibles";
            this.lblMensaje.Visible = false;
            // 
            // FormTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.panelTareas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTareas";
            this.Text = "Gestion de Tareas";
            this.panelTareas.ResumeLayout(false);
            this.panelTareas.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGroupBox panelTareas;
        private Guna.UI.WinForms.GunaGradientButton btnEliminar;
        private Guna.UI.WinForms.GunaGradientButton btnNuevo;
        private Guna.UI.WinForms.GunaGradientButton btnEditar;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaGradientButton btnGuardar;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaVencimiento;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaInicio;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtDescripcion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtIdTarea;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaComboBox cmbProyecto;
        private Guna.UI.WinForms.GunaComboBox cmbEmpleado;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaComboBox cmbAdministrador;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvTareas;
        private Guna.UI.WinForms.GunaComboBox cmbPrioridad;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyecto;
        private Guna.UI.WinForms.GunaLabel lblNroTareas;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel lblMensaje;
    }
}