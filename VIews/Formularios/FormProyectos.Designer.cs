namespace VIews.Formularios
{
    partial class FormProyectos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnFinalizarProyecto = new Guna.UI.WinForms.GunaGradientButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnNuevo = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaCircleProgressPorcentaje = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.btnEditar = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.btnGuardar = new Guna.UI.WinForms.GunaGradientButton();
            this.dtpFechaFinalizacion = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dtpFechaInicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txtDescripcion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtNombre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtIdProyecto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvProyectos = new Guna.UI.WinForms.GunaDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Op = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaGroupBox4 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvListaTareas = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.gunaGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.btnFinalizarProyecto);
            this.gunaGroupBox1.Controls.Add(this.btnEliminar);
            this.gunaGroupBox1.Controls.Add(this.btnNuevo);
            this.gunaGroupBox1.Controls.Add(this.gunaGroupBox2);
            this.gunaGroupBox1.Controls.Add(this.btnEditar);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel5);
            this.gunaGroupBox1.Controls.Add(this.btnGuardar);
            this.gunaGroupBox1.Controls.Add(this.dtpFechaFinalizacion);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel3);
            this.gunaGroupBox1.Controls.Add(this.dtpFechaInicio);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel4);
            this.gunaGroupBox1.Controls.Add(this.txtDescripcion);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel2);
            this.gunaGroupBox1.Controls.Add(this.txtNombre);
            this.gunaGroupBox1.Controls.Add(this.gunaLabel1);
            this.gunaGroupBox1.Controls.Add(this.txtIdProyecto);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.DeepPink;
            this.gunaGroupBox1.LineTop = 20;
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(924, 200);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Datos de Proyecto";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(430, 4);
            // 
            // btnFinalizarProyecto
            // 
            this.btnFinalizarProyecto.AnimationHoverSpeed = 0.07F;
            this.btnFinalizarProyecto.AnimationSpeed = 0.03F;
            this.btnFinalizarProyecto.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarProyecto.BaseColor1 = System.Drawing.Color.DodgerBlue;
            this.btnFinalizarProyecto.BaseColor2 = System.Drawing.Color.LightSteelBlue;
            this.btnFinalizarProyecto.BorderColor = System.Drawing.Color.Black;
            this.btnFinalizarProyecto.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizarProyecto.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinalizarProyecto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarProyecto.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarProyecto.Image = null;
            this.btnFinalizarProyecto.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFinalizarProyecto.Location = new System.Drawing.Point(328, 138);
            this.btnFinalizarProyecto.Name = "btnFinalizarProyecto";
            this.btnFinalizarProyecto.OnHoverBaseColor1 = System.Drawing.Color.DarkSlateGray;
            this.btnFinalizarProyecto.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnFinalizarProyecto.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinalizarProyecto.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFinalizarProyecto.OnHoverImage = null;
            this.btnFinalizarProyecto.OnPressedColor = System.Drawing.Color.Black;
            this.btnFinalizarProyecto.Radius = 7;
            this.btnFinalizarProyecto.Size = new System.Drawing.Size(154, 28);
            this.btnFinalizarProyecto.TabIndex = 30;
            this.btnFinalizarProyecto.Text = "Finalizar Proyecto";
            this.btnFinalizarProyecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor1 = System.Drawing.Color.Crimson;
            this.btnEliminar.BaseColor2 = System.Drawing.Color.HotPink;
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(564, 148);
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
            this.btnNuevo.Location = new System.Drawing.Point(564, 71);
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
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.DeepPink;
            this.gunaGroupBox2.BorderSize = 2;
            this.gunaGroupBox2.Controls.Add(this.gunaCircleProgressPorcentaje);
            this.gunaGroupBox2.LineColor = System.Drawing.Color.DeepPink;
            this.gunaGroupBox2.Location = new System.Drawing.Point(695, 26);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 10;
            this.gunaGroupBox2.Size = new System.Drawing.Size(217, 155);
            this.gunaGroupBox2.TabIndex = 26;
            this.gunaGroupBox2.Text = "Porcentaje de Proyecto";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaCircleProgressPorcentaje
            // 
            this.gunaCircleProgressPorcentaje.AnimationSpeed = 0.6F;
            this.gunaCircleProgressPorcentaje.BaseColor = System.Drawing.Color.White;
            this.gunaCircleProgressPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.gunaCircleProgressPorcentaje.IdleColor = System.Drawing.Color.Gainsboro;
            this.gunaCircleProgressPorcentaje.IdleOffset = 20;
            this.gunaCircleProgressPorcentaje.Image = null;
            this.gunaCircleProgressPorcentaje.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaCircleProgressPorcentaje.Location = new System.Drawing.Point(41, 25);
            this.gunaCircleProgressPorcentaje.Name = "gunaCircleProgressPorcentaje";
            this.gunaCircleProgressPorcentaje.ProgressMaxColor = System.Drawing.Color.Purple;
            this.gunaCircleProgressPorcentaje.ProgressMinColor = System.Drawing.Color.Crimson;
            this.gunaCircleProgressPorcentaje.ProgressOffset = 20;
            this.gunaCircleProgressPorcentaje.Size = new System.Drawing.Size(130, 130);
            this.gunaCircleProgressPorcentaje.TabIndex = 0;
            this.gunaCircleProgressPorcentaje.Value = 30;
            // 
            // btnEditar
            // 
            this.btnEditar.AnimationHoverSpeed = 0.07F;
            this.btnEditar.AnimationSpeed = 0.03F;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BaseColor1 = System.Drawing.Color.Yellow;
            this.btnEditar.BaseColor2 = System.Drawing.Color.Gold;
            this.btnEditar.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEditar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = null;
            this.btnEditar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEditar.Location = new System.Drawing.Point(564, 105);
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
            this.gunaLabel5.Size = new System.Drawing.Size(143, 17);
            this.gunaLabel5.TabIndex = 25;
            this.gunaLabel5.Text = "FECHA FINALIZACION";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AnimationHoverSpeed = 0.07F;
            this.btnGuardar.AnimationSpeed = 0.03F;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BaseColor1 = System.Drawing.Color.Yellow;
            this.btnGuardar.BaseColor2 = System.Drawing.Color.Lime;
            this.btnGuardar.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGuardar.FocusedColor = System.Drawing.Color.Empty;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = null;
            this.btnGuardar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGuardar.Location = new System.Drawing.Point(564, 27);
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
            // dtpFechaFinalizacion
            // 
            this.dtpFechaFinalizacion.BackColor = System.Drawing.Color.Transparent;
            this.dtpFechaFinalizacion.BaseColor = System.Drawing.Color.White;
            this.dtpFechaFinalizacion.BorderColor = System.Drawing.Color.DeepPink;
            this.dtpFechaFinalizacion.CustomFormat = null;
            this.dtpFechaFinalizacion.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaFinalizacion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaFinalizacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFechaFinalizacion.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinalizacion.Location = new System.Drawing.Point(400, 73);
            this.dtpFechaFinalizacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFinalizacion.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion";
            this.dtpFechaFinalizacion.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFechaFinalizacion.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaFinalizacion.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFechaFinalizacion.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFechaFinalizacion.Radius = 5;
            this.dtpFechaFinalizacion.Size = new System.Drawing.Size(125, 30);
            this.dtpFechaFinalizacion.TabIndex = 24;
            this.dtpFechaFinalizacion.Text = "8/12/2023";
            this.dtpFechaFinalizacion.Value = new System.DateTime(2023, 12, 8, 1, 33, 48, 596);
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
            this.dtpFechaInicio.BorderColor = System.Drawing.Color.DeepPink;
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
            this.txtDescripcion.BorderColor = System.Drawing.Color.DeepPink;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescripcion.FocusedBorderColor = System.Drawing.Color.Indigo;
            this.txtDescripcion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcion.Location = new System.Drawing.Point(117, 114);
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
            this.gunaLabel2.Location = new System.Drawing.Point(19, 123);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(92, 17);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "DESCRIPCION";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BaseColor = System.Drawing.Color.White;
            this.txtNombre.BorderColor = System.Drawing.Color.DeepPink;
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
            // txtIdProyecto
            // 
            this.txtIdProyecto.BackColor = System.Drawing.Color.Transparent;
            this.txtIdProyecto.BaseColor = System.Drawing.Color.White;
            this.txtIdProyecto.BorderColor = System.Drawing.Color.DeepPink;
            this.txtIdProyecto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdProyecto.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIdProyecto.FocusedBorderColor = System.Drawing.Color.Indigo;
            this.txtIdProyecto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIdProyecto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdProyecto.ForeColor = System.Drawing.Color.Black;
            this.txtIdProyecto.Location = new System.Drawing.Point(117, 27);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.PasswordChar = '\0';
            this.txtIdProyecto.Radius = 5;
            this.txtIdProyecto.Size = new System.Drawing.Size(107, 26);
            this.txtIdProyecto.TabIndex = 10;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Controls.Add(this.dgvProyectos);
            this.gunaGroupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaGroupBox3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Location = new System.Drawing.Point(0, 200);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Radius = 10;
            this.gunaGroupBox3.Size = new System.Drawing.Size(458, 235);
            this.gunaGroupBox3.TabIndex = 1;
            this.gunaGroupBox3.Text = "Lista de Proyectos";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.AllowUserToAddRows = false;
            this.dgvProyectos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.dgvProyectos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProyectos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProyectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProyectos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProyectos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProyectos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProyectos.ColumnHeadersHeight = 21;
            this.dgvProyectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Descripcion,
            this.FecInicio,
            this.FecFin,
            this.Estado,
            this.Op});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(105)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProyectos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProyectos.EnableHeadersVisualStyles = false;
            this.dgvProyectos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.dgvProyectos.Location = new System.Drawing.Point(0, 30);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.ReadOnly = true;
            this.dgvProyectos.RowHeadersVisible = false;
            this.dgvProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProyectos.Size = new System.Drawing.Size(452, 202);
            this.dgvProyectos.TabIndex = 0;
            this.dgvProyectos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Pink;
            this.dgvProyectos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.dgvProyectos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProyectos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProyectos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProyectos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProyectos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProyectos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.dgvProyectos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.dgvProyectos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProyectos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProyectos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProyectos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProyectos.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvProyectos.ThemeStyle.ReadOnly = true;
            this.dgvProyectos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(223)))));
            this.dgvProyectos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProyectos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvProyectos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProyectos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProyectos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(105)))), ((int)(((byte)(151)))));
            this.dgvProyectos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProyectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellClick);
            this.dgvProyectos.DoubleClick += new System.EventHandler(this.dgvProyectos_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdProyecto";
            this.Id.FillWeight = 30F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // FecInicio
            // 
            this.FecInicio.DataPropertyName = "FechaInicio";
            this.FecInicio.HeaderText = "Fec.Inicio";
            this.FecInicio.Name = "FecInicio";
            this.FecInicio.ReadOnly = true;
            // 
            // FecFin
            // 
            this.FecFin.DataPropertyName = "FechaFinalizacion";
            this.FecFin.HeaderText = "Fec.Fin.";
            this.FecFin.Name = "FecFin";
            this.FecFin.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Op
            // 
            this.Op.DataPropertyName = "op";
            this.Op.HeaderText = "Op";
            this.Op.Name = "Op";
            this.Op.ReadOnly = true;
            // 
            // gunaGroupBox4
            // 
            this.gunaGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox4.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox4.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.Controls.Add(this.dgvListaTareas);
            this.gunaGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox4.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox4.Location = new System.Drawing.Point(458, 200);
            this.gunaGroupBox4.Name = "gunaGroupBox4";
            this.gunaGroupBox4.Radius = 10;
            this.gunaGroupBox4.Size = new System.Drawing.Size(466, 235);
            this.gunaGroupBox4.TabIndex = 2;
            this.gunaGroupBox4.Text = "Tareas del Proyecto";
            this.gunaGroupBox4.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvListaTareas
            // 
            this.dgvListaTareas.AllowUserToAddRows = false;
            this.dgvListaTareas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.dgvListaTareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaTareas.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaTareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaTareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaTareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaTareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaTareas.ColumnHeadersHeight = 21;
            this.dgvListaTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewButtonColumn1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(105)))), ((int)(((byte)(151)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaTareas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaTareas.EnableHeadersVisualStyles = false;
            this.dgvListaTareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.dgvListaTareas.Location = new System.Drawing.Point(6, 30);
            this.dgvListaTareas.Name = "dgvListaTareas";
            this.dgvListaTareas.ReadOnly = true;
            this.dgvListaTareas.RowHeadersVisible = false;
            this.dgvListaTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaTareas.Size = new System.Drawing.Size(452, 202);
            this.dgvListaTareas.TabIndex = 1;
            this.dgvListaTareas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Pink;
            this.dgvListaTareas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(188)))), ((int)(((byte)(208)))));
            this.dgvListaTareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvListaTareas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvListaTareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvListaTareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvListaTareas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaTareas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(203)))));
            this.dgvListaTareas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.dgvListaTareas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListaTareas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListaTareas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvListaTareas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvListaTareas.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvListaTareas.ThemeStyle.ReadOnly = true;
            this.dgvListaTareas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(210)))), ((int)(((byte)(223)))));
            this.dgvListaTareas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvListaTareas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvListaTareas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListaTareas.ThemeStyle.RowsStyle.Height = 22;
            this.dgvListaTareas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(105)))), ((int)(((byte)(151)))));
            this.dgvListaTareas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTarea";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fec.Inicio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FechaVencimiento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fec.Ven.";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Prioridad";
            this.dataGridViewButtonColumn1.HeaderText = "Prioridad";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 435);
            this.Controls.Add(this.gunaGroupBox4);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.gunaGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProyectos";
            this.Text = "Gestion de Proyectos";
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.gunaGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txtDescripcion;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtNombre;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtIdProyecto;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaFinalizacion;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFechaInicio;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaCircleProgressBar gunaCircleProgressPorcentaje;
        private Guna.UI.WinForms.GunaGradientButton btnFinalizarProyecto;
        private Guna.UI.WinForms.GunaGradientButton btnEliminar;
        private Guna.UI.WinForms.GunaGradientButton btnNuevo;
        private Guna.UI.WinForms.GunaGradientButton btnEditar;
        private Guna.UI.WinForms.GunaGradientButton btnGuardar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox4;
        private Guna.UI.WinForms.GunaDataGridView dgvProyectos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Op;
        private Guna.UI.WinForms.GunaDataGridView dgvListaTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewButtonColumn1;
    }
}