namespace DenTech
{
    partial class WIN_CAT_Odontograma_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Odontograma_T));
            this.DGV_TablaNombre = new System.Windows.Forms.DataGridView();
            this.COL_IdOdontograma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANEL_Botones = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaNombre)).BeginInit();
            this.PANEL_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_TablaNombre
            // 
            this.DGV_TablaNombre.AllowUserToAddRows = false;
            this.DGV_TablaNombre.AllowUserToDeleteRows = false;
            this.DGV_TablaNombre.AllowUserToOrderColumns = true;
            this.DGV_TablaNombre.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaNombre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaNombre.ColumnHeadersHeight = 30;
            this.DGV_TablaNombre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdOdontograma,
            this.COL_Descripcion,
            this.COL_FechaRegistro});
            this.DGV_TablaNombre.EnableHeadersVisualStyles = false;
            this.DGV_TablaNombre.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaNombre.Location = new System.Drawing.Point(8, 76);
            this.DGV_TablaNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaNombre.Name = "DGV_TablaNombre";
            this.DGV_TablaNombre.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaNombre.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaNombre.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaNombre.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TablaNombre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaNombre.Size = new System.Drawing.Size(539, 215);
            this.DGV_TablaNombre.TabIndex = 33;
            // 
            // COL_IdOdontograma
            // 
            this.COL_IdOdontograma.DataPropertyName = "Id_Odontograma";
            this.COL_IdOdontograma.Frozen = true;
            this.COL_IdOdontograma.HeaderText = "IdOdontograma";
            this.COL_IdOdontograma.Name = "COL_IdOdontograma";
            this.COL_IdOdontograma.ReadOnly = true;
            this.COL_IdOdontograma.Visible = false;
            // 
            // COL_Descripcion
            // 
            this.COL_Descripcion.DataPropertyName = "Descripcion";
            this.COL_Descripcion.Frozen = true;
            this.COL_Descripcion.HeaderText = "Descripción";
            this.COL_Descripcion.Name = "COL_Descripcion";
            this.COL_Descripcion.ReadOnly = true;
            this.COL_Descripcion.Width = 370;
            // 
            // COL_FechaRegistro
            // 
            this.COL_FechaRegistro.DataPropertyName = "Fecha_Registro";
            this.COL_FechaRegistro.Frozen = true;
            this.COL_FechaRegistro.HeaderText = "Fecha de Registro";
            this.COL_FechaRegistro.Name = "COL_FechaRegistro";
            this.COL_FechaRegistro.ReadOnly = true;
            this.COL_FechaRegistro.Width = 538;
            // 
            // PANEL_Botones
            // 
            this.PANEL_Botones.Controls.Add(this.BTN_Agregar);
            this.PANEL_Botones.Controls.Add(this.BTN_Modificar);
            this.PANEL_Botones.Controls.Add(this.BTN_Eliminar);
            this.PANEL_Botones.Location = new System.Drawing.Point(553, 76);
            this.PANEL_Botones.Name = "PANEL_Botones";
            this.PANEL_Botones.Size = new System.Drawing.Size(117, 115);
            this.PANEL_Botones.TabIndex = 47;
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
            this.BTN_Agregar.Location = new System.Drawing.Point(3, 3);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
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
            this.BTN_Modificar.Location = new System.Drawing.Point(3, 41);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Modificar.TabIndex = 2;
            this.BTN_Modificar.Text = "Modificar";
            this.BTN_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Modificar.UseVisualStyleBackColor = false;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
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
            this.BTN_Eliminar.Location = new System.Drawing.Point(3, 79);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Eliminar.TabIndex = 3;
            this.BTN_Eliminar.Text = "Eliminar";
            this.BTN_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cancelar.FlatAppearance.BorderSize = 0;
            this.BTN_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancelar.Image")));
            this.BTN_Cancelar.Location = new System.Drawing.Point(611, 307);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cancelar.TabIndex = 4;
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // WIN_CAT_Odontograma_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Cerrar = true;
            this.ClientSize = new System.Drawing.Size(679, 368);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.PANEL_Botones);
            this.Controls.Add(this.DGV_TablaNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_CAT_Odontograma_T";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TituloBanner = "Odontograma";
            this.TituloVentana = "      DenTech - Odontograma";
            this.Load += new System.EventHandler(this.WIN_CAT_Odontograma_T_Load);
            this.Controls.SetChildIndex(this.DGV_TablaNombre, 0);
            this.Controls.SetChildIndex(this.PANEL_Botones, 0);
            this.Controls.SetChildIndex(this.BTN_Cancelar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaNombre)).EndInit();
            this.PANEL_Botones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_TablaNombre;
        private System.Windows.Forms.FlowLayoutPanel PANEL_Botones;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdOdontograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_FechaRegistro;
    }
}