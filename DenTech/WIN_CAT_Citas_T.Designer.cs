namespace DenTech
{
    partial class WIN_CAT_Citas_T
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Citas_T));
            this.DGV_TablaCitas = new System.Windows.Forms.DataGridView();
            this.COL_IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Odontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Recetas = new System.Windows.Forms.Button();
            this.PANEL_Mes = new System.Windows.Forms.Panel();
            this.STC_MesAño = new System.Windows.Forms.Label();
            this.PANEL_Flechas = new System.Windows.Forms.Panel();
            this.BTN_Adelante = new System.Windows.Forms.Button();
            this.BTN_Atras = new System.Windows.Forms.Button();
            this.LAYOUT_Cuerpo = new System.Windows.Forms.FlowLayoutPanel();
            this.PANEL_CuadroDia = new System.Windows.Forms.FlowLayoutPanel();
            this.STC_NumDia = new System.Windows.Forms.Label();
            this.LSTC_Appointment = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STC_Sabado = new System.Windows.Forms.Label();
            this.STC_Viernes = new System.Windows.Forms.Label();
            this.STC_Jueves = new System.Windows.Forms.Label();
            this.STC_Miercoles = new System.Windows.Forms.Label();
            this.STC_Martes = new System.Windows.Forms.Label();
            this.STC_Lunes = new System.Windows.Forms.Label();
            this.STC_Domingo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaCitas)).BeginInit();
            this.PANEL_Mes.SuspendLayout();
            this.PANEL_Flechas.SuspendLayout();
            this.LAYOUT_Cuerpo.SuspendLayout();
            this.PANEL_CuadroDia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_TablaCitas
            // 
            this.DGV_TablaCitas.AllowUserToAddRows = false;
            this.DGV_TablaCitas.AllowUserToDeleteRows = false;
            this.DGV_TablaCitas.AllowUserToOrderColumns = true;
            this.DGV_TablaCitas.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaCitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaCitas.ColumnHeadersHeight = 30;
            this.DGV_TablaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdCita,
            this.IdPaciente,
            this.COL_Odontologo,
            this.COL_Paciente,
            this.COL_Fecha});
            this.DGV_TablaCitas.EnableHeadersVisualStyles = false;
            this.DGV_TablaCitas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaCitas.Location = new System.Drawing.Point(984, 228);
            this.DGV_TablaCitas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaCitas.Name = "DGV_TablaCitas";
            this.DGV_TablaCitas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaCitas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaCitas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TablaCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaCitas.Size = new System.Drawing.Size(111, 62);
            this.DGV_TablaCitas.TabIndex = 33;
            // 
            // COL_IdCita
            // 
            this.COL_IdCita.DataPropertyName = "Id_Cita";
            this.COL_IdCita.Frozen = true;
            this.COL_IdCita.HeaderText = "IdCitas";
            this.COL_IdCita.Name = "COL_IdCita";
            this.COL_IdCita.ReadOnly = true;
            this.COL_IdCita.Visible = false;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "Id_Paciente";
            this.IdPaciente.Frozen = true;
            this.IdPaciente.HeaderText = "IdPaciente";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Visible = false;
            // 
            // COL_Odontologo
            // 
            this.COL_Odontologo.DataPropertyName = "NombreOdontologo";
            this.COL_Odontologo.Frozen = true;
            this.COL_Odontologo.HeaderText = "Odontólogo";
            this.COL_Odontologo.Name = "COL_Odontologo";
            this.COL_Odontologo.ReadOnly = true;
            this.COL_Odontologo.Width = 250;
            // 
            // COL_Paciente
            // 
            this.COL_Paciente.DataPropertyName = "NombrePaciente";
            this.COL_Paciente.Frozen = true;
            this.COL_Paciente.HeaderText = "Paciente";
            this.COL_Paciente.Name = "COL_Paciente";
            this.COL_Paciente.ReadOnly = true;
            this.COL_Paciente.Width = 250;
            // 
            // COL_Fecha
            // 
            this.COL_Fecha.DataPropertyName = "Fecha_Cita";
            this.COL_Fecha.HeaderText = "Fecha";
            this.COL_Fecha.Name = "COL_Fecha";
            this.COL_Fecha.ReadOnly = true;
            this.COL_Fecha.Width = 120;
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.Color.White;
            this.BTN_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Eliminar.FlatAppearance.BorderSize = 2;
            this.BTN_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Eliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Eliminar.Image")));
            this.BTN_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Eliminar.Location = new System.Drawing.Point(984, 151);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Eliminar.TabIndex = 36;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.BackColor = System.Drawing.Color.White;
            this.BTN_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Modificar.FlatAppearance.BorderSize = 2;
            this.BTN_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Modificar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Modificar.Image")));
            this.BTN_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Modificar.Location = new System.Drawing.Point(984, 113);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Modificar.TabIndex = 35;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Modificar.UseVisualStyleBackColor = false;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.BackColor = System.Drawing.Color.White;
            this.BTN_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Agregar.FlatAppearance.BorderSize = 2;
            this.BTN_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Agregar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Agregar.Image")));
            this.BTN_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Agregar.Location = new System.Drawing.Point(984, 75);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Agregar.TabIndex = 34;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1043, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BTN_Recetas
            // 
            this.BTN_Recetas.BackColor = System.Drawing.Color.White;
            this.BTN_Recetas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Recetas.FlatAppearance.BorderSize = 2;
            this.BTN_Recetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Recetas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Recetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Recetas.Location = new System.Drawing.Point(984, 189);
            this.BTN_Recetas.Name = "BTN_Recetas";
            this.BTN_Recetas.Size = new System.Drawing.Size(111, 32);
            this.BTN_Recetas.TabIndex = 39;
            this.BTN_Recetas.Text = "Recetas";
            this.BTN_Recetas.UseVisualStyleBackColor = false;
            this.BTN_Recetas.Click += new System.EventHandler(this.BTN_Recetas_Click);
            // 
            // PANEL_Mes
            // 
            this.PANEL_Mes.Controls.Add(this.STC_MesAño);
            this.PANEL_Mes.Location = new System.Drawing.Point(12, 75);
            this.PANEL_Mes.Name = "PANEL_Mes";
            this.PANEL_Mes.Size = new System.Drawing.Size(966, 53);
            this.PANEL_Mes.TabIndex = 40;
            // 
            // STC_MesAño
            // 
            this.STC_MesAño.AutoSize = true;
            this.STC_MesAño.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_MesAño.ForeColor = System.Drawing.Color.Black;
            this.STC_MesAño.Location = new System.Drawing.Point(8, 10);
            this.STC_MesAño.Name = "STC_MesAño";
            this.STC_MesAño.Size = new System.Drawing.Size(117, 32);
            this.STC_MesAño.TabIndex = 41;
            this.STC_MesAño.Text = "Mes, Año";
            // 
            // PANEL_Flechas
            // 
            this.PANEL_Flechas.Controls.Add(this.BTN_Adelante);
            this.PANEL_Flechas.Controls.Add(this.BTN_Atras);
            this.PANEL_Flechas.Location = new System.Drawing.Point(766, 75);
            this.PANEL_Flechas.Name = "PANEL_Flechas";
            this.PANEL_Flechas.Size = new System.Drawing.Size(212, 53);
            this.PANEL_Flechas.TabIndex = 41;
            // 
            // BTN_Adelante
            // 
            this.BTN_Adelante.BackColor = System.Drawing.Color.White;
            this.BTN_Adelante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Adelante.FlatAppearance.BorderSize = 2;
            this.BTN_Adelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Adelante.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Adelante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Adelante.Location = new System.Drawing.Point(109, 6);
            this.BTN_Adelante.Name = "BTN_Adelante";
            this.BTN_Adelante.Size = new System.Drawing.Size(40, 40);
            this.BTN_Adelante.TabIndex = 42;
            this.BTN_Adelante.Text = ">";
            this.BTN_Adelante.UseVisualStyleBackColor = false;
            // 
            // BTN_Atras
            // 
            this.BTN_Atras.BackColor = System.Drawing.Color.White;
            this.BTN_Atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Atras.FlatAppearance.BorderSize = 2;
            this.BTN_Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Atras.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Atras.Location = new System.Drawing.Point(63, 6);
            this.BTN_Atras.Name = "BTN_Atras";
            this.BTN_Atras.Size = new System.Drawing.Size(40, 40);
            this.BTN_Atras.TabIndex = 41;
            this.BTN_Atras.Text = "<";
            this.BTN_Atras.UseVisualStyleBackColor = false;
            // 
            // LAYOUT_Cuerpo
            // 
            this.LAYOUT_Cuerpo.Controls.Add(this.PANEL_CuadroDia);
            this.LAYOUT_Cuerpo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LAYOUT_Cuerpo.Location = new System.Drawing.Point(12, 163);
            this.LAYOUT_Cuerpo.Name = "LAYOUT_Cuerpo";
            this.LAYOUT_Cuerpo.Size = new System.Drawing.Size(966, 441);
            this.LAYOUT_Cuerpo.TabIndex = 41;
            // 
            // PANEL_CuadroDia
            // 
            this.PANEL_CuadroDia.Controls.Add(this.STC_NumDia);
            this.PANEL_CuadroDia.Controls.Add(this.LSTC_Appointment);
            this.PANEL_CuadroDia.Location = new System.Drawing.Point(3, 3);
            this.PANEL_CuadroDia.Name = "PANEL_CuadroDia";
            this.PANEL_CuadroDia.Size = new System.Drawing.Size(132, 71);
            this.PANEL_CuadroDia.TabIndex = 0;
            // 
            // STC_NumDia
            // 
            this.STC_NumDia.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_NumDia.ForeColor = System.Drawing.Color.Black;
            this.STC_NumDia.Location = new System.Drawing.Point(3, 0);
            this.STC_NumDia.Name = "STC_NumDia";
            this.STC_NumDia.Size = new System.Drawing.Size(119, 25);
            this.STC_NumDia.TabIndex = 50;
            this.STC_NumDia.Text = "1";
            this.STC_NumDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LSTC_Appointment
            // 
            this.LSTC_Appointment.AutoSize = true;
            this.LSTC_Appointment.Location = new System.Drawing.Point(3, 25);
            this.LSTC_Appointment.Name = "LSTC_Appointment";
            this.LSTC_Appointment.Size = new System.Drawing.Size(66, 13);
            this.LSTC_Appointment.TabIndex = 51;
            this.LSTC_Appointment.TabStop = true;
            this.LSTC_Appointment.Text = "Appointment";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.STC_Sabado);
            this.panel1.Controls.Add(this.STC_Viernes);
            this.panel1.Controls.Add(this.STC_Jueves);
            this.panel1.Controls.Add(this.STC_Miercoles);
            this.panel1.Controls.Add(this.STC_Martes);
            this.panel1.Controls.Add(this.STC_Lunes);
            this.panel1.Controls.Add(this.STC_Domingo);
            this.panel1.Location = new System.Drawing.Point(12, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 36);
            this.panel1.TabIndex = 42;
            // 
            // STC_Sabado
            // 
            this.STC_Sabado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Sabado.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Sabado.ForeColor = System.Drawing.Color.Black;
            this.STC_Sabado.Location = new System.Drawing.Point(828, 0);
            this.STC_Sabado.Name = "STC_Sabado";
            this.STC_Sabado.Size = new System.Drawing.Size(138, 36);
            this.STC_Sabado.TabIndex = 49;
            this.STC_Sabado.Text = "Sábado";
            this.STC_Sabado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Viernes
            // 
            this.STC_Viernes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Viernes.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Viernes.ForeColor = System.Drawing.Color.Black;
            this.STC_Viernes.Location = new System.Drawing.Point(690, 0);
            this.STC_Viernes.Name = "STC_Viernes";
            this.STC_Viernes.Size = new System.Drawing.Size(138, 36);
            this.STC_Viernes.TabIndex = 48;
            this.STC_Viernes.Text = "Viernes";
            this.STC_Viernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Jueves
            // 
            this.STC_Jueves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Jueves.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Jueves.ForeColor = System.Drawing.Color.Black;
            this.STC_Jueves.Location = new System.Drawing.Point(552, 0);
            this.STC_Jueves.Name = "STC_Jueves";
            this.STC_Jueves.Size = new System.Drawing.Size(138, 36);
            this.STC_Jueves.TabIndex = 47;
            this.STC_Jueves.Text = "Jueves";
            this.STC_Jueves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Miercoles
            // 
            this.STC_Miercoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Miercoles.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Miercoles.ForeColor = System.Drawing.Color.Black;
            this.STC_Miercoles.Location = new System.Drawing.Point(414, 0);
            this.STC_Miercoles.Name = "STC_Miercoles";
            this.STC_Miercoles.Size = new System.Drawing.Size(138, 36);
            this.STC_Miercoles.TabIndex = 46;
            this.STC_Miercoles.Text = "Miércoles";
            this.STC_Miercoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Martes
            // 
            this.STC_Martes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Martes.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Martes.ForeColor = System.Drawing.Color.Black;
            this.STC_Martes.Location = new System.Drawing.Point(276, 0);
            this.STC_Martes.Name = "STC_Martes";
            this.STC_Martes.Size = new System.Drawing.Size(138, 36);
            this.STC_Martes.TabIndex = 45;
            this.STC_Martes.Text = "Martes";
            this.STC_Martes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Lunes
            // 
            this.STC_Lunes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Lunes.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Lunes.ForeColor = System.Drawing.Color.Black;
            this.STC_Lunes.Location = new System.Drawing.Point(138, 0);
            this.STC_Lunes.Name = "STC_Lunes";
            this.STC_Lunes.Size = new System.Drawing.Size(138, 36);
            this.STC_Lunes.TabIndex = 44;
            this.STC_Lunes.Text = "Lunes";
            this.STC_Lunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // STC_Domingo
            // 
            this.STC_Domingo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.STC_Domingo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Domingo.ForeColor = System.Drawing.Color.Black;
            this.STC_Domingo.Location = new System.Drawing.Point(0, 0);
            this.STC_Domingo.Name = "STC_Domingo";
            this.STC_Domingo.Size = new System.Drawing.Size(138, 36);
            this.STC_Domingo.TabIndex = 43;
            this.STC_Domingo.Text = "Domingo";
            this.STC_Domingo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WIN_CAT_Citas_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Cerrar = true;
            this.ClientSize = new System.Drawing.Size(1112, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PANEL_Flechas);
            this.Controls.Add(this.LAYOUT_Cuerpo);
            this.Controls.Add(this.PANEL_Mes);
            this.Controls.Add(this.BTN_Recetas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_TablaCitas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WIN_CAT_Citas_T";
            this.TituloBanner = "Citas";
            this.TituloVentana = "      DenTech - Citas";
            this.Load += new System.EventHandler(this.WIN_CAT_Citas_T_Load);
            this.Controls.SetChildIndex(this.DGV_TablaCitas, 0);
            this.Controls.SetChildIndex(this.BTN_Agregar, 0);
            this.Controls.SetChildIndex(this.BTN_Modificar, 0);
            this.Controls.SetChildIndex(this.BTN_Eliminar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.BTN_Recetas, 0);
            this.Controls.SetChildIndex(this.PANEL_Mes, 0);
            this.Controls.SetChildIndex(this.LAYOUT_Cuerpo, 0);
            this.Controls.SetChildIndex(this.PANEL_Flechas, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaCitas)).EndInit();
            this.PANEL_Mes.ResumeLayout(false);
            this.PANEL_Mes.PerformLayout();
            this.PANEL_Flechas.ResumeLayout(false);
            this.LAYOUT_Cuerpo.ResumeLayout(false);
            this.PANEL_CuadroDia.ResumeLayout(false);
            this.PANEL_CuadroDia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_TablaCitas;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Recetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Odontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Fecha;
        private System.Windows.Forms.Panel PANEL_Mes;
        private System.Windows.Forms.Panel PANEL_Flechas;
        private System.Windows.Forms.Label STC_MesAño;
        private System.Windows.Forms.Button BTN_Adelante;
        private System.Windows.Forms.Button BTN_Atras;
        private System.Windows.Forms.FlowLayoutPanel LAYOUT_Cuerpo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label STC_Domingo;
        private System.Windows.Forms.Label STC_Lunes;
        private System.Windows.Forms.FlowLayoutPanel PANEL_CuadroDia;
        private System.Windows.Forms.Label STC_Sabado;
        private System.Windows.Forms.Label STC_Viernes;
        private System.Windows.Forms.Label STC_Jueves;
        private System.Windows.Forms.Label STC_Miercoles;
        private System.Windows.Forms.Label STC_Martes;
        private System.Windows.Forms.Label STC_NumDia;
        private System.Windows.Forms.LinkLabel LSTC_Appointment;
    }
}