namespace DenTech
{
    partial class WIN_Template_T
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WIN_Template_T));
            this.STC_TituloBanner = new System.Windows.Forms.Label();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STC_TituloBanner
            // 
            this.STC_TituloBanner.AutoSize = true;
            this.STC_TituloBanner.Font = new System.Drawing.Font("Segoe UI Semilight", 50F);
            this.STC_TituloBanner.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.STC_TituloBanner.Location = new System.Drawing.Point(371, 19);
            this.STC_TituloBanner.Name = "STC_TituloBanner";
            this.STC_TituloBanner.Size = new System.Drawing.Size(199, 89);
            this.STC_TituloBanner.TabIndex = 45;
            this.STC_TituloBanner.Text = "Titulo";
            this.STC_TituloBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Cerrar.FlatAppearance.BorderSize = 0;
            this.BTN_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Cerrar.Image")));
            this.BTN_Cerrar.Location = new System.Drawing.Point(1030, 530);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(52, 52);
            this.BTN_Cerrar.TabIndex = 46;
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // WIN_Template_T
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 592);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.STC_TituloBanner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WIN_Template_T";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIN_Template_T";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label STC_TituloBanner;
        private System.Windows.Forms.Button BTN_Cerrar;
    }
}