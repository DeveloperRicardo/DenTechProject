namespace DenTech
{
    partial class WIN_CAT_Citas_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Citas_F));
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.PANEL_Paciente = new System.Windows.Forms.Panel();
            this.STC_NombrePaciente = new System.Windows.Forms.Label();
            this.BTN_Paciente = new System.Windows.Forms.Button();
            this.PANEL_Odontologo = new System.Windows.Forms.Panel();
            this.STC_NombreOdontologo = new System.Windows.Forms.Label();
            this.EDT_Paciente = new System.Windows.Forms.TextBox();
            this.BTN_Odontologo = new System.Windows.Forms.Button();
            this.STC_Paciente = new System.Windows.Forms.Label();
            this.EDT_Odontologo = new System.Windows.Forms.TextBox();
            this.STC_Odontologo = new System.Windows.Forms.Label();
            this.EDT_Fecha = new System.Windows.Forms.DateTimePicker();
            this.STC_Fecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.PNL_Banner.SuspendLayout();
            this.PANEL_Paciente.SuspendLayout();
            this.PANEL_Odontologo.SuspendLayout();
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
            this.PNL_Banner.Size = new System.Drawing.Size(497, 44);
            this.PNL_Banner.TabIndex = 5;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(7, 6);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(68, 32);
            this.STC_Titulo.TabIndex = 4;
            this.STC_Titulo.Text = "Citas";
            // 
            // PANEL_Paciente
            // 
            this.PANEL_Paciente.BackColor = System.Drawing.Color.White;
            this.PANEL_Paciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PANEL_Paciente.Controls.Add(this.STC_NombrePaciente);
            this.PANEL_Paciente.Location = new System.Drawing.Point(135, 149);
            this.PANEL_Paciente.Name = "PANEL_Paciente";
            this.PANEL_Paciente.Size = new System.Drawing.Size(348, 25);
            this.PANEL_Paciente.TabIndex = 47;
            // 
            // STC_NombrePaciente
            // 
            this.STC_NombrePaciente.AutoSize = true;
            this.STC_NombrePaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_NombrePaciente.ForeColor = System.Drawing.Color.Black;
            this.STC_NombrePaciente.Location = new System.Drawing.Point(3, 1);
            this.STC_NombrePaciente.Name = "STC_NombrePaciente";
            this.STC_NombrePaciente.Size = new System.Drawing.Size(47, 20);
            this.STC_NombrePaciente.TabIndex = 4;
            this.STC_NombrePaciente.Text = "Título";
            // 
            // BTN_Paciente
            // 
            this.BTN_Paciente.BackColor = System.Drawing.Color.White;
            this.BTN_Paciente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Paciente.FlatAppearance.BorderSize = 2;
            this.BTN_Paciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Paciente.Font = new System.Drawing.Font("Rockwell", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Paciente.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Paciente.Image")));
            this.BTN_Paciente.Location = new System.Drawing.Point(255, 118);
            this.BTN_Paciente.Name = "BTN_Paciente";
            this.BTN_Paciente.Size = new System.Drawing.Size(29, 25);
            this.BTN_Paciente.TabIndex = 46;
            this.BTN_Paciente.UseVisualStyleBackColor = false;
            this.BTN_Paciente.Click += new System.EventHandler(this.BTN_Paciente_Click);
            // 
            // PANEL_Odontologo
            // 
            this.PANEL_Odontologo.BackColor = System.Drawing.Color.White;
            this.PANEL_Odontologo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PANEL_Odontologo.Controls.Add(this.STC_NombreOdontologo);
            this.PANEL_Odontologo.Location = new System.Drawing.Point(135, 87);
            this.PANEL_Odontologo.Name = "PANEL_Odontologo";
            this.PANEL_Odontologo.Size = new System.Drawing.Size(348, 25);
            this.PANEL_Odontologo.TabIndex = 43;
            // 
            // STC_NombreOdontologo
            // 
            this.STC_NombreOdontologo.AutoSize = true;
            this.STC_NombreOdontologo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_NombreOdontologo.ForeColor = System.Drawing.Color.Black;
            this.STC_NombreOdontologo.Location = new System.Drawing.Point(3, 1);
            this.STC_NombreOdontologo.Name = "STC_NombreOdontologo";
            this.STC_NombreOdontologo.Size = new System.Drawing.Size(47, 20);
            this.STC_NombreOdontologo.TabIndex = 4;
            this.STC_NombreOdontologo.Text = "Título";
            // 
            // EDT_Paciente
            // 
            this.EDT_Paciente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Paciente.Location = new System.Drawing.Point(135, 118);
            this.EDT_Paciente.Name = "EDT_Paciente";
            this.EDT_Paciente.Size = new System.Drawing.Size(112, 25);
            this.EDT_Paciente.TabIndex = 45;
            // 
            // BTN_Odontologo
            // 
            this.BTN_Odontologo.BackColor = System.Drawing.Color.White;
            this.BTN_Odontologo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Odontologo.FlatAppearance.BorderSize = 2;
            this.BTN_Odontologo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Odontologo.Font = new System.Drawing.Font("Rockwell", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Odontologo.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Odontologo.Image")));
            this.BTN_Odontologo.Location = new System.Drawing.Point(255, 56);
            this.BTN_Odontologo.Name = "BTN_Odontologo";
            this.BTN_Odontologo.Size = new System.Drawing.Size(29, 25);
            this.BTN_Odontologo.TabIndex = 42;
            this.BTN_Odontologo.UseVisualStyleBackColor = false;
            this.BTN_Odontologo.Click += new System.EventHandler(this.BTN_Odontologo_Click);
            // 
            // STC_Paciente
            // 
            this.STC_Paciente.AutoSize = true;
            this.STC_Paciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Paciente.Location = new System.Drawing.Point(13, 120);
            this.STC_Paciente.Name = "STC_Paciente";
            this.STC_Paciente.Size = new System.Drawing.Size(67, 20);
            this.STC_Paciente.TabIndex = 44;
            this.STC_Paciente.Text = "Paciente:";
            // 
            // EDT_Odontologo
            // 
            this.EDT_Odontologo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Odontologo.Location = new System.Drawing.Point(135, 56);
            this.EDT_Odontologo.Name = "EDT_Odontologo";
            this.EDT_Odontologo.Size = new System.Drawing.Size(112, 25);
            this.EDT_Odontologo.TabIndex = 41;
            // 
            // STC_Odontologo
            // 
            this.STC_Odontologo.AutoSize = true;
            this.STC_Odontologo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Odontologo.Location = new System.Drawing.Point(13, 58);
            this.STC_Odontologo.Name = "STC_Odontologo";
            this.STC_Odontologo.Size = new System.Drawing.Size(94, 20);
            this.STC_Odontologo.TabIndex = 40;
            this.STC_Odontologo.Text = "Odontólogo:";
            // 
            // EDT_Fecha
            // 
            this.EDT_Fecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EDT_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EDT_Fecha.Location = new System.Drawing.Point(135, 180);
            this.EDT_Fecha.Name = "EDT_Fecha";
            this.EDT_Fecha.Size = new System.Drawing.Size(112, 25);
            this.EDT_Fecha.TabIndex = 49;
            this.EDT_Fecha.Value = new System.DateTime(2019, 7, 28, 0, 0, 0, 0);
            // 
            // STC_Fecha
            // 
            this.STC_Fecha.AutoSize = true;
            this.STC_Fecha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Fecha.Location = new System.Drawing.Point(13, 182);
            this.STC_Fecha.Name = "STC_Fecha";
            this.STC_Fecha.Size = new System.Drawing.Size(50, 20);
            this.STC_Fecha.TabIndex = 48;
            this.STC_Fecha.Text = "Fecha:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(431, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 51;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(373, 224);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Aceptar.TabIndex = 50;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // WIN_CAT_Citas_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.EDT_Fecha);
            this.Controls.Add(this.STC_Fecha);
            this.Controls.Add(this.PANEL_Paciente);
            this.Controls.Add(this.BTN_Paciente);
            this.Controls.Add(this.PANEL_Odontologo);
            this.Controls.Add(this.EDT_Paciente);
            this.Controls.Add(this.BTN_Odontologo);
            this.Controls.Add(this.STC_Paciente);
            this.Controls.Add(this.EDT_Odontologo);
            this.Controls.Add(this.STC_Odontologo);
            this.Controls.Add(this.PNL_Banner);
            this.Name = "WIN_CAT_Citas_F";
            this.Text = "DenTech - Catálogo Citas";
            this.Load += new System.EventHandler(this.WIN_CAT_Citas_F_Load);
            this.PNL_Banner.ResumeLayout(false);
            this.PNL_Banner.PerformLayout();
            this.PANEL_Paciente.ResumeLayout(false);
            this.PANEL_Paciente.PerformLayout();
            this.PANEL_Odontologo.ResumeLayout(false);
            this.PANEL_Odontologo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Panel PANEL_Paciente;
        private System.Windows.Forms.Label STC_NombrePaciente;
        private System.Windows.Forms.Button BTN_Paciente;
        private System.Windows.Forms.Panel PANEL_Odontologo;
        private System.Windows.Forms.Label STC_NombreOdontologo;
        private System.Windows.Forms.TextBox EDT_Paciente;
        private System.Windows.Forms.Button BTN_Odontologo;
        private System.Windows.Forms.Label STC_Paciente;
        private System.Windows.Forms.TextBox EDT_Odontologo;
        private System.Windows.Forms.Label STC_Odontologo;
        private System.Windows.Forms.DateTimePicker EDT_Fecha;
        private System.Windows.Forms.Label STC_Fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Aceptar;
    }
}