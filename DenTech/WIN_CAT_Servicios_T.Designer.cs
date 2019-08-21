namespace DenTech
{
    partial class WIN_CAT_Servicios_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Servicios_T));
            this.DGV_TablaServicios = new System.Windows.Forms.DataGridView();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.COL_IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TablaServicios
            // 
            this.DGV_TablaServicios.AllowUserToAddRows = false;
            this.DGV_TablaServicios.AllowUserToDeleteRows = false;
            this.DGV_TablaServicios.AllowUserToOrderColumns = true;
            this.DGV_TablaServicios.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaServicios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaServicios.ColumnHeadersHeight = 30;
            this.DGV_TablaServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdServicio,
            this.COL_Servicio,
            this.COL_Precio});
            this.DGV_TablaServicios.EnableHeadersVisualStyles = false;
            this.DGV_TablaServicios.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaServicios.Location = new System.Drawing.Point(21, 133);
            this.DGV_TablaServicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaServicios.Name = "DGV_TablaServicios";
            this.DGV_TablaServicios.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaServicios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaServicios.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaServicios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TablaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaServicios.Size = new System.Drawing.Size(940, 368);
            this.DGV_TablaServicios.TabIndex = 33;
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
            this.BTN_Modificar.Location = new System.Drawing.Point(967, 171);
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
            this.BTN_Agregar.Location = new System.Drawing.Point(967, 133);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Agregar.TabIndex = 34;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // COL_IdServicio
            // 
            this.COL_IdServicio.DataPropertyName = "Id_Servicios";
            this.COL_IdServicio.Frozen = true;
            this.COL_IdServicio.HeaderText = "IdServicio";
            this.COL_IdServicio.Name = "COL_IdServicio";
            this.COL_IdServicio.ReadOnly = true;
            this.COL_IdServicio.Visible = false;
            // 
            // COL_Servicio
            // 
            this.COL_Servicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COL_Servicio.DataPropertyName = "Descripcion";
            this.COL_Servicio.HeaderText = "Servicio";
            this.COL_Servicio.Name = "COL_Servicio";
            this.COL_Servicio.ReadOnly = true;
            // 
            // COL_Precio
            // 
            this.COL_Precio.DataPropertyName = "Precio";
            this.COL_Precio.HeaderText = "Precio";
            this.COL_Precio.Name = "COL_Precio";
            this.COL_Precio.ReadOnly = true;
            this.COL_Precio.Width = 150;
            // 
            // WIN_CAT_Servicios_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 590);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.DGV_TablaServicios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WIN_CAT_Servicios_T";
            this.TituloBanner = "Servicios";
            this.Load += new System.EventHandler(this.WIN_CAT_Servicios_T_Load);
            this.Controls.SetChildIndex(this.DGV_TablaServicios, 0);
            this.Controls.SetChildIndex(this.BTN_Agregar, 0);
            this.Controls.SetChildIndex(this.BTN_Modificar, 0);
            this.Controls.SetChildIndex(this.BTN_Eliminar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_TablaServicios;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Precio;
    }
}