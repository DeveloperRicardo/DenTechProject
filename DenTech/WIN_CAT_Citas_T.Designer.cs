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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Citas_T));
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.DGV_TablaCitas = new System.Windows.Forms.DataGridView();
            this.COL_IdCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Odontologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PNL_Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Banner
            // 
            this.PNL_Banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Banner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PNL_Banner.Controls.Add(this.STC_Titulo);
            this.PNL_Banner.Location = new System.Drawing.Point(0, 0);
            this.PNL_Banner.Name = "PNL_Banner";
            this.PNL_Banner.Size = new System.Drawing.Size(769, 44);
            this.PNL_Banner.TabIndex = 4;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(7, 6);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(68, 32);
            this.STC_Titulo.TabIndex = 4;
            this.STC_Titulo.Text = "Citas";
            // 
            // DGV_TablaCitas
            // 
            this.DGV_TablaCitas.AllowUserToAddRows = false;
            this.DGV_TablaCitas.AllowUserToDeleteRows = false;
            this.DGV_TablaCitas.AllowUserToOrderColumns = true;
            this.DGV_TablaCitas.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaCitas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_TablaCitas.ColumnHeadersHeight = 30;
            this.DGV_TablaCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdCita,
            this.COL_Odontologo,
            this.COL_Paciente,
            this.COL_Fecha});
            this.DGV_TablaCitas.EnableHeadersVisualStyles = false;
            this.DGV_TablaCitas.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaCitas.Location = new System.Drawing.Point(12, 51);
            this.DGV_TablaCitas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaCitas.Name = "DGV_TablaCitas";
            this.DGV_TablaCitas.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_TablaCitas.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaCitas.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_TablaCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaCitas.Size = new System.Drawing.Size(625, 211);
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
            this.BTN_Eliminar.Location = new System.Drawing.Point(643, 127);
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
            this.BTN_Modificar.Location = new System.Drawing.Point(643, 89);
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
            this.BTN_Agregar.Location = new System.Drawing.Point(643, 51);
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
            this.button1.Location = new System.Drawing.Point(702, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // WIN_CAT_Citas_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_TablaCitas);
            this.Controls.Add(this.PNL_Banner);
            this.Name = "WIN_CAT_Citas_T";
            this.Text = "DenTech - Catálogo Citas";
            this.Load += new System.EventHandler(this.WIN_CAT_Citas_T_Load);
            this.PNL_Banner.ResumeLayout(false);
            this.PNL_Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.DataGridView DGV_TablaCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Odontologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Fecha;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button button1;
    }
}