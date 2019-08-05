namespace DenTech
{
    partial class WIN_CAT_Seleccion_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Seleccion_F));
            this.DGV_TablaSeleccion = new System.Windows.Forms.DataGridView();
            this.COL_IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_Seleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaSeleccion)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TablaSeleccion
            // 
            this.DGV_TablaSeleccion.AllowUserToAddRows = false;
            this.DGV_TablaSeleccion.AllowUserToDeleteRows = false;
            this.DGV_TablaSeleccion.AllowUserToOrderColumns = true;
            this.DGV_TablaSeleccion.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaSeleccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_TablaSeleccion.ColumnHeadersHeight = 30;
            this.DGV_TablaSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdUsuario,
            this.COL_Nombre});
            this.DGV_TablaSeleccion.EnableHeadersVisualStyles = false;
            this.DGV_TablaSeleccion.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaSeleccion.Location = new System.Drawing.Point(11, 76);
            this.DGV_TablaSeleccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaSeleccion.Name = "DGV_TablaSeleccion";
            this.DGV_TablaSeleccion.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaSeleccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_TablaSeleccion.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaSeleccion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_TablaSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaSeleccion.Size = new System.Drawing.Size(325, 333);
            this.DGV_TablaSeleccion.TabIndex = 34;
            // 
            // COL_IdUsuario
            // 
            this.COL_IdUsuario.DataPropertyName = "Id";
            this.COL_IdUsuario.Frozen = true;
            this.COL_IdUsuario.HeaderText = "Id";
            this.COL_IdUsuario.Name = "COL_IdUsuario";
            this.COL_IdUsuario.ReadOnly = true;
            this.COL_IdUsuario.Visible = false;
            // 
            // COL_Nombre
            // 
            this.COL_Nombre.DataPropertyName = "NombreCompleto";
            this.COL_Nombre.Frozen = true;
            this.COL_Nombre.HeaderText = "Nombre";
            this.COL_Nombre.Name = "COL_Nombre";
            this.COL_Nombre.ReadOnly = true;
            this.COL_Nombre.Width = 320;
            // 
            // BTN_Seleccionar
            // 
            this.BTN_Seleccionar.BackColor = System.Drawing.Color.White;
            this.BTN_Seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Seleccionar.FlatAppearance.BorderSize = 2;
            this.BTN_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Seleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Seleccionar.Location = new System.Drawing.Point(342, 76);
            this.BTN_Seleccionar.Name = "BTN_Seleccionar";
            this.BTN_Seleccionar.Size = new System.Drawing.Size(111, 32);
            this.BTN_Seleccionar.TabIndex = 35;
            this.BTN_Seleccionar.Text = "Seleccionar";
            this.BTN_Seleccionar.UseVisualStyleBackColor = false;
            this.BTN_Seleccionar.Click += new System.EventHandler(this.BTN_Seleccionar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(401, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // WIN_CAT_Seleccion_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Seleccionar);
            this.Controls.Add(this.DGV_TablaSeleccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_CAT_Seleccion_F";
            this.TituloBanner = "Selección";
            this.TituloVentana = "      DenTech - Selección";
            this.Load += new System.EventHandler(this.WIN_CAT_Seleccion_F_Load);
            this.Controls.SetChildIndex(this.DGV_TablaSeleccion, 0);
            this.Controls.SetChildIndex(this.BTN_Seleccionar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaSeleccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_TablaSeleccion;
        private System.Windows.Forms.Button BTN_Seleccionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Nombre;
    }
}