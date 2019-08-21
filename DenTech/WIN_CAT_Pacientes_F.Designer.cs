namespace DenTech
{
    partial class WIN_CAT_Pacientes_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Pacientes_F));
            this.EDT_Nombre = new System.Windows.Forms.TextBox();
            this.STC_Nombre = new System.Windows.Forms.Label();
            this.EDT_ApellidoP = new System.Windows.Forms.TextBox();
            this.STC_ApellidoP = new System.Windows.Forms.Label();
            this.EDT_ApellidoM = new System.Windows.Forms.TextBox();
            this.STC_ApellidoM = new System.Windows.Forms.Label();
            this.STC_Edad = new System.Windows.Forms.Label();
            this.EDT_Edad = new System.Windows.Forms.TextBox();
            this.STC_Sexo = new System.Windows.Forms.Label();
            this.COMBO_Sexo = new System.Windows.Forms.ComboBox();
            this.STC_Direccion = new System.Windows.Forms.Label();
            this.EDT_Direccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EDT_Telefono = new System.Windows.Forms.TextBox();
            this.EDT_TelefonoEm = new System.Windows.Forms.TextBox();
            this.STC_Telefono = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EDT_Nombre
            // 
            this.EDT_Nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Nombre.Location = new System.Drawing.Point(123, 79);
            this.EDT_Nombre.MaxLength = 20;
            this.EDT_Nombre.Name = "EDT_Nombre";
            this.EDT_Nombre.Size = new System.Drawing.Size(194, 25);
            this.EDT_Nombre.TabIndex = 1;
            this.EDT_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionLetras);
            // 
            // STC_Nombre
            // 
            this.STC_Nombre.AutoSize = true;
            this.STC_Nombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Nombre.Location = new System.Drawing.Point(17, 81);
            this.STC_Nombre.Name = "STC_Nombre";
            this.STC_Nombre.Size = new System.Drawing.Size(67, 20);
            this.STC_Nombre.TabIndex = 6;
            this.STC_Nombre.Text = "Nombre:";
            // 
            // EDT_ApellidoP
            // 
            this.EDT_ApellidoP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_ApellidoP.Location = new System.Drawing.Point(123, 110);
            this.EDT_ApellidoP.MaxLength = 12;
            this.EDT_ApellidoP.Name = "EDT_ApellidoP";
            this.EDT_ApellidoP.Size = new System.Drawing.Size(194, 25);
            this.EDT_ApellidoP.TabIndex = 2;
            this.EDT_ApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionLetras);
            // 
            // STC_ApellidoP
            // 
            this.STC_ApellidoP.AutoSize = true;
            this.STC_ApellidoP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_ApellidoP.Location = new System.Drawing.Point(17, 112);
            this.STC_ApellidoP.Name = "STC_ApellidoP";
            this.STC_ApellidoP.Size = new System.Drawing.Size(88, 20);
            this.STC_ApellidoP.TabIndex = 8;
            this.STC_ApellidoP.Text = "Ap. Paterno:";
            // 
            // EDT_ApellidoM
            // 
            this.EDT_ApellidoM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_ApellidoM.Location = new System.Drawing.Point(123, 141);
            this.EDT_ApellidoM.MaxLength = 12;
            this.EDT_ApellidoM.Name = "EDT_ApellidoM";
            this.EDT_ApellidoM.Size = new System.Drawing.Size(194, 25);
            this.EDT_ApellidoM.TabIndex = 3;
            this.EDT_ApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionLetras);
            // 
            // STC_ApellidoM
            // 
            this.STC_ApellidoM.AutoSize = true;
            this.STC_ApellidoM.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_ApellidoM.Location = new System.Drawing.Point(17, 143);
            this.STC_ApellidoM.Name = "STC_ApellidoM";
            this.STC_ApellidoM.Size = new System.Drawing.Size(94, 20);
            this.STC_ApellidoM.TabIndex = 10;
            this.STC_ApellidoM.Text = "Ap. Materno:";
            // 
            // STC_Edad
            // 
            this.STC_Edad.AutoSize = true;
            this.STC_Edad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Edad.Location = new System.Drawing.Point(330, 81);
            this.STC_Edad.Name = "STC_Edad";
            this.STC_Edad.Size = new System.Drawing.Size(46, 20);
            this.STC_Edad.TabIndex = 12;
            this.STC_Edad.Text = "Edad:";
            // 
            // EDT_Edad
            // 
            this.EDT_Edad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Edad.Location = new System.Drawing.Point(464, 79);
            this.EDT_Edad.Name = "EDT_Edad";
            this.EDT_Edad.Size = new System.Drawing.Size(45, 25);
            this.EDT_Edad.TabIndex = 5;
            this.EDT_Edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDT_Edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionNumeros);
            // 
            // STC_Sexo
            // 
            this.STC_Sexo.AutoSize = true;
            this.STC_Sexo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Sexo.Location = new System.Drawing.Point(330, 112);
            this.STC_Sexo.Name = "STC_Sexo";
            this.STC_Sexo.Size = new System.Drawing.Size(44, 20);
            this.STC_Sexo.TabIndex = 14;
            this.STC_Sexo.Text = "Sexo:";
            // 
            // COMBO_Sexo
            // 
            this.COMBO_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMBO_Sexo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMBO_Sexo.FormattingEnabled = true;
            this.COMBO_Sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.COMBO_Sexo.Location = new System.Drawing.Point(464, 110);
            this.COMBO_Sexo.Name = "COMBO_Sexo";
            this.COMBO_Sexo.Size = new System.Drawing.Size(45, 25);
            this.COMBO_Sexo.TabIndex = 6;
            // 
            // STC_Direccion
            // 
            this.STC_Direccion.AutoSize = true;
            this.STC_Direccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Direccion.Location = new System.Drawing.Point(17, 203);
            this.STC_Direccion.Name = "STC_Direccion";
            this.STC_Direccion.Size = new System.Drawing.Size(75, 20);
            this.STC_Direccion.TabIndex = 16;
            this.STC_Direccion.Text = "Dirección:";
            // 
            // EDT_Direccion
            // 
            this.EDT_Direccion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Direccion.Location = new System.Drawing.Point(123, 203);
            this.EDT_Direccion.MaxLength = 30;
            this.EDT_Direccion.Multiline = true;
            this.EDT_Direccion.Name = "EDT_Direccion";
            this.EDT_Direccion.Size = new System.Drawing.Size(535, 56);
            this.EDT_Direccion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tel. Emergencia:";
            // 
            // EDT_Telefono
            // 
            this.EDT_Telefono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Telefono.Location = new System.Drawing.Point(123, 172);
            this.EDT_Telefono.MaxLength = 10;
            this.EDT_Telefono.Name = "EDT_Telefono";
            this.EDT_Telefono.Size = new System.Drawing.Size(194, 25);
            this.EDT_Telefono.TabIndex = 4;
            this.EDT_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDT_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionNumeros);
            // 
            // EDT_TelefonoEm
            // 
            this.EDT_TelefonoEm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_TelefonoEm.Location = new System.Drawing.Point(464, 143);
            this.EDT_TelefonoEm.MaxLength = 10;
            this.EDT_TelefonoEm.Name = "EDT_TelefonoEm";
            this.EDT_TelefonoEm.Size = new System.Drawing.Size(194, 25);
            this.EDT_TelefonoEm.TabIndex = 7;
            this.EDT_TelefonoEm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EDT_TelefonoEm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionNumeros);
            // 
            // STC_Telefono
            // 
            this.STC_Telefono.AutoSize = true;
            this.STC_Telefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Telefono.Location = new System.Drawing.Point(17, 174);
            this.STC_Telefono.Name = "STC_Telefono";
            this.STC_Telefono.Size = new System.Drawing.Size(70, 20);
            this.STC_Telefono.TabIndex = 21;
            this.STC_Telefono.Text = "Teléfono:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(606, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 52);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(548, 278);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Aceptar.TabIndex = 9;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // WIN_CAT_Pacientes_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Cerrar = true;
            this.ClientSize = new System.Drawing.Size(675, 337);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.STC_Telefono);
            this.Controls.Add(this.EDT_TelefonoEm);
            this.Controls.Add(this.EDT_Telefono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EDT_Direccion);
            this.Controls.Add(this.STC_Direccion);
            this.Controls.Add(this.COMBO_Sexo);
            this.Controls.Add(this.STC_Sexo);
            this.Controls.Add(this.EDT_Edad);
            this.Controls.Add(this.STC_Edad);
            this.Controls.Add(this.EDT_ApellidoM);
            this.Controls.Add(this.STC_ApellidoM);
            this.Controls.Add(this.EDT_ApellidoP);
            this.Controls.Add(this.STC_ApellidoP);
            this.Controls.Add(this.EDT_Nombre);
            this.Controls.Add(this.STC_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WIN_CAT_Pacientes_F";
            this.TituloBanner = "Pacientes";
            this.TituloVentana = "      DenTech - Pacientes";
            this.Load += new System.EventHandler(this.WIN_CAT_Pacientes_F_Load);
            this.Controls.SetChildIndex(this.STC_Nombre, 0);
            this.Controls.SetChildIndex(this.EDT_Nombre, 0);
            this.Controls.SetChildIndex(this.STC_ApellidoP, 0);
            this.Controls.SetChildIndex(this.EDT_ApellidoP, 0);
            this.Controls.SetChildIndex(this.STC_ApellidoM, 0);
            this.Controls.SetChildIndex(this.EDT_ApellidoM, 0);
            this.Controls.SetChildIndex(this.STC_Edad, 0);
            this.Controls.SetChildIndex(this.EDT_Edad, 0);
            this.Controls.SetChildIndex(this.STC_Sexo, 0);
            this.Controls.SetChildIndex(this.COMBO_Sexo, 0);
            this.Controls.SetChildIndex(this.STC_Direccion, 0);
            this.Controls.SetChildIndex(this.EDT_Direccion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.EDT_Telefono, 0);
            this.Controls.SetChildIndex(this.EDT_TelefonoEm, 0);
            this.Controls.SetChildIndex(this.STC_Telefono, 0);
            this.Controls.SetChildIndex(this.BTN_Aceptar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EDT_Nombre;
        private System.Windows.Forms.Label STC_Nombre;
        private System.Windows.Forms.TextBox EDT_ApellidoP;
        private System.Windows.Forms.Label STC_ApellidoP;
        private System.Windows.Forms.TextBox EDT_ApellidoM;
        private System.Windows.Forms.Label STC_ApellidoM;
        private System.Windows.Forms.Label STC_Edad;
        private System.Windows.Forms.TextBox EDT_Edad;
        private System.Windows.Forms.Label STC_Sexo;
        private System.Windows.Forms.ComboBox COMBO_Sexo;
        private System.Windows.Forms.Label STC_Direccion;
        private System.Windows.Forms.TextBox EDT_Direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EDT_Telefono;
        private System.Windows.Forms.TextBox EDT_TelefonoEm;
        private System.Windows.Forms.Label STC_Telefono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Aceptar;
    }
}