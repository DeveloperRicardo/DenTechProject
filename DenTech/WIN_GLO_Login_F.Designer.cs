﻿namespace DenTech
{
    partial class WIN_GLO_Login_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_GLO_Login_F));
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.STC_Titulo = new System.Windows.Forms.Label();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.EDT_Usuario = new System.Windows.Forms.TextBox();
            this.STC_Campo = new System.Windows.Forms.Label();
            this.EDT_Contrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDT_Servidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EDT_BaseDatos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_ProbarConexion = new System.Windows.Forms.Button();
            this.PNL_Banner.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Banner
            // 
            this.PNL_Banner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PNL_Banner.Controls.Add(this.STC_Titulo);
            this.PNL_Banner.Location = new System.Drawing.Point(-1, 0);
            this.PNL_Banner.Name = "PNL_Banner";
            this.PNL_Banner.Size = new System.Drawing.Size(352, 44);
            this.PNL_Banner.TabIndex = 4;
            // 
            // STC_Titulo
            // 
            this.STC_Titulo.AutoSize = true;
            this.STC_Titulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Titulo.ForeColor = System.Drawing.Color.White;
            this.STC_Titulo.Location = new System.Drawing.Point(7, 6);
            this.STC_Titulo.Name = "STC_Titulo";
            this.STC_Titulo.Size = new System.Drawing.Size(247, 32);
            this.STC_Titulo.TabIndex = 4;
            this.STC_Titulo.Text = "Conexión a Servidor";
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cancelar.FlatAppearance.BorderSize = 0;
            this.BTN_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancelar.Image")));
            this.BTN_Cancelar.Location = new System.Drawing.Point(270, 182);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cancelar.TabIndex = 7;
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(212, 182);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Aceptar.TabIndex = 6;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // EDT_Usuario
            // 
            this.EDT_Usuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Usuario.Location = new System.Drawing.Point(145, 58);
            this.EDT_Usuario.Name = "EDT_Usuario";
            this.EDT_Usuario.Size = new System.Drawing.Size(177, 25);
            this.EDT_Usuario.TabIndex = 1;
            // 
            // STC_Campo
            // 
            this.STC_Campo.AutoSize = true;
            this.STC_Campo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Campo.Location = new System.Drawing.Point(21, 60);
            this.STC_Campo.Name = "STC_Campo";
            this.STC_Campo.Size = new System.Drawing.Size(62, 20);
            this.STC_Campo.TabIndex = 10;
            this.STC_Campo.Text = "Usuario:";
            // 
            // EDT_Contrasena
            // 
            this.EDT_Contrasena.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Contrasena.Location = new System.Drawing.Point(145, 89);
            this.EDT_Contrasena.Name = "EDT_Contrasena";
            this.EDT_Contrasena.Size = new System.Drawing.Size(177, 25);
            this.EDT_Contrasena.TabIndex = 2;
            this.EDT_Contrasena.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Contraseña:";
            // 
            // EDT_Servidor
            // 
            this.EDT_Servidor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Servidor.Location = new System.Drawing.Point(145, 120);
            this.EDT_Servidor.Name = "EDT_Servidor";
            this.EDT_Servidor.Size = new System.Drawing.Size(177, 25);
            this.EDT_Servidor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Servidor:";
            // 
            // EDT_BaseDatos
            // 
            this.EDT_BaseDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_BaseDatos.Location = new System.Drawing.Point(145, 151);
            this.EDT_BaseDatos.Name = "EDT_BaseDatos";
            this.EDT_BaseDatos.Size = new System.Drawing.Size(177, 25);
            this.EDT_BaseDatos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Base de Datos:";
            // 
            // BTN_ProbarConexion
            // 
            this.BTN_ProbarConexion.BackColor = System.Drawing.Color.Transparent;
            this.BTN_ProbarConexion.FlatAppearance.BorderSize = 0;
            this.BTN_ProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ProbarConexion.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ProbarConexion.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ProbarConexion.Image")));
            this.BTN_ProbarConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_ProbarConexion.Location = new System.Drawing.Point(25, 188);
            this.BTN_ProbarConexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_ProbarConexion.Name = "BTN_ProbarConexion";
            this.BTN_ProbarConexion.Size = new System.Drawing.Size(97, 41);
            this.BTN_ProbarConexion.TabIndex = 5;
            this.BTN_ProbarConexion.Text = "Probar Conexión";
            this.BTN_ProbarConexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ProbarConexion.UseVisualStyleBackColor = false;
            this.BTN_ProbarConexion.Click += new System.EventHandler(this.BTN_ProbarConexion_Click);
            // 
            // WIN_GLO_Login_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 245);
            this.Controls.Add(this.BTN_ProbarConexion);
            this.Controls.Add(this.EDT_BaseDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EDT_Servidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EDT_Contrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.EDT_Usuario);
            this.Controls.Add(this.STC_Campo);
            this.Controls.Add(this.PNL_Banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WIN_GLO_Login_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DenTech - Conexión a Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CerrarVentana);
            this.PNL_Banner.ResumeLayout(false);
            this.PNL_Banner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.Label STC_Titulo;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.TextBox EDT_Usuario;
        private System.Windows.Forms.Label STC_Campo;
        private System.Windows.Forms.TextBox EDT_Contrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDT_Servidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EDT_BaseDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_ProbarConexion;
    }
}