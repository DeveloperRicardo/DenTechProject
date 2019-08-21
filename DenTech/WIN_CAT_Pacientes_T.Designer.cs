namespace DenTech
{
    partial class WIN_CAT_Pacientes_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Pacientes_T));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.DGV_TablaPacientes = new System.Windows.Forms.DataGridView();
            this.COL_IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_TelEmergencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaPacientes)).BeginInit();
            this.SuspendLayout();
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
            this.BTN_Eliminar.Location = new System.Drawing.Point(967, 209);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Eliminar.TabIndex = 3;
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
            this.BTN_Modificar.Location = new System.Drawing.Point(967, 171);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Modificar.TabIndex = 2;
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
            this.BTN_Agregar.Location = new System.Drawing.Point(967, 133);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // DGV_TablaPacientes
            // 
            this.DGV_TablaPacientes.AllowUserToAddRows = false;
            this.DGV_TablaPacientes.AllowUserToDeleteRows = false;
            this.DGV_TablaPacientes.AllowUserToOrderColumns = true;
            this.DGV_TablaPacientes.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaPacientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaPacientes.ColumnHeadersHeight = 30;
            this.DGV_TablaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdPaciente,
            this.COL_Edad,
            this.COL_Telefono,
            this.COL_TelEmergencia,
            this.COL_Matricula,
            this.COL_Nombre});
            this.DGV_TablaPacientes.EnableHeadersVisualStyles = false;
            this.DGV_TablaPacientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaPacientes.Location = new System.Drawing.Point(21, 133);
            this.DGV_TablaPacientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaPacientes.Name = "DGV_TablaPacientes";
            this.DGV_TablaPacientes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaPacientes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaPacientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TablaPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaPacientes.Size = new System.Drawing.Size(940, 368);
            this.DGV_TablaPacientes.TabIndex = 0;
            // 
            // COL_IdPaciente
            // 
            this.COL_IdPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COL_IdPaciente.DataPropertyName = "Id_Paciente";
            this.COL_IdPaciente.Frozen = true;
            this.COL_IdPaciente.HeaderText = "IdPaciente";
            this.COL_IdPaciente.Name = "COL_IdPaciente";
            this.COL_IdPaciente.ReadOnly = true;
            this.COL_IdPaciente.Visible = false;
            this.COL_IdPaciente.Width = 112;
            // 
            // COL_Edad
            // 
            this.COL_Edad.DataPropertyName = "Edad";
            this.COL_Edad.HeaderText = "Edad";
            this.COL_Edad.Name = "COL_Edad";
            this.COL_Edad.ReadOnly = true;
            this.COL_Edad.Visible = false;
            this.COL_Edad.Width = 50;
            // 
            // COL_Telefono
            // 
            this.COL_Telefono.DataPropertyName = "Telefono";
            this.COL_Telefono.HeaderText = "Teléfono";
            this.COL_Telefono.Name = "COL_Telefono";
            this.COL_Telefono.ReadOnly = true;
            this.COL_Telefono.Visible = false;
            this.COL_Telefono.Width = 110;
            // 
            // COL_TelEmergencia
            // 
            this.COL_TelEmergencia.DataPropertyName = "Tel_Emergencia";
            this.COL_TelEmergencia.HeaderText = "Tel. Emer.";
            this.COL_TelEmergencia.Name = "COL_TelEmergencia";
            this.COL_TelEmergencia.ReadOnly = true;
            this.COL_TelEmergencia.Visible = false;
            this.COL_TelEmergencia.Width = 110;
            // 
            // COL_Matricula
            // 
            this.COL_Matricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.COL_Matricula.DataPropertyName = "Matricula";
            this.COL_Matricula.HeaderText = "Matricula";
            this.COL_Matricula.Name = "COL_Matricula";
            this.COL_Matricula.ReadOnly = true;
            this.COL_Matricula.Width = 103;
            // 
            // COL_Nombre
            // 
            this.COL_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COL_Nombre.DataPropertyName = "NombreCompleto";
            this.COL_Nombre.HeaderText = "Nombre";
            this.COL_Nombre.Name = "COL_Nombre";
            this.COL_Nombre.ReadOnly = true;
            // 
            // WIN_CAT_Pacientes_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 590);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_TablaPacientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_CAT_Pacientes_T";
            this.TituloBanner = "Pacientes";
            this.Load += new System.EventHandler(this.WIN_CAT_Pacientes_T_Load);
            this.Controls.SetChildIndex(this.DGV_TablaPacientes, 0);
            this.Controls.SetChildIndex(this.BTN_Agregar, 0);
            this.Controls.SetChildIndex(this.BTN_Modificar, 0);
            this.Controls.SetChildIndex(this.BTN_Eliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.DataGridView DGV_TablaPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_TelEmergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Nombre;
    }
}