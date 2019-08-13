namespace DenTech
{
    partial class WIN_CAT_Expediente_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Expediente_T));
            this.DGV_TablaExpediente = new System.Windows.Forms.DataGridView();
            this.COL_IdExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Alergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.BTN_General = new System.Windows.Forms.Button();
            this.BTN_Dental = new System.Windows.Forms.Button();
            this.Menu_General = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menu_Dental = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OP_Odontograma = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaExpediente)).BeginInit();
            this.Menu_Dental.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_TablaExpediente
            // 
            this.DGV_TablaExpediente.AllowUserToAddRows = false;
            this.DGV_TablaExpediente.AllowUserToDeleteRows = false;
            this.DGV_TablaExpediente.AllowUserToOrderColumns = true;
            this.DGV_TablaExpediente.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaExpediente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaExpediente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_TablaExpediente.ColumnHeadersHeight = 30;
            this.DGV_TablaExpediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdExpediente,
            this.COL_IdEmpleado,
            this.COL_Paciente,
            this.COL_Enfermedad,
            this.COL_Alergia,
            this.COL_Fecha,
            this.IdPaciente});
            this.DGV_TablaExpediente.EnableHeadersVisualStyles = false;
            this.DGV_TablaExpediente.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaExpediente.Location = new System.Drawing.Point(13, 76);
            this.DGV_TablaExpediente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaExpediente.Name = "DGV_TablaExpediente";
            this.DGV_TablaExpediente.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaExpediente.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_TablaExpediente.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaExpediente.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_TablaExpediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaExpediente.Size = new System.Drawing.Size(945, 215);
            this.DGV_TablaExpediente.TabIndex = 34;
            // 
            // COL_IdExpediente
            // 
            this.COL_IdExpediente.DataPropertyName = "Id_Expediente";
            this.COL_IdExpediente.Frozen = true;
            this.COL_IdExpediente.HeaderText = "IdExpediente";
            this.COL_IdExpediente.Name = "COL_IdExpediente";
            this.COL_IdExpediente.ReadOnly = true;
            this.COL_IdExpediente.Visible = false;
            // 
            // COL_IdEmpleado
            // 
            this.COL_IdEmpleado.DataPropertyName = "Odontologo";
            this.COL_IdEmpleado.Frozen = true;
            this.COL_IdEmpleado.HeaderText = "Odontólogo";
            this.COL_IdEmpleado.Name = "COL_IdEmpleado";
            this.COL_IdEmpleado.ReadOnly = true;
            this.COL_IdEmpleado.Width = 250;
            // 
            // COL_Paciente
            // 
            this.COL_Paciente.DataPropertyName = "Paciente";
            this.COL_Paciente.Frozen = true;
            this.COL_Paciente.HeaderText = "Paciente";
            this.COL_Paciente.Name = "COL_Paciente";
            this.COL_Paciente.ReadOnly = true;
            this.COL_Paciente.Width = 250;
            // 
            // COL_Enfermedad
            // 
            this.COL_Enfermedad.DataPropertyName = "Enfermedad";
            this.COL_Enfermedad.Frozen = true;
            this.COL_Enfermedad.HeaderText = "Enfermedad(es)";
            this.COL_Enfermedad.Name = "COL_Enfermedad";
            this.COL_Enfermedad.ReadOnly = true;
            this.COL_Enfermedad.Width = 170;
            // 
            // COL_Alergia
            // 
            this.COL_Alergia.DataPropertyName = "Alergia";
            this.COL_Alergia.Frozen = true;
            this.COL_Alergia.HeaderText = "Alergia(s)";
            this.COL_Alergia.Name = "COL_Alergia";
            this.COL_Alergia.ReadOnly = true;
            this.COL_Alergia.Width = 170;
            // 
            // COL_Fecha
            // 
            this.COL_Fecha.DataPropertyName = "Fecha";
            this.COL_Fecha.Frozen = true;
            this.COL_Fecha.HeaderText = "Fecha";
            this.COL_Fecha.Name = "COL_Fecha";
            this.COL_Fecha.ReadOnly = true;
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
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.Color.White;
            this.BTN_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Eliminar.FlatAppearance.BorderSize = 2;
            this.BTN_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Eliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Eliminar.Image")));
            this.BTN_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Eliminar.Location = new System.Drawing.Point(964, 152);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Eliminar.TabIndex = 39;
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
            this.BTN_Modificar.Location = new System.Drawing.Point(964, 114);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Modificar.TabIndex = 38;
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
            this.BTN_Agregar.Location = new System.Drawing.Point(964, 76);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Agregar.TabIndex = 37;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cerrar.Image")));
            this.BTN_Cerrar.Location = new System.Drawing.Point(1023, 367);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cerrar.TabIndex = 40;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_General
            // 
            this.BTN_General.BackColor = System.Drawing.Color.White;
            this.BTN_General.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_General.FlatAppearance.BorderSize = 2;
            this.BTN_General.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_General.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_General.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_General.Location = new System.Drawing.Point(964, 190);
            this.BTN_General.Name = "BTN_General";
            this.BTN_General.Size = new System.Drawing.Size(111, 32);
            this.BTN_General.TabIndex = 41;
            this.BTN_General.Text = "General";
            this.BTN_General.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_General.UseVisualStyleBackColor = false;
            this.BTN_General.Click += new System.EventHandler(this.BTN_General_Click);
            // 
            // BTN_Dental
            // 
            this.BTN_Dental.BackColor = System.Drawing.Color.White;
            this.BTN_Dental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Dental.FlatAppearance.BorderSize = 2;
            this.BTN_Dental.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Dental.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Dental.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Dental.Location = new System.Drawing.Point(964, 228);
            this.BTN_Dental.Name = "BTN_Dental";
            this.BTN_Dental.Size = new System.Drawing.Size(111, 32);
            this.BTN_Dental.TabIndex = 42;
            this.BTN_Dental.Text = "Dental";
            this.BTN_Dental.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Dental.UseVisualStyleBackColor = false;
            this.BTN_Dental.Click += new System.EventHandler(this.BTN_Dental_Click);
            // 
            // Menu_General
            // 
            this.Menu_General.Name = "Menu_General";
            this.Menu_General.Size = new System.Drawing.Size(181, 26);
            // 
            // Menu_Dental
            // 
            this.Menu_Dental.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OP_Odontograma});
            this.Menu_Dental.Name = "contextMenuStrip1";
            this.Menu_Dental.Size = new System.Drawing.Size(150, 26);
            // 
            // OP_Odontograma
            // 
            this.OP_Odontograma.Name = "OP_Odontograma";
            this.OP_Odontograma.Size = new System.Drawing.Size(149, 22);
            this.OP_Odontograma.Text = "Odontograma";
            this.OP_Odontograma.Click += new System.EventHandler(this.OP_Odontograma_Click);
            // 
            // WIN_CAT_Expediente_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 429);
            this.Controls.Add(this.BTN_Dental);
            this.Controls.Add(this.BTN_General);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_TablaExpediente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_CAT_Expediente_T";
            this.Load += new System.EventHandler(this.WIN_CAT_Expediente_T_Load);
            this.Controls.SetChildIndex(this.DGV_TablaExpediente, 0);
            this.Controls.SetChildIndex(this.BTN_Agregar, 0);
            this.Controls.SetChildIndex(this.BTN_Modificar, 0);
            this.Controls.SetChildIndex(this.BTN_Eliminar, 0);
            this.Controls.SetChildIndex(this.BTN_Cerrar, 0);
            this.Controls.SetChildIndex(this.BTN_General, 0);
            this.Controls.SetChildIndex(this.BTN_Dental, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaExpediente)).EndInit();
            this.Menu_Dental.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_TablaExpediente;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Button BTN_General;
        private System.Windows.Forms.Button BTN_Dental;
        private System.Windows.Forms.ContextMenuStrip Menu_General;
        private System.Windows.Forms.ContextMenuStrip Menu_Dental;
        private System.Windows.Forms.ToolStripMenuItem OP_Odontograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Enfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Alergia;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
    }
}