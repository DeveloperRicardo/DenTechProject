namespace DenTech
{
    partial class WIN_Template_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Template_F));
            this.PNL_TitleBar = new System.Windows.Forms.Panel();
            this.TB_Icono = new System.Windows.Forms.PictureBox();
            this.TB_Titulo = new System.Windows.Forms.Label();
            this.PNL_TBBotones = new System.Windows.Forms.Panel();
            this.TB_Minimizar = new System.Windows.Forms.Button();
            this.TB_Maximizar = new System.Windows.Forms.Button();
            this.TB_Cerrar = new System.Windows.Forms.Button();
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.STC_TituloBanner = new System.Windows.Forms.Label();
            this.PNL_TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_Icono)).BeginInit();
            this.PNL_TBBotones.SuspendLayout();
            this.PNL_Banner.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_TitleBar
            // 
            this.PNL_TitleBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PNL_TitleBar.Controls.Add(this.TB_Icono);
            this.PNL_TitleBar.Controls.Add(this.TB_Titulo);
            this.PNL_TitleBar.Controls.Add(this.PNL_TBBotones);
            this.PNL_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.PNL_TitleBar.Name = "PNL_TitleBar";
            this.PNL_TitleBar.Size = new System.Drawing.Size(786, 25);
            this.PNL_TitleBar.TabIndex = 5;
            // 
            // TB_Icono
            // 
            this.TB_Icono.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TB_Icono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TB_Icono.BackgroundImage")));
            this.TB_Icono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TB_Icono.Location = new System.Drawing.Point(3, 4);
            this.TB_Icono.Name = "TB_Icono";
            this.TB_Icono.Size = new System.Drawing.Size(18, 18);
            this.TB_Icono.TabIndex = 37;
            this.TB_Icono.TabStop = false;
            // 
            // TB_Titulo
            // 
            this.TB_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Titulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Titulo.ForeColor = System.Drawing.Color.White;
            this.TB_Titulo.Location = new System.Drawing.Point(0, 0);
            this.TB_Titulo.Name = "TB_Titulo";
            this.TB_Titulo.Size = new System.Drawing.Size(647, 25);
            this.TB_Titulo.TabIndex = 1;
            this.TB_Titulo.Text = "      DenTech - ";
            this.TB_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TB_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TB_Titulo_MouseDown);
            this.TB_Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TB_Titulo_MouseMove);
            this.TB_Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TB_Titulo_MouseUp);
            // 
            // PNL_TBBotones
            // 
            this.PNL_TBBotones.Controls.Add(this.TB_Minimizar);
            this.PNL_TBBotones.Controls.Add(this.TB_Maximizar);
            this.PNL_TBBotones.Controls.Add(this.TB_Cerrar);
            this.PNL_TBBotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.PNL_TBBotones.Location = new System.Drawing.Point(647, 0);
            this.PNL_TBBotones.Name = "PNL_TBBotones";
            this.PNL_TBBotones.Size = new System.Drawing.Size(139, 25);
            this.PNL_TBBotones.TabIndex = 0;
            // 
            // TB_Minimizar
            // 
            this.TB_Minimizar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TB_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TB_Minimizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TB_Minimizar.ForeColor = System.Drawing.Color.White;
            this.TB_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("TB_Minimizar.Image")));
            this.TB_Minimizar.Location = new System.Drawing.Point(0, 0);
            this.TB_Minimizar.Name = "TB_Minimizar";
            this.TB_Minimizar.Size = new System.Drawing.Size(47, 23);
            this.TB_Minimizar.TabIndex = 2;
            this.TB_Minimizar.TabStop = false;
            this.TB_Minimizar.UseVisualStyleBackColor = true;
            this.TB_Minimizar.Visible = false;
            this.TB_Minimizar.Click += new System.EventHandler(this.TB_Minimizar_Click);
            // 
            // TB_Maximizar
            // 
            this.TB_Maximizar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TB_Maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TB_Maximizar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TB_Maximizar.ForeColor = System.Drawing.Color.White;
            this.TB_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("TB_Maximizar.Image")));
            this.TB_Maximizar.Location = new System.Drawing.Point(46, 0);
            this.TB_Maximizar.Name = "TB_Maximizar";
            this.TB_Maximizar.Size = new System.Drawing.Size(47, 23);
            this.TB_Maximizar.TabIndex = 1;
            this.TB_Maximizar.TabStop = false;
            this.TB_Maximizar.UseVisualStyleBackColor = true;
            this.TB_Maximizar.Visible = false;
            this.TB_Maximizar.Click += new System.EventHandler(this.TB_Minimizar_Click);
            // 
            // TB_Cerrar
            // 
            this.TB_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TB_Cerrar.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.TB_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TB_Cerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.TB_Cerrar.ForeColor = System.Drawing.Color.White;
            this.TB_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("TB_Cerrar.Image")));
            this.TB_Cerrar.Location = new System.Drawing.Point(92, 0);
            this.TB_Cerrar.Name = "TB_Cerrar";
            this.TB_Cerrar.Size = new System.Drawing.Size(47, 23);
            this.TB_Cerrar.TabIndex = 0;
            this.TB_Cerrar.TabStop = false;
            this.TB_Cerrar.UseVisualStyleBackColor = true;
            this.TB_Cerrar.Click += new System.EventHandler(this.TB_Cerrar_Click);
            // 
            // PNL_Banner
            // 
            this.PNL_Banner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PNL_Banner.Controls.Add(this.STC_TituloBanner);
            this.PNL_Banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Banner.Location = new System.Drawing.Point(0, 25);
            this.PNL_Banner.Name = "PNL_Banner";
            this.PNL_Banner.Size = new System.Drawing.Size(786, 44);
            this.PNL_Banner.TabIndex = 6;
            // 
            // STC_TituloBanner
            // 
            this.STC_TituloBanner.AutoSize = true;
            this.STC_TituloBanner.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_TituloBanner.ForeColor = System.Drawing.Color.White;
            this.STC_TituloBanner.Location = new System.Drawing.Point(7, 6);
            this.STC_TituloBanner.Name = "STC_TituloBanner";
            this.STC_TituloBanner.Size = new System.Drawing.Size(77, 32);
            this.STC_TituloBanner.TabIndex = 4;
            this.STC_TituloBanner.Text = "Título";
            // 
            // WIN_Template_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 413);
            this.ControlBox = false;
            this.Controls.Add(this.PNL_Banner);
            this.Controls.Add(this.PNL_TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WIN_Template_F";
            this.PNL_TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TB_Icono)).EndInit();
            this.PNL_TBBotones.ResumeLayout(false);
            this.PNL_Banner.ResumeLayout(false);
            this.PNL_Banner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_TitleBar;
        private System.Windows.Forms.PictureBox TB_Icono;
        private System.Windows.Forms.Label TB_Titulo;
        private System.Windows.Forms.Panel PNL_TBBotones;
        private System.Windows.Forms.Button TB_Minimizar;
        private System.Windows.Forms.Button TB_Maximizar;
        private System.Windows.Forms.Button TB_Cerrar;
        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.Label STC_TituloBanner;
    }
}