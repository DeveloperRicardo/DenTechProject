namespace DenTech
{
    partial class WIN_CAT_Inventario_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Inventario_T));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.DGV_TablaProducto = new System.Windows.Forms.DataGridView();
            this.COL_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PANEL_Botones = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Aumentar = new System.Windows.Forms.Button();
            this.BTN_Disminuir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaProducto)).BeginInit();
            this.PANEL_Botones.SuspendLayout();
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
            this.BTN_Eliminar.Location = new System.Drawing.Point(3, 79);
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
            this.BTN_Modificar.Location = new System.Drawing.Point(3, 41);
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
            this.BTN_Agregar.Location = new System.Drawing.Point(3, 3);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // DGV_TablaProducto
            // 
            this.DGV_TablaProducto.AllowUserToAddRows = false;
            this.DGV_TablaProducto.AllowUserToDeleteRows = false;
            this.DGV_TablaProducto.AllowUserToOrderColumns = true;
            this.DGV_TablaProducto.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaProducto.ColumnHeadersHeight = 30;
            this.DGV_TablaProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_Inventario,
            this.COL_Producto,
            this.COL_FechaInicio,
            this.COL_FechaFinal,
            this.COL_Cantidad});
            this.DGV_TablaProducto.EnableHeadersVisualStyles = false;
            this.DGV_TablaProducto.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaProducto.Location = new System.Drawing.Point(21, 133);
            this.DGV_TablaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaProducto.Name = "DGV_TablaProducto";
            this.DGV_TablaProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaProducto.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaProducto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TablaProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaProducto.Size = new System.Drawing.Size(940, 368);
            this.DGV_TablaProducto.TabIndex = 45;
            this.DGV_TablaProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_TablaProducto_CellClick);
            // 
            // COL_Inventario
            // 
            this.COL_Inventario.DataPropertyName = "Id_Inventario";
            this.COL_Inventario.Frozen = true;
            this.COL_Inventario.HeaderText = "IdInventario";
            this.COL_Inventario.Name = "COL_Inventario";
            this.COL_Inventario.ReadOnly = true;
            this.COL_Inventario.Visible = false;
            // 
            // COL_Producto
            // 
            this.COL_Producto.DataPropertyName = "Descripcion";
            this.COL_Producto.Frozen = true;
            this.COL_Producto.HeaderText = "Producto";
            this.COL_Producto.Name = "COL_Producto";
            this.COL_Producto.ReadOnly = true;
            this.COL_Producto.Width = 360;
            // 
            // COL_FechaInicio
            // 
            this.COL_FechaInicio.DataPropertyName = "Fecha_Inicio";
            this.COL_FechaInicio.HeaderText = "Fecha Inicio";
            this.COL_FechaInicio.Name = "COL_FechaInicio";
            this.COL_FechaInicio.ReadOnly = true;
            this.COL_FechaInicio.Width = 130;
            // 
            // COL_FechaFinal
            // 
            this.COL_FechaFinal.DataPropertyName = "Fecha_Final";
            this.COL_FechaFinal.HeaderText = "Fecha Final";
            this.COL_FechaFinal.Name = "COL_FechaFinal";
            this.COL_FechaFinal.ReadOnly = true;
            this.COL_FechaFinal.Width = 130;
            // 
            // COL_Cantidad
            // 
            this.COL_Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.COL_Cantidad.DataPropertyName = "Cantidad";
            this.COL_Cantidad.HeaderText = "Cantidad";
            this.COL_Cantidad.Name = "COL_Cantidad";
            this.COL_Cantidad.ReadOnly = true;
            // 
            // PANEL_Botones
            // 
            this.PANEL_Botones.Controls.Add(this.BTN_Agregar);
            this.PANEL_Botones.Controls.Add(this.BTN_Modificar);
            this.PANEL_Botones.Controls.Add(this.BTN_Eliminar);
            this.PANEL_Botones.Controls.Add(this.BTN_Aumentar);
            this.PANEL_Botones.Controls.Add(this.BTN_Disminuir);
            this.PANEL_Botones.Location = new System.Drawing.Point(964, 130);
            this.PANEL_Botones.Name = "PANEL_Botones";
            this.PANEL_Botones.Size = new System.Drawing.Size(117, 191);
            this.PANEL_Botones.TabIndex = 46;
            // 
            // BTN_Aumentar
            // 
            this.BTN_Aumentar.BackColor = System.Drawing.Color.White;
            this.BTN_Aumentar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Aumentar.FlatAppearance.BorderSize = 2;
            this.BTN_Aumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aumentar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Aumentar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aumentar.Image")));
            this.BTN_Aumentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Aumentar.Location = new System.Drawing.Point(3, 117);
            this.BTN_Aumentar.Name = "BTN_Aumentar";
            this.BTN_Aumentar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Aumentar.TabIndex = 4;
            this.BTN_Aumentar.Text = "Aumentar";
            this.BTN_Aumentar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Aumentar.UseVisualStyleBackColor = false;
            this.BTN_Aumentar.Visible = false;
            this.BTN_Aumentar.Click += new System.EventHandler(this.BTN_Aumentar_Click);
            // 
            // BTN_Disminuir
            // 
            this.BTN_Disminuir.BackColor = System.Drawing.Color.White;
            this.BTN_Disminuir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Disminuir.FlatAppearance.BorderSize = 2;
            this.BTN_Disminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Disminuir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Disminuir.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Disminuir.Image")));
            this.BTN_Disminuir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Disminuir.Location = new System.Drawing.Point(3, 155);
            this.BTN_Disminuir.Name = "BTN_Disminuir";
            this.BTN_Disminuir.Size = new System.Drawing.Size(111, 32);
            this.BTN_Disminuir.TabIndex = 5;
            this.BTN_Disminuir.Text = "Disminuir";
            this.BTN_Disminuir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Disminuir.UseVisualStyleBackColor = false;
            this.BTN_Disminuir.Click += new System.EventHandler(this.BTN_Disminuir_Click);
            // 
            // WIN_CAT_Inventario_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 590);
            this.Controls.Add(this.PANEL_Botones);
            this.Controls.Add(this.DGV_TablaProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WIN_CAT_Inventario_T";
            this.TituloBanner = "Inventario";
            this.Load += new System.EventHandler(this.WIN_CAT_Inventario_T_Load);
            this.Controls.SetChildIndex(this.DGV_TablaProducto, 0);
            this.Controls.SetChildIndex(this.PANEL_Botones, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaProducto)).EndInit();
            this.PANEL_Botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.DataGridView DGV_TablaProducto;
        private System.Windows.Forms.FlowLayoutPanel PANEL_Botones;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_FechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Cantidad;
        private System.Windows.Forms.Button BTN_Aumentar;
        private System.Windows.Forms.Button BTN_Disminuir;
    }
}