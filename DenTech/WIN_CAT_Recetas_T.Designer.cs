namespace DenTech
{
    partial class WIN_CAT_Recetas_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Recetas_T));
            this.DGV_TablaReceta = new System.Windows.Forms.DataGridView();
            this.COL_IdTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Diag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Boton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TablaReceta
            // 
            this.DGV_TablaReceta.AllowUserToAddRows = false;
            this.DGV_TablaReceta.AllowUserToDeleteRows = false;
            this.DGV_TablaReceta.AllowUserToOrderColumns = true;
            this.DGV_TablaReceta.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaReceta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaReceta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaReceta.ColumnHeadersHeight = 30;
            this.DGV_TablaReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdTabla,
            this.Diagnostico,
            this.COL_Columna2,
            this.Column1,
            this.Fecha_Inicio,
            this.Fecha_Final,
            this.Fecha_Diag});
            this.DGV_TablaReceta.EnableHeadersVisualStyles = false;
            this.DGV_TablaReceta.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaReceta.Location = new System.Drawing.Point(12, 76);
            this.DGV_TablaReceta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaReceta.Name = "DGV_TablaReceta";
            this.DGV_TablaReceta.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaReceta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaReceta.RowHeadersVisible = false;
            this.DGV_TablaReceta.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaReceta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TablaReceta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaReceta.Size = new System.Drawing.Size(610, 284);
            this.DGV_TablaReceta.TabIndex = 33;
            // 
            // COL_IdTabla
            // 
            this.COL_IdTabla.DataPropertyName = "Id_Receta";
            this.COL_IdTabla.Frozen = true;
            this.COL_IdTabla.HeaderText = "IdTabla";
            this.COL_IdTabla.MinimumWidth = 6;
            this.COL_IdTabla.Name = "COL_IdTabla";
            this.COL_IdTabla.ReadOnly = true;
            this.COL_IdTabla.Visible = false;
            this.COL_IdTabla.Width = 125;
            // 
            // Diagnostico
            // 
            this.Diagnostico.DataPropertyName = "Diagnostico";
            this.Diagnostico.Frozen = true;
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.MinimumWidth = 6;
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            this.Diagnostico.Width = 125;
            // 
            // COL_Columna2
            // 
            this.COL_Columna2.DataPropertyName = "Medicamento";
            this.COL_Columna2.Frozen = true;
            this.COL_Columna2.HeaderText = "Medicamento";
            this.COL_Columna2.MinimumWidth = 6;
            this.COL_Columna2.Name = "COL_Columna2";
            this.COL_Columna2.ReadOnly = true;
            this.COL_Columna2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tratamiento";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Tratamiento";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Fecha_Inicio
            // 
            this.Fecha_Inicio.DataPropertyName = "Fecha_Inicio";
            this.Fecha_Inicio.Frozen = true;
            this.Fecha_Inicio.HeaderText = "Fecha Inicio";
            this.Fecha_Inicio.MinimumWidth = 6;
            this.Fecha_Inicio.Name = "Fecha_Inicio";
            this.Fecha_Inicio.ReadOnly = true;
            this.Fecha_Inicio.Width = 125;
            // 
            // Fecha_Final
            // 
            this.Fecha_Final.DataPropertyName = "Fecha_Final";
            this.Fecha_Final.Frozen = true;
            this.Fecha_Final.HeaderText = "Fecha Final";
            this.Fecha_Final.MinimumWidth = 6;
            this.Fecha_Final.Name = "Fecha_Final";
            this.Fecha_Final.ReadOnly = true;
            this.Fecha_Final.Width = 125;
            // 
            // Fecha_Diag
            // 
            this.Fecha_Diag.DataPropertyName = "Fecha_Diag";
            this.Fecha_Diag.Frozen = true;
            this.Fecha_Diag.HeaderText = "Fecha Diag";
            this.Fecha_Diag.MinimumWidth = 6;
            this.Fecha_Diag.Name = "Fecha_Diag";
            this.Fecha_Diag.ReadOnly = true;
            this.Fecha_Diag.Width = 125;
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
            this.BTN_Agregar.Location = new System.Drawing.Point(628, 76);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // BTN_Boton
            // 
            this.BTN_Boton.BackColor = System.Drawing.Color.White;
            this.BTN_Boton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Boton.FlatAppearance.BorderSize = 2;
            this.BTN_Boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Boton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Boton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Boton.Location = new System.Drawing.Point(628, 114);
            this.BTN_Boton.Name = "BTN_Boton";
            this.BTN_Boton.Size = new System.Drawing.Size(111, 32);
            this.BTN_Boton.TabIndex = 2;
            this.BTN_Boton.Text = "Reporte";
            this.BTN_Boton.UseVisualStyleBackColor = false;
            this.BTN_Boton.Click += new System.EventHandler(this.BTN_Boton_Click);
            // 
            // WIN_CAT_Recetas_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Cerrar = true;
            this.ClientSize = new System.Drawing.Size(759, 371);
            this.Controls.Add(this.BTN_Boton);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_TablaReceta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WIN_CAT_Recetas_T";
            this.TituloBanner = "Recetas";
            this.TituloVentana = "      DenTech - Recetas";
            this.Load += new System.EventHandler(this.WIN_CAT_Recetas_T_Load);
            this.Controls.SetChildIndex(this.DGV_TablaReceta, 0);
            this.Controls.SetChildIndex(this.BTN_Agregar, 0);
            this.Controls.SetChildIndex(this.BTN_Boton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaReceta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_TablaReceta;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Boton;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Final;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Diag;
    }
}