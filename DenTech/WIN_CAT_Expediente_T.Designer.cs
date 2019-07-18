﻿namespace DenTech
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Expediente_T));
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.DGV_TablaExpediente = new System.Windows.Forms.DataGridView();
            this.COL_IdExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Alergia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PNL_Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaExpediente)).BeginInit();
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
            this.PNL_Banner.Size = new System.Drawing.Size(1092, 44);
            this.PNL_Banner.TabIndex = 5;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(7, 6);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(135, 32);
            this.STC_Titulo.TabIndex = 4;
            this.STC_Titulo.Text = "Expediente";
            // 
            // DGV_TablaExpediente
            // 
            this.DGV_TablaExpediente.AllowUserToAddRows = false;
            this.DGV_TablaExpediente.AllowUserToDeleteRows = false;
            this.DGV_TablaExpediente.AllowUserToOrderColumns = true;
            this.DGV_TablaExpediente.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaExpediente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaExpediente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaExpediente.ColumnHeadersHeight = 30;
            this.DGV_TablaExpediente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdExpediente,
            this.COL_IdEmpleado,
            this.COL_Paciente,
            this.COL_Enfermedad,
            this.COL_Alergia,
            this.COL_Fecha});
            this.DGV_TablaExpediente.EnableHeadersVisualStyles = false;
            this.DGV_TablaExpediente.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaExpediente.Location = new System.Drawing.Point(13, 51);
            this.DGV_TablaExpediente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaExpediente.Name = "DGV_TablaExpediente";
            this.DGV_TablaExpediente.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaExpediente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaExpediente.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaExpediente.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.Color.White;
            this.BTN_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Eliminar.FlatAppearance.BorderSize = 2;
            this.BTN_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Eliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Eliminar.Image")));
            this.BTN_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Eliminar.Location = new System.Drawing.Point(964, 127);
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
            this.BTN_Modificar.Location = new System.Drawing.Point(964, 89);
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
            this.BTN_Agregar.Location = new System.Drawing.Point(964, 51);
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
            this.BTN_Cerrar.Location = new System.Drawing.Point(1023, 342);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cerrar.TabIndex = 40;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(964, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 41;
            this.button1.Text = "General";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(964, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 32);
            this.button2.TabIndex = 42;
            this.button2.Text = "Dental";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // WIN_CAT_Expediente_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1089, 406);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_TablaExpediente);
            this.Controls.Add(this.PNL_Banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_CAT_Expediente_T";
            this.Text = "DenTech - Catálogo Expediente";
            this.Load += new System.EventHandler(this.WIN_CAT_Expediente_T_Load);
            this.PNL_Banner.ResumeLayout(false);
            this.PNL_Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaExpediente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.DataGridView DGV_TablaExpediente;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Paciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Enfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Alergia;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}