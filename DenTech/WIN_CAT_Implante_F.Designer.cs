namespace DenTech
{
    partial class WIN_CAT_Implante_F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_CAT_Implante_F));
            this.EDT_Precio = new System.Windows.Forms.TextBox();
            this.STC_Precio = new System.Windows.Forms.Label();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Aceptar = new System.Windows.Forms.Button();
            this.EDT_Descripcion = new System.Windows.Forms.TextBox();
            this.STC_Campo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EDT_Precio
            // 
            this.EDT_Precio.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Precio.Location = new System.Drawing.Point(553, 108);
            this.EDT_Precio.Name = "EDT_Precio";
            this.EDT_Precio.Size = new System.Drawing.Size(100, 25);
            this.EDT_Precio.TabIndex = 119;
            // 
            // STC_Precio
            // 
            this.STC_Precio.AutoSize = true;
            this.STC_Precio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Precio.Location = new System.Drawing.Point(9, 108);
            this.STC_Precio.Name = "STC_Precio";
            this.STC_Precio.Size = new System.Drawing.Size(53, 20);
            this.STC_Precio.TabIndex = 120;
            this.STC_Precio.Text = "Precio:";
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cancelar.FlatAppearance.BorderSize = 0;
            this.BTN_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cancelar.Image")));
            this.BTN_Cancelar.Location = new System.Drawing.Point(601, 139);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cancelar.TabIndex = 118;
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Aceptar
            // 
            this.BTN_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Aceptar.FlatAppearance.BorderSize = 0;
            this.BTN_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Aceptar.Image")));
            this.BTN_Aceptar.Location = new System.Drawing.Point(543, 139);
            this.BTN_Aceptar.Name = "BTN_Aceptar";
            this.BTN_Aceptar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Aceptar.TabIndex = 117;
            this.BTN_Aceptar.UseVisualStyleBackColor = false;
            this.BTN_Aceptar.Click += new System.EventHandler(this.BTN_Aceptar_Click);
            // 
            // EDT_Descripcion
            // 
            this.EDT_Descripcion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDT_Descripcion.Location = new System.Drawing.Point(103, 75);
            this.EDT_Descripcion.Name = "EDT_Descripcion";
            this.EDT_Descripcion.Size = new System.Drawing.Size(550, 25);
            this.EDT_Descripcion.TabIndex = 116;
            // 
            // STC_Campo
            // 
            this.STC_Campo.AutoSize = true;
            this.STC_Campo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC_Campo.Location = new System.Drawing.Point(7, 77);
            this.STC_Campo.Name = "STC_Campo";
            this.STC_Campo.Size = new System.Drawing.Size(90, 20);
            this.STC_Campo.TabIndex = 115;
            this.STC_Campo.Text = "Descripción:";
            // 
            // WIN_CAT_Implante_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Cerrar = true;
            this.ClientSize = new System.Drawing.Size(660, 200);
            this.Controls.Add(this.EDT_Precio);
            this.Controls.Add(this.STC_Precio);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Aceptar);
            this.Controls.Add(this.EDT_Descripcion);
            this.Controls.Add(this.STC_Campo);
            this.Name = "WIN_CAT_Implante_F";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TituloBanner = "Implante";
            this.TituloVentana = "      DenTech - Implante";
            this.Load += new System.EventHandler(this.WIN_CAT_Implante_F_Load);
            this.Controls.SetChildIndex(this.STC_Campo, 0);
            this.Controls.SetChildIndex(this.EDT_Descripcion, 0);
            this.Controls.SetChildIndex(this.BTN_Aceptar, 0);
            this.Controls.SetChildIndex(this.BTN_Cancelar, 0);
            this.Controls.SetChildIndex(this.STC_Precio, 0);
            this.Controls.SetChildIndex(this.EDT_Precio, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EDT_Precio;
        private System.Windows.Forms.Label STC_Precio;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Aceptar;
        private System.Windows.Forms.TextBox EDT_Descripcion;
        private System.Windows.Forms.Label STC_Campo;
    }
}