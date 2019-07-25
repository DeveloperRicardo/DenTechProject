namespace DenTech
{
    partial class WIN_GLO_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_GLO_Login));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PNL_Banner = new System.Windows.Forms.Panel();
            this.BTN_Config = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Acceder = new System.Windows.Forms.Button();
            this.STC_Campo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EDT_Contrasena = new System.Windows.Forms.TextBox();
            this.COMBO_Usuario = new System.Windows.Forms.ComboBox();
            this.DGV_Login = new System.Windows.Forms.DataGridView();
            this.COL_Inventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COL_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNL_Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Banner
            // 
            this.PNL_Banner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PNL_Banner.Controls.Add(this.DGV_Login);
            this.PNL_Banner.Controls.Add(this.BTN_Config);
            this.PNL_Banner.Controls.Add(this.pictureBox1);
            this.PNL_Banner.Location = new System.Drawing.Point(0, 0);
            this.PNL_Banner.Name = "PNL_Banner";
            this.PNL_Banner.Size = new System.Drawing.Size(347, 227);
            this.PNL_Banner.TabIndex = 4;
            // 
            // BTN_Config
            // 
            this.BTN_Config.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Config.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Config.FlatAppearance.BorderSize = 0;
            this.BTN_Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Config.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Config.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Config.Image")));
            this.BTN_Config.Location = new System.Drawing.Point(299, 5);
            this.BTN_Config.Name = "BTN_Config";
            this.BTN_Config.Size = new System.Drawing.Size(45, 44);
            this.BTN_Config.TabIndex = 13;
            this.BTN_Config.UseVisualStyleBackColor = false;
            this.BTN_Config.Click += new System.EventHandler(this.BTN_Config_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(89, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 216);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Acceder
            // 
            this.BTN_Acceder.BackColor = System.Drawing.Color.White;
            this.BTN_Acceder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BTN_Acceder.FlatAppearance.BorderSize = 2;
            this.BTN_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Acceder.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Acceder.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Acceder.Image")));
            this.BTN_Acceder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Acceder.Location = new System.Drawing.Point(223, 450);
            this.BTN_Acceder.Name = "BTN_Acceder";
            this.BTN_Acceder.Size = new System.Drawing.Size(111, 32);
            this.BTN_Acceder.TabIndex = 3;
            this.BTN_Acceder.Text = "Acceder";
            this.BTN_Acceder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Acceder.UseVisualStyleBackColor = false;
            this.BTN_Acceder.Click += new System.EventHandler(this.BTN_Acceder_Click);
            // 
            // STC_Campo
            // 
            this.STC_Campo.AutoSize = true;
            this.STC_Campo.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.STC_Campo.Location = new System.Drawing.Point(5, 239);
            this.STC_Campo.Name = "STC_Campo";
            this.STC_Campo.Size = new System.Drawing.Size(114, 37);
            this.STC_Campo.TabIndex = 8;
            this.STC_Campo.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.Location = new System.Drawing.Point(5, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contraseña:";
            // 
            // EDT_Contrasena
            // 
            this.EDT_Contrasena.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.EDT_Contrasena.Location = new System.Drawing.Point(12, 392);
            this.EDT_Contrasena.Name = "EDT_Contrasena";
            this.EDT_Contrasena.Size = new System.Drawing.Size(322, 43);
            this.EDT_Contrasena.TabIndex = 2;
            this.EDT_Contrasena.UseSystemPasswordChar = true;
            // 
            // COMBO_Usuario
            // 
            this.COMBO_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Usuario.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.COMBO_Usuario.FormattingEnabled = true;
            this.COMBO_Usuario.Location = new System.Drawing.Point(12, 279);
            this.COMBO_Usuario.Name = "COMBO_Usuario";
            this.COMBO_Usuario.Size = new System.Drawing.Size(322, 45);
            this.COMBO_Usuario.TabIndex = 1;
            // 
            // DGV_Login
            // 
            this.DGV_Login.AllowUserToAddRows = false;
            this.DGV_Login.AllowUserToDeleteRows = false;
            this.DGV_Login.AllowUserToOrderColumns = true;
            this.DGV_Login.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Login.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Login.ColumnHeadersHeight = 30;
            this.DGV_Login.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COL_Inventario,
            this.COL_Producto});
            this.DGV_Login.EnableHeadersVisualStyles = false;
            this.DGV_Login.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_Login.Location = new System.Drawing.Point(3, 5);
            this.DGV_Login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV_Login.Name = "DGV_Login";
            this.DGV_Login.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Login.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Login.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DGV_Login.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Login.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Login.Size = new System.Drawing.Size(126, 116);
            this.DGV_Login.TabIndex = 46;
            this.DGV_Login.TabStop = false;
            // 
            // COL_Inventario
            // 
            this.COL_Inventario.DataPropertyName = "Id_Empleado";
            this.COL_Inventario.Frozen = true;
            this.COL_Inventario.HeaderText = "IdEmpleado";
            this.COL_Inventario.Name = "COL_Inventario";
            this.COL_Inventario.ReadOnly = true;
            this.COL_Inventario.Visible = false;
            // 
            // COL_Producto
            // 
            this.COL_Producto.DataPropertyName = "Usuario";
            this.COL_Producto.Frozen = true;
            this.COL_Producto.HeaderText = "Usuario";
            this.COL_Producto.Name = "COL_Producto";
            this.COL_Producto.ReadOnly = true;
            this.COL_Producto.Width = 360;
            // 
            // WIN_GLO_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 497);
            this.Controls.Add(this.COMBO_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Acceder);
            this.Controls.Add(this.EDT_Contrasena);
            this.Controls.Add(this.STC_Campo);
            this.Controls.Add(this.PNL_Banner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WIN_GLO_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DenTech - Login";
            this.Load += new System.EventHandler(this.WIN_GLO_Login_Load);
            this.PNL_Banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Banner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Acceder;
        private System.Windows.Forms.Label STC_Campo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDT_Contrasena;
        private System.Windows.Forms.ComboBox COMBO_Usuario;
        private System.Windows.Forms.Button BTN_Config;
        private System.Windows.Forms.DataGridView DGV_Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Inventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn COL_Producto;
    }
}