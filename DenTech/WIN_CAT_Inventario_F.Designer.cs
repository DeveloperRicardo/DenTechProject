namespace DenTech
{
    partial class WIN_CAT_Inventario_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Inventario_F));
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.STC_FechaFinal = new System.Windows.Forms.Label();
            this.STC_FechaInicio = new System.Windows.Forms.Label();
            this.STC_Cantidad = new System.Windows.Forms.Label();
            this.STC_Nombre = new System.Windows.Forms.Label();
            this.EDT_Nombre = new System.Windows.Forms.TextBox();
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.DT_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.DT_FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.NUD_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.COMBO_Opcion = new System.Windows.Forms.ComboBox();
            this.PNL_Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cerrar.Image")));
            this.BTN_Cerrar.Location = new System.Drawing.Point(306, 249);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cerrar.TabIndex = 32;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(248, 249);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Aceptar.TabIndex = 31;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // STC_FechaFinal
            // 
            this.STC_FechaFinal.AutoSize = true;
            this.STC_FechaFinal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_FechaFinal.Location = new System.Drawing.Point(17, 209);
            this.STC_FechaFinal.Name = "STC_FechaFinal";
            this.STC_FechaFinal.Size = new System.Drawing.Size(85, 20);
            this.STC_FechaFinal.TabIndex = 30;
            this.STC_FechaFinal.Text = "Fecha Final:";
            // 
            // STC_FechaInicio
            // 
            this.STC_FechaInicio.AutoSize = true;
            this.STC_FechaInicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_FechaInicio.Location = new System.Drawing.Point(17, 178);
            this.STC_FechaInicio.Name = "STC_FechaInicio";
            this.STC_FechaInicio.Size = new System.Drawing.Size(90, 20);
            this.STC_FechaInicio.TabIndex = 29;
            this.STC_FechaInicio.Text = "Fecha Inicio:";
            // 
            // STC_Cantidad
            // 
            this.STC_Cantidad.AutoSize = true;
            this.STC_Cantidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Cantidad.Location = new System.Drawing.Point(17, 117);
            this.STC_Cantidad.Name = "STC_Cantidad";
            this.STC_Cantidad.Size = new System.Drawing.Size(72, 20);
            this.STC_Cantidad.TabIndex = 28;
            this.STC_Cantidad.Text = "Cantidad:";
            // 
            // STC_Nombre
            // 
            this.STC_Nombre.AutoSize = true;
            this.STC_Nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Nombre.Location = new System.Drawing.Point(17, 86);
            this.STC_Nombre.Name = "STC_Nombre";
            this.STC_Nombre.Size = new System.Drawing.Size(67, 20);
            this.STC_Nombre.TabIndex = 27;
            this.STC_Nombre.Text = "Nombre:";
            // 
            // EDT_Nombre
            // 
            this.EDT_Nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Nombre.Location = new System.Drawing.Point(126, 84);
            this.EDT_Nombre.Name = "EDT_Nombre";
            this.EDT_Nombre.Size = new System.Drawing.Size(232, 25);
            this.EDT_Nombre.TabIndex = 23;
            // 
            // PNL_Banner
            // 
            this.PNL_Banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PNL_Banner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PNL_Banner.Controls.Add(this.STC_Titulo);
            this.PNL_Banner.Location = new System.Drawing.Point(0, 0);
            this.PNL_Banner.Name = "PNL_Banner";
            this.PNL_Banner.Size = new System.Drawing.Size(380, 44);
            this.PNL_Banner.TabIndex = 20;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(7, 6);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(126, 32);
            this.STC_Titulo.TabIndex = 4;
            this.STC_Titulo.Text = "Inventario";
            // 
            // DT_FechaInicio
            // 
            this.DT_FechaInicio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DT_FechaInicio.Location = new System.Drawing.Point(126, 178);
            this.DT_FechaInicio.Name = "DT_FechaInicio";
            this.DT_FechaInicio.Size = new System.Drawing.Size(232, 25);
            this.DT_FechaInicio.TabIndex = 33;
            this.DT_FechaInicio.Value = new System.DateTime(2019, 6, 24, 0, 0, 0, 0);
            // 
            // DT_FechaFinal
            // 
            this.DT_FechaFinal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DT_FechaFinal.Location = new System.Drawing.Point(126, 209);
            this.DT_FechaFinal.Name = "DT_FechaFinal";
            this.DT_FechaFinal.Size = new System.Drawing.Size(232, 25);
            this.DT_FechaFinal.TabIndex = 34;
            // 
            // NUD_Cantidad
            // 
            this.NUD_Cantidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Cantidad.Location = new System.Drawing.Point(126, 116);
            this.NUD_Cantidad.Name = "NUD_Cantidad";
            this.NUD_Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NUD_Cantidad.Size = new System.Drawing.Size(55, 25);
            this.NUD_Cantidad.TabIndex = 35;
            this.NUD_Cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Categoría:";
            // 
            // COMBO_Opcion
            // 
            this.COMBO_Opcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Opcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_Opcion.FormattingEnabled = true;
            this.COMBO_Opcion.Items.AddRange(new object[] {
            "Clínica",
            "Intendencia"});
            this.COMBO_Opcion.Location = new System.Drawing.Point(126, 147);
            this.COMBO_Opcion.Name = "COMBO_Opcion";
            this.COMBO_Opcion.Size = new System.Drawing.Size(232, 25);
            this.COMBO_Opcion.TabIndex = 38;
            // 
            // WIN_CAT_Inventario_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.COMBO_Opcion);
            this.Controls.Add(this.NUD_Cantidad);
            this.Controls.Add(this.DT_FechaFinal);
            this.Controls.Add(this.DT_FechaInicio);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.STC_FechaFinal);
            this.Controls.Add(this.STC_FechaInicio);
            this.Controls.Add(this.STC_Cantidad);
            this.Controls.Add(this.STC_Nombre);
            this.Controls.Add(this.EDT_Nombre);
            this.Controls.Add(this.PNL_Banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WIN_CAT_Inventario_F";
            this.TituloBanner = "Inventario";
            this.TituloVentana = "      DenTech - Inventario";
            this.Load += new System.EventHandler(this.WIN_CAT_Inventario_F_Load);
            this.Controls.SetChildIndex(this.PNL_Banner, 0);
            this.Controls.SetChildIndex(this.EDT_Nombre, 0);
            this.Controls.SetChildIndex(this.STC_Nombre, 0);
            this.Controls.SetChildIndex(this.STC_Cantidad, 0);
            this.Controls.SetChildIndex(this.STC_FechaInicio, 0);
            this.Controls.SetChildIndex(this.STC_FechaFinal, 0);
            this.Controls.SetChildIndex(this.BTN_Aceptar, 0);
            this.Controls.SetChildIndex(this.BTN_Cerrar, 0);
            this.Controls.SetChildIndex(this.DT_FechaInicio, 0);
            this.Controls.SetChildIndex(this.DT_FechaFinal, 0);
            this.Controls.SetChildIndex(this.NUD_Cantidad, 0);
            this.Controls.SetChildIndex(this.COMBO_Opcion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.PNL_Banner.ResumeLayout(false);
            this.PNL_Banner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.Label STC_FechaFinal;
        private System.Windows.Forms.Label STC_FechaInicio;
        private System.Windows.Forms.Label STC_Cantidad;
        private System.Windows.Forms.Label STC_Nombre;
        private System.Windows.Forms.TextBox EDT_Nombre;
        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.DateTimePicker DT_FechaInicio;
        private System.Windows.Forms.DateTimePicker DT_FechaFinal;
        private System.Windows.Forms.NumericUpDown NUD_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox COMBO_Opcion;
    }
}