namespace DenTech
{
    partial class WIN_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Login));
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.IMG_Logo = new System.Windows.Forms.PictureBox();
            this.STC_Usuario = new System.Windows.Forms.Label();
            this.EDT_Password = new System.Windows.Forms.TextBox();
            this.STC_Password = new System.Windows.Forms.Label();
            this.COMBO_Usuarios = new System.Windows.Forms.ComboBox();
            this.BTN_Acceder = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.BTN_Config = new System.Windows.Forms.Button();
            this.PNL_Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Banner
            // 
            this.PNL_Banner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PNL_Banner.Controls.Add(this.BTN_Config);
            this.PNL_Banner.Controls.Add(this.IMG_Logo);
            this.PNL_Banner.Location = new System.Drawing.Point(0, 0);
            this.PNL_Banner.Name = "PNL_Banner";
            this.PNL_Banner.Size = new System.Drawing.Size(402, 283);
            this.PNL_Banner.TabIndex = 4;
            // 
            // IMG_Logo
            // 
            this.IMG_Logo.Image = ((System.Drawing.Image)(resources.GetObject("IMG_Logo.Image")));
            this.IMG_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("IMG_Logo.InitialImage")));
            this.IMG_Logo.Location = new System.Drawing.Point(90, 7);
            this.IMG_Logo.Name = "IMG_Logo";
            this.IMG_Logo.Size = new System.Drawing.Size(222, 268);
            this.IMG_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_Logo.TabIndex = 0;
            this.IMG_Logo.TabStop = false;
            this.IMG_Logo.Click += new System.EventHandler(this.IMG_Logo_Click);
            // 
            // STC_Usuario
            // 
            this.STC_Usuario.AutoSize = true;
            this.STC_Usuario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Usuario.Location = new System.Drawing.Point(9, 295);
            this.STC_Usuario.Name = "STC_Usuario";
            this.STC_Usuario.Size = new System.Drawing.Size(110, 32);
            this.STC_Usuario.TabIndex = 5;
            this.STC_Usuario.Text = "Usuario:";
            // 
            // EDT_Password
            // 
            this.EDT_Password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Password.Location = new System.Drawing.Point(15, 404);
            this.EDT_Password.Name = "EDT_Password";
            this.EDT_Password.Size = new System.Drawing.Size(372, 36);
            this.EDT_Password.TabIndex = 8;
            // 
            // STC_Password
            // 
            this.STC_Password.AutoSize = true;
            this.STC_Password.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Password.Location = new System.Drawing.Point(9, 369);
            this.STC_Password.Name = "STC_Password";
            this.STC_Password.Size = new System.Drawing.Size(151, 32);
            this.STC_Password.TabIndex = 7;
            this.STC_Password.Text = "Contraseña:";
            // 
            // COMBO_Usuarios
            // 
            this.COMBO_Usuarios.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_Usuarios.FormattingEnabled = true;
            this.COMBO_Usuarios.Location = new System.Drawing.Point(15, 330);
            this.COMBO_Usuarios.Name = "COMBO_Usuarios";
            this.COMBO_Usuarios.Size = new System.Drawing.Size(372, 38);
            this.COMBO_Usuarios.TabIndex = 9;
            // 
            // BTN_Acceder
            // 
            this.BTN_Acceder.BackColor = System.Drawing.Color.White;
            this.BTN_Acceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Acceder.FlatAppearance.BorderSize = 2;
            this.BTN_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Acceder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Acceder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Acceder.Location = new System.Drawing.Point(214, 477);
            this.BTN_Acceder.Name = "BTN_Acceder";
            this.BTN_Acceder.Size = new System.Drawing.Size(85, 32);
            this.BTN_Acceder.TabIndex = 10;
            this.BTN_Acceder.Text = "Acceder";
            this.BTN_Acceder.UseVisualStyleBackColor = false;
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.Color.White;
            this.BTN_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Salir.FlatAppearance.BorderSize = 2;
            this.BTN_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Salir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Salir.Location = new System.Drawing.Point(305, 477);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(85, 32);
            this.BTN_Salir.TabIndex = 11;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = false;
            // 
            // BTN_Config
            // 
            this.BTN_Config.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Config.FlatAppearance.BorderSize = 0;
            this.BTN_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Config.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Config.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Config.Image")));
            this.BTN_Config.Location = new System.Drawing.Point(349, 8);
            this.BTN_Config.Name = "BTN_Config";
            this.BTN_Config.Size = new System.Drawing.Size(45, 44);
            this.BTN_Config.TabIndex = 12;
            this.BTN_Config.UseVisualStyleBackColor = false;
            // 
            // WIN_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 521);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.BTN_Acceder);
            this.Controls.Add(this.COMBO_Usuarios);
            this.Controls.Add(this.EDT_Password);
            this.Controls.Add(this.STC_Password);
            this.Controls.Add(this.STC_Usuario);
            this.Controls.Add(this.PNL_Banner);
            this.Name = "WIN_Login";
            this.Text = "Login";
            this.PNL_Banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.PictureBox IMG_Logo;
        private System.Windows.Forms.Label STC_Usuario;
        private System.Windows.Forms.TextBox EDT_Password;
        private System.Windows.Forms.Label STC_Password;
        private System.Windows.Forms.ComboBox COMBO_Usuarios;
        private System.Windows.Forms.Button BTN_Acceder;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Button BTN_Config;
    }
}

