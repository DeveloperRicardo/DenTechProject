namespace DenTech
{
    partial class WIN_CAT_ArchivosAdjuntos_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_ArchivosAdjuntos_T));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EDT_Ruta = new System.Windows.Forms.TextBox();
            this.STC_RutaArchivo = new System.Windows.Forms.Label();
            this.BTN_Lupa = new System.Windows.Forms.Button();
            this.DGV_Tabla = new System.Windows.Forms.DataGridView();
            this.COL_IdTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_RutaLogica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Descargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // EDT_Ruta
            // 
            this.EDT_Ruta.Enabled = false;
            this.EDT_Ruta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Ruta.Location = new System.Drawing.Point(241, 99);
            this.EDT_Ruta.Name = "EDT_Ruta";
            this.EDT_Ruta.Size = new System.Drawing.Size(516, 25);
            this.EDT_Ruta.TabIndex = 48;
            // 
            // STC_RutaArchivo
            // 
            this.STC_RutaArchivo.AutoSize = true;
            this.STC_RutaArchivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_RutaArchivo.Location = new System.Drawing.Point(141, 100);
            this.STC_RutaArchivo.Name = "STC_RutaArchivo";
            this.STC_RutaArchivo.Size = new System.Drawing.Size(96, 20);
            this.STC_RutaArchivo.TabIndex = 47;
            this.STC_RutaArchivo.Text = "Ruta Archivo:";
            // 
            // BTN_Lupa
            // 
            this.BTN_Lupa.BackColor = System.Drawing.Color.White;
            this.BTN_Lupa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Lupa.FlatAppearance.BorderSize = 2;
            this.BTN_Lupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Lupa.Font = new System.Drawing.Font("Rockwell", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Lupa.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Lupa.Image")));
            this.BTN_Lupa.Location = new System.Drawing.Point(763, 99);
            this.BTN_Lupa.Name = "BTN_Lupa";
            this.BTN_Lupa.Size = new System.Drawing.Size(29, 25);
            this.BTN_Lupa.TabIndex = 0;
            this.BTN_Lupa.UseVisualStyleBackColor = false;
            this.BTN_Lupa.Click += new System.EventHandler(this.BTN_Lupa_Click);
            // 
            // DGV_Tabla
            // 
            this.DGV_Tabla.AllowUserToAddRows = false;
            this.DGV_Tabla.AllowUserToDeleteRows = false;
            this.DGV_Tabla.AllowUserToOrderColumns = true;
            this.DGV_Tabla.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Tabla.ColumnHeadersHeight = 30;
            this.DGV_Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdTabla,
            this.COL_Nombre,
            this.COL_RutaLogica});
            this.DGV_Tabla.EnableHeadersVisualStyles = false;
            this.DGV_Tabla.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_Tabla.Location = new System.Drawing.Point(143, 131);
            this.DGV_Tabla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Tabla.Name = "DGV_Tabla";
            this.DGV_Tabla.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Tabla.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Tabla.Size = new System.Drawing.Size(806, 327);
            this.DGV_Tabla.TabIndex = 50;
            // 
            // COL_IdTabla
            // 
            this.COL_IdTabla.DataPropertyName = "Id";
            this.COL_IdTabla.Frozen = true;
            this.COL_IdTabla.HeaderText = "IdTabla";
            this.COL_IdTabla.Name = "COL_IdTabla";
            this.COL_IdTabla.ReadOnly = true;
            this.COL_IdTabla.Visible = false;
            // 
            // COL_Nombre
            // 
            this.COL_Nombre.DataPropertyName = "Nombre";
            this.COL_Nombre.Frozen = true;
            this.COL_Nombre.HeaderText = "Nombre";
            this.COL_Nombre.Name = "COL_Nombre";
            this.COL_Nombre.ReadOnly = true;
            this.COL_Nombre.Width = 800;
            // 
            // COL_RutaLogica
            // 
            this.COL_RutaLogica.DataPropertyName = "RutaLogica";
            this.COL_RutaLogica.Frozen = true;
            this.COL_RutaLogica.HeaderText = "Ruta";
            this.COL_RutaLogica.Name = "COL_RutaLogica";
            this.COL_RutaLogica.ReadOnly = true;
            this.COL_RutaLogica.Visible = false;
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
            this.BTN_Eliminar.Location = new System.Drawing.Point(838, 465);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Eliminar.TabIndex = 3;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
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
            this.BTN_Agregar.Location = new System.Drawing.Point(798, 95);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(151, 32);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Cargar Archivo";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // BTN_Descargar
            // 
            this.BTN_Descargar.BackColor = System.Drawing.Color.White;
            this.BTN_Descargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Descargar.FlatAppearance.BorderSize = 2;
            this.BTN_Descargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Descargar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Descargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Descargar.Location = new System.Drawing.Point(721, 465);
            this.BTN_Descargar.Name = "BTN_Descargar";
            this.BTN_Descargar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Descargar.TabIndex = 2;
            this.BTN_Descargar.Text = "Abrir";
            this.BTN_Descargar.UseVisualStyleBackColor = false;
            this.BTN_Descargar.Visible = false;
            this.BTN_Descargar.Click += new System.EventHandler(this.BTN_Descargar_Click);
            // 
            // WIN_CAT_ArchivosAdjuntos_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cerrar = true;
            this.ClientSize = new System.Drawing.Size(1090, 590);
            this.Controls.Add(this.BTN_Descargar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_Tabla);
            this.Controls.Add(this.BTN_Lupa);
            this.Controls.Add(this.EDT_Ruta);
            this.Controls.Add(this.STC_RutaArchivo);
            this.Name = "WIN_CAT_ArchivosAdjuntos_T";
            this.TituloBanner = "Archivos Adjuntos";
            this.TituloVentana = "      DenTech - Archivos Adjuntos";
            this.Load += new System.EventHandler(this.WIN_CAT_ArchivosAdjuntos_T_Load);
            this.Controls.SetChildIndex(this.STC_RutaArchivo, 0);
            this.Controls.SetChildIndex(this.EDT_Ruta, 0);
            this.Controls.SetChildIndex(this.BTN_Lupa, 0);
            this.Controls.SetChildIndex(this.DGV_Tabla, 0);
            this.Controls.SetChildIndex(this.BTN_Agregar, 0);
            this.Controls.SetChildIndex(this.BTN_Eliminar, 0);
            this.Controls.SetChildIndex(this.BTN_Descargar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EDT_Ruta;
        private System.Windows.Forms.Label STC_RutaArchivo;
        private System.Windows.Forms.Button BTN_Lupa;
        private System.Windows.Forms.DataGridView DGV_Tabla;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_RutaLogica;
        private System.Windows.Forms.Button BTN_Descargar;
    }
}