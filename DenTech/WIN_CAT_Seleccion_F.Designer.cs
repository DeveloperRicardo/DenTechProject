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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Seleccion_F));
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.DGV_TablaSeleccion = new System.Windows.Forms.DataGridView();
            this.BTN_Seleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.COL_IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNL_Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaSeleccion)).BeginInit();
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
            this.PNL_Banner.Size = new System.Drawing.Size(467, 44);
            this.PNL_Banner.TabIndex = 6;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(7, 6);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(77, 32);
            this.STC_Titulo.TabIndex = 4;
            this.STC_Titulo.Text = "Título";
            // 
            // DGV_TablaSeleccion
            // 
            this.DGV_TablaSeleccion.AllowUserToAddRows = false;
            this.DGV_TablaSeleccion.AllowUserToDeleteRows = false;
            this.DGV_TablaSeleccion.AllowUserToOrderColumns = true;
            this.DGV_TablaSeleccion.BackgroundColor = System.Drawing.Color.White;
            this.DGV_TablaSeleccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaSeleccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_TablaSeleccion.ColumnHeadersHeight = 30;
            this.DGV_TablaSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_IdUsuario,
            this.COL_Nombre});
            this.DGV_TablaSeleccion.EnableHeadersVisualStyles = false;
            this.DGV_TablaSeleccion.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_TablaSeleccion.Location = new System.Drawing.Point(11, 51);
            this.DGV_TablaSeleccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_TablaSeleccion.Name = "DGV_TablaSeleccion";
            this.DGV_TablaSeleccion.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_TablaSeleccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_TablaSeleccion.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_TablaSeleccion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_TablaSeleccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_TablaSeleccion.Size = new System.Drawing.Size(325, 333);
            this.DGV_TablaSeleccion.TabIndex = 34;
            // 
            // BTN_Seleccionar
            // 
            this.BTN_Seleccionar.BackColor = System.Drawing.Color.White;
            this.BTN_Seleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Seleccionar.FlatAppearance.BorderSize = 2;
            this.BTN_Seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Seleccionar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Seleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Seleccionar.Location = new System.Drawing.Point(342, 51);
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
            this.button1.Location = new System.Drawing.Point(401, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            // WIN_CAT_Seleccion_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 455);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Seleccionar);
            this.Controls.Add(this.DGV_TablaSeleccion);
            this.Controls.Add(this.PNL_Banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_CAT_Seleccion_F";
            this.Text = "DenTech";
            this.Load += new System.EventHandler(this.WIN_CAT_Seleccion_F_Load);
            this.PNL_Banner.ResumeLayout(false);
            this.PNL_Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TablaSeleccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.DataGridView DGV_TablaSeleccion;
        private System.Windows.Forms.Button BTN_Seleccionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Nombre;
    }
}