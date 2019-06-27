namespace DenTech
{
    partial class WIN_GLO_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_GLO_Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STC_NombreUsuario = new System.Windows.Forms.Label();
            this.BTN_Citas = new System.Windows.Forms.Button();
            this.BTN_Pacientes = new System.Windows.Forms.Button();
            this.BTN_Inventario = new System.Windows.Forms.Button();
            this.BTN_Empleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.STC_NombreUsuario);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 44);
            this.panel1.TabIndex = 36;
            // 
            // STC_NombreUsuario
            // 
            this.STC_NombreUsuario.AutoSize = true;
            this.STC_NombreUsuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_NombreUsuario.ForeColor = System.Drawing.Color.White;
            this.STC_NombreUsuario.Location = new System.Drawing.Point(48, 6);
            this.STC_NombreUsuario.Name = "STC_NombreUsuario";
            this.STC_NombreUsuario.Size = new System.Drawing.Size(204, 32);
            this.STC_NombreUsuario.TabIndex = 4;
            this.STC_NombreUsuario.Text = "Nombre Usuario";
            // 
            // BTN_Citas
            // 
            this.BTN_Citas.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Citas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Citas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Citas.FlatAppearance.BorderSize = 2;
            this.BTN_Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Citas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Citas.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Citas.Image")));
            this.BTN_Citas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Citas.Location = new System.Drawing.Point(384, 50);
            this.BTN_Citas.Name = "BTN_Citas";
            this.BTN_Citas.Size = new System.Drawing.Size(180, 179);
            this.BTN_Citas.TabIndex = 1;
            this.BTN_Citas.Text = "Citas";
            this.BTN_Citas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Citas.UseVisualStyleBackColor = false;
            // 
            // BTN_Pacientes
            // 
            this.BTN_Pacientes.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Pacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Pacientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Pacientes.FlatAppearance.BorderSize = 2;
            this.BTN_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Pacientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Pacientes.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Pacientes.Image")));
            this.BTN_Pacientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Pacientes.Location = new System.Drawing.Point(198, 50);
            this.BTN_Pacientes.Name = "BTN_Pacientes";
            this.BTN_Pacientes.Size = new System.Drawing.Size(180, 179);
            this.BTN_Pacientes.TabIndex = 2;
            this.BTN_Pacientes.Text = "Pacientes";
            this.BTN_Pacientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Pacientes.UseVisualStyleBackColor = false;
            this.BTN_Pacientes.Click += new System.EventHandler(this.BTN_Pacientes_Click);
            // 
            // BTN_Inventario
            // 
            this.BTN_Inventario.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Inventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Inventario.FlatAppearance.BorderSize = 2;
            this.BTN_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Inventario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Inventario.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Inventario.Image")));
            this.BTN_Inventario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Inventario.Location = new System.Drawing.Point(571, 50);
            this.BTN_Inventario.Name = "BTN_Inventario";
            this.BTN_Inventario.Size = new System.Drawing.Size(180, 179);
            this.BTN_Inventario.TabIndex = 3;
            this.BTN_Inventario.Text = "Inventario";
            this.BTN_Inventario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Inventario.UseVisualStyleBackColor = false;
            // 
            // BTN_Empleados
            // 
            this.BTN_Empleados.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Empleados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Empleados.FlatAppearance.BorderSize = 2;
            this.BTN_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Empleados.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Empleados.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Empleados.Image")));
            this.BTN_Empleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Empleados.Location = new System.Drawing.Point(12, 50);
            this.BTN_Empleados.Name = "BTN_Empleados";
            this.BTN_Empleados.Size = new System.Drawing.Size(180, 179);
            this.BTN_Empleados.TabIndex = 37;
            this.BTN_Empleados.Text = "Empleados";
            this.BTN_Empleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Empleados.UseVisualStyleBackColor = false;
            this.BTN_Empleados.Click += new System.EventHandler(this.BTN_Empleados_Click);
            // 
            // WIN_GLO_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 245);
            this.Controls.Add(this.BTN_Empleados);
            this.Controls.Add(this.BTN_Inventario);
            this.Controls.Add(this.BTN_Pacientes);
            this.Controls.Add(this.BTN_Citas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WIN_GLO_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DenTech - Menú Principal";
            this.Load += new System.EventHandler(this.WIN_GLO_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label STC_NombreUsuario;
        private System.Windows.Forms.Button BTN_Citas;
        private System.Windows.Forms.Button BTN_Pacientes;
        private System.Windows.Forms.Button BTN_Inventario;
        private System.Windows.Forms.Button BTN_Empleados;
    }
}